#nullable enable
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using X39.Util.Collections;
using X39.Util.Collections.Concurrent;

namespace X39.Util;

/// <summary>
/// Offers utility method when working with <see cref="Type"/>.
/// </summary>
[PublicAPI]
public static partial class TypeExtensionMethods
{
    // ReSharper disable once IdentifierTypo
    internal static readonly RWLConcurrentDictionary<TypeKey, Type> DeNulledTypeCache = new();
    internal static readonly RWLConcurrentDictionary<TypeKey, string> FullNameCache = new();
    internal static readonly RWLConcurrentDictionary<TypeKey, string> NameCache = new();
    internal static readonly RWLConcurrentDictionary<TypeKey, Type> BaseTypeCache = new();
    internal static readonly RWLConcurrentDictionary<TypeKey, bool> IsObsoleteCache = new();

    internal struct InstanceCacheKey : IEquatable<InstanceCacheKey>
    {
        public bool Equals(InstanceCacheKey other)
        {
            return Type.IsEquivalentTo(other.Type)
                   && Arguments.Length == other.Arguments.Length
                   && Arguments.Zip(other.Arguments, (l, r) => l.IsEquivalentTo(r)).All((q) => q);
        }

        public override bool Equals(object? obj)
        {
            return obj is InstanceCacheKey other && Equals(other);
        }

        public override int GetHashCode()
        {
#if NET5_0_OR_GREATER || NETSTANDARD2_1
            switch (Arguments.Length)
            {
                case 0: return Type.GetHashCode();
                case 1:
                    return HashCode.Combine(
                        Type.GetHashCode(),
                        Arguments[0].GetHashCode());
                case 2:
                    return HashCode.Combine(
                        Type.GetHashCode(),
                        Arguments[0].GetHashCode(),
                        Arguments[1].GetHashCode());
                case 3:
                    return HashCode.Combine(
                        Type.GetHashCode(),
                        Arguments[0].GetHashCode(),
                        Arguments[1].GetHashCode(),
                        Arguments[2].GetHashCode());
                case 4:
                    return HashCode.Combine(
                        Type.GetHashCode(),
                        Arguments[0].GetHashCode(),
                        Arguments[1].GetHashCode(),
                        Arguments[2].GetHashCode(),
                        Arguments[3].GetHashCode());
                case 5:
                    return HashCode.Combine(
                        Type.GetHashCode(),
                        Arguments[0].GetHashCode(),
                        Arguments[1].GetHashCode(),
                        Arguments[2].GetHashCode(),
                        Arguments[3].GetHashCode(),
                        Arguments[4].GetHashCode());
                case 6:
                    return HashCode.Combine(
                        Type.GetHashCode(),
                        Arguments[0].GetHashCode(),
                        Arguments[1].GetHashCode(),
                        Arguments[2].GetHashCode(),
                        Arguments[3].GetHashCode(),
                        Arguments[4].GetHashCode(),
                        Arguments[5].GetHashCode());
                case 7:
                    return HashCode.Combine(
                        Type.GetHashCode(),
                        Arguments[0].GetHashCode(),
                        Arguments[1].GetHashCode(),
                        Arguments[2].GetHashCode(),
                        Arguments[3].GetHashCode(),
                        Arguments[4].GetHashCode(),
                        Arguments[5].GetHashCode(),
                        Arguments[6].GetHashCode());
                default:
                    var hashCode = new HashCode();
                    hashCode.Add(Type.GetHashCode());
                    foreach (var arg in Arguments)
                    {
                        hashCode.Add(arg.GetHashCode());
                    }

                    return hashCode.ToHashCode();
            }
#else
            unchecked
            {
                return Arguments.Select((q) => q.GetHashCode()).Aggregate(
                    Type.GetHashCode(),
                    (l, r) => (int) (r + 0x9e3779b9 + (l << 6) + (l >> 2)));
            }
#endif
        }

        public static bool operator ==(InstanceCacheKey left, InstanceCacheKey right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(InstanceCacheKey left, InstanceCacheKey right)
        {
            return !left.Equals(right);
        }

        public InstanceCacheKey(Type type, Type[] arguments)
        {
            Type = type;
            Arguments = arguments;
        }

        public Type Type;
        public Type[] Arguments;
    }

    internal static readonly RWLConcurrentDictionary<InstanceCacheKey, Delegate> CreateInstanceCache = new();

    /// <summary>
    /// Clears all cached data for the methods provided by <see cref="TypeExtensionMethods"/>. 
    /// </summary>
    public static void ClearCache()
    {
        DeNulledTypeCache.Clear();
        FullNameCache.Clear();
        NameCache.Clear();
        BaseTypeCache.Clear();
        CreateInstanceCache.Clear();
        ClearDynCache();
    }

    /// <summary>
    /// Generates a valid C#-Code name from any type, including generics.
    /// </summary>
    /// <remarks>
    /// This method uses a cache to speed up successive calls.
    /// </remarks>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string FullName(this Type t)
    {
        if (FullNameCache.TryGetValue(t, out var fullName))
            return fullName;

        fullName = FullNameUncached(t);
        return FullNameCache[t] = fullName;
    }

    /// <summary>
    /// Generates a valid C#-Code name from any type, including generics.
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string FullNameUncached(this Type t)
    {
        if (t.FullName is null)
            return t.Name;
        if (t.IsGenericParameter)
            return t.FullName;
        var builder = new StringBuilder();
        var fullName = t.FullName;
        var argumentsIndex = fullName.IndexOf('[');
        var typePart = argumentsIndex == -1 ? fullName : fullName.Substring(0, argumentsIndex);
        var plusSplit = typePart.Split('+');
        var genericArguments = t.GetGenericArguments();
        var index = 0;
        bool ran = false;
        foreach (var str in plusSplit)
        {
            if (ran)
                builder.Append('.');
            ran = true;
            var gravisIndex = str.IndexOf('`');
            if (gravisIndex == -1)
                builder.Append(str);
            else
            {
                var left = str.Substring(0, gravisIndex);
                builder.Append(left);

                var right = str.Substring(gravisIndex + 1);
                var num = int.Parse(right, NumberStyles.Integer, CultureInfo.InvariantCulture);
                builder.Append('<');
                builder.Append(string.Join(", ", genericArguments.Skip(index).Take(num).Select(FullNameUncached)));
                builder.Append('>');
                index += num;
            }
        }

        if (t.IsArray)
        {
            builder.Append('[');
            builder.Append(',', t.GetArrayRank() - 1);
            builder.Append(']');
        }
        return builder.ToString();
    }

    /// <summary>
    /// Generates a valid C#-Code name from any type, including generics.
    /// </summary>
    /// <param name="t">The type for which to generate the name.</param>
    /// <returns>The generated C# code name.</returns>
    public static string Name(this Type t)
    {
        if (NameCache.TryGetValue(t, out var name))
            return name;

        name = NameUncached(t);
        return NameCache[t] = name;
    }

    /// <summary>
    /// Returns the uncached name of the specified <paramref name="t"/> type.
    /// If the type is a generic type, the generic arguments are included in the name.
    /// </summary>
    /// <param name="t">The <see cref="Type"/> to get the name of.</param>
    /// <returns>The name of the specified type.</returns>
    public static string NameUncached(this Type t)
    {
        if (!t.IsGenericType)
            return t.Name;
        var builder = new StringBuilder();
        var gravisIndex = t.Name.IndexOf('`');
        if (gravisIndex == -1)
            gravisIndex = t.Name.Length;
        builder.Append(t.Name.Substring(0, gravisIndex));
        builder.Append('<');
        builder.Append(string.Join(", ", t.GetGenericArguments().Select(FullNameUncached)));
        builder.Append('>');
        return builder.ToString();
    }

    /// <summary>
    /// Creates a default instance of this <see cref="Type"/>.
    /// Requires parameterless constructor for Value-Types
    /// </summary>
    /// <param name="t">The type to create a default value for.</param>
    /// <returns>A default value, matching the passed type</returns>
    public static object? Default(this Type t) => t.IsValueType ? t.CreateInstance() : null;

    /// <summary>
    /// Extracts, if available, the inner collection/array type out of the provided
    /// <paramref name="type"/>.
    /// </summary>
    /// <param name="type"></param>
    /// <returns>Either <paramref name="type"/> if it was no collection or the collection <see cref="Type"/>.</returns>
    public static Type GetBaseType(this Type type)
    {
        if (BaseTypeCache.TryGetValue(type, out var baseType))
            return baseType;
        if (type.IsArray)
        {
            return BaseTypeCache[type] = type.GetElementType()
                                         ?? throw new NullReferenceException();
        }

        if (type.IsGenericType && typeof(IGrouping<,>).IsEquivalentTo(type.GetGenericTypeDefinition()))
        {
            return BaseTypeCache[type] = type.GetGenericArguments().Skip(1).First();
        }

        if (type.IsGenericType && type.GetInterfaces().Any(
                (@interface) => @interface.IsGenericType
                    ? typeof(IEnumerable<>).IsEquivalentTo(@interface.GetGenericTypeDefinition())
                    : typeof(System.Collections.IEnumerable).IsEquivalentTo(@interface)))
        {
            return BaseTypeCache[type] = type.GetGenericArguments().First();
        }

        // Has no element type, exit
        return BaseTypeCache[type] = type;
    }

    /// <summary>
    /// Extracts, if available, the type from <see cref="Nullable{T}"/>
    /// <paramref name="type"/>.
    /// </summary>
    /// <param name="type"></param>
    /// <returns>
    /// Either <paramref name="type"/> if it was no
    /// <see cref="Nullable{T}"/> or the nullable <see cref="Type"/>.
    /// </returns>
    // ReSharper disable once IdentifierTypo
    public static Type GetDeNulledType(this Type type)
    {
        // ReSharper disable once IdentifierTypo
        if (DeNulledTypeCache.TryGetValue(type, out var deNulledType))
            return deNulledType;
        if (!type.IsGenericType)
        {
            return type;
        }

        var genericType = type.GetGenericTypeDefinition();
        return DeNulledTypeCache[type] = genericType.IsEquivalentTo(typeof(Nullable<>))
            ? type.GetGenericArguments().First()
            : type;
    }

    /// <summary>
    /// Creates a new instanceof the <paramref name="t"/> using the parameterless constructor,
    /// casts it to <typeparamref name="T"/> and returns it.
    /// </summary>
    /// <remarks>
    /// Calls <see cref="CreateInstance(System.Type)"/> internally.
    /// </remarks>
    /// <param name="t">The <see cref="Type"/> to create.</param>
    /// <typeparam name="T">The <see cref="Type"/> to cast the newly created instance to.</typeparam>
    /// <returns>The casted, newly created instance.</returns>
    public static T CreateInstance<T>(this Type t) => (T) CreateInstance(t);

    /// <summary>
    /// Creates a new instance of the <paramref name="t"/> using a parameterless constructor.
    /// </summary>
    /// <remarks>
    /// This method is cached.
    /// </remarks>
    /// <param name="t">The <see cref="Type"/> to create.</param>
    /// <returns>The newly created instance</returns>
    public static object CreateInstance(this Type t)
    {
        var key = new InstanceCacheKey(t, Type.EmptyTypes);
        if (CreateInstanceCache.TryGetValue(key, out var @delegate))
            return @delegate.DynamicInvoke()!;
        CreateInstanceCache[key] = @delegate = Expression.Lambda(Expression.New(t)).Compile();

        return @delegate.DynamicInvoke()!;
    }

    /// <inheritdoc cref="CreateInstanceWith{T}"/>
    [Obsolete("Use CreateInstanceWith instead")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T CreateInstance<T>(this Type t, params object[] args)
        => CreateInstanceWith<T>(t, args);

    /// <summary>
    /// Creates a new instance of the <paramref name="t"/> with the given <paramref name="args"/>.
    /// </summary>
    /// <remarks>
    /// Uses <see cref="CreateInstanceWith(System.Type,System.Type[],object[])"/> internally.
    /// </remarks>
    /// <param name="t">The <see cref="Type"/> to create.</param>
    /// <param name="args">The arguments to pass into the constructor.</param>
    /// <returns>The newly created instance.</returns>
    public static T CreateInstanceWith<T>(this Type t, params object[] args)
        => (T) CreateInstanceWith(t, args.Select((q) => q.GetType()).ToArray(), args);

    /// <inheritdoc cref="CreateInstanceWith(System.Type,object[])"/>
    [Obsolete("Use CreateInstanceWith instead")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static object CreateInstance(this Type t, params object[] args)
        => CreateInstanceWith(t, args);

    /// <summary>
    /// Creates a new instance of the <paramref name="t"/> with the given <paramref name="args"/>.
    /// </summary>
    /// <remarks>
    /// Uses <see cref="CreateInstanceWith(System.Type,System.Type[],object[])"/> internally.
    /// </remarks>
    /// <param name="t">The <see cref="Type"/> to create.</param>
    /// <param name="args">The arguments to pass into the constructor.</param>
    /// <returns>The newly created instance.</returns>
    public static object CreateInstanceWith(this Type t, params object[] args)
        => CreateInstanceWith(t, args.Select((q) => q.GetType()).ToArray(), args);

    /// <summary>
    /// Creates a new instance of the <paramref name="t"/> with the given <paramref name="args"/>.
    /// The method will use the given <paramref name="types"/> to determine which constructor to use.
    /// It will find any constructor, private or public.
    /// </summary>
    /// <remarks>
    /// This method is cached using compiled linq expressions, using <paramref name="t"/>
    /// and <paramref name="types"/> as key.
    /// It is expected that the count of <paramref name="args"/> is equal to the count of <paramref name="types"/>.
    /// This is asserted using <see cref="Debug.Assert(bool)"/>
    /// </remarks>
    /// <param name="t">The <see cref="Type"/> to create.</param>
    /// <param name="types">The <see cref="Type"/>'s of the arguments passed in</param>
    /// <param name="args">The arguments to pass into the constructor.</param>
    /// <returns>The newly created instance.</returns>
    /// <exception cref="NullReferenceException"></exception>
    public static object CreateInstanceWith(this Type t, Type[] types, object?[] args)
    {
        Debug.Assert(
            types.Length == args.Length,
            $"The count of args ({args.Length}) is not equal to the count of types ({types.Length})");
        var key = new InstanceCacheKey(t, types);
        if (CreateInstanceCache.TryGetValue(key, out var @delegate))
            return @delegate.DynamicInvoke(args)!;
        var constructor = t.GetConstructor(
                              bindingAttr: System.Reflection.BindingFlags.Public |
                                           System.Reflection.BindingFlags.Instance |
                                           System.Reflection.BindingFlags.NonPublic,
                              binder: Type.DefaultBinder,
                              types: types,
                              modifiers: Array.Empty<System.Reflection.ParameterModifier>())
                          ?? throw new NullReferenceException("Constructor method is null.");

        var parameterExpressions = args
            .Select((_, i) => Expression.Parameter(types[i], $"arg{i}"))
            .ToArray();
        // ReSharper disable once CoVariantArrayConversion
        var newExpression = Expression.New(constructor, parameterExpressions);
        var lambdaExpression = Expression.Lambda(newExpression, parameterExpressions);
        CreateInstanceCache[key] = @delegate = lambdaExpression.Compile();
        return @delegate.DynamicInvoke(args)!;
    }

    /// <summary>
    /// Creates a new instance of the <paramref name="t"/> with the given <paramref name="args"/>.
    /// The method will use the given <paramref name="types"/> to determine which constructor to use.
    /// It will find any constructor, private or public.
    /// </summary>
    /// <remarks>
    /// It is expected that the count of <paramref name="args"/> is equal to the count of <paramref name="types"/>.
    /// This is asserted using <see cref="Debug.Assert(bool)"/>
    /// </remarks>
    /// <param name="t">The <see cref="Type"/> to create.</param>
    /// <param name="types">The <see cref="Type"/>'s of the arguments passed in</param>
    /// <param name="args">The arguments to pass into the constructor.</param>
    /// <returns>The newly created instance.</returns>
    /// <exception cref="NullReferenceException"></exception>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static object CreateInstanceWithUncached(this Type t, Type[] types, object?[] args)
    {
        Debug.Assert(
            types.Length == args.Length,
            $"The count of args ({args.Length}) is not equal to the count of types ({types.Length})");
        var constructor = t.GetConstructor(
                              bindingAttr: System.Reflection.BindingFlags.Public |
                                           System.Reflection.BindingFlags.Instance |
                                           System.Reflection.BindingFlags.NonPublic,
                              binder: Type.DefaultBinder,
                              types: types,
                              modifiers: Array.Empty<System.Reflection.ParameterModifier>())
                          ?? throw new NullReferenceException("Constructor method is null.");

        var parameterExpressions = args
            .Select((_, i) => Expression.Parameter(types[i], $"arg{i}"))
            .ToArray();
        // ReSharper disable once CoVariantArrayConversion
        var newExpression = Expression.New(constructor, parameterExpressions);
        var lambdaExpression = Expression.Lambda(newExpression, parameterExpressions);
        return @lambdaExpression.Compile().DynamicInvoke(args)!;
    }

    /// <inheritdoc cref="RuntimeHelpers.RunClassConstructor"/>
    public static void RunClassConstructors(this Type type)
    {
        RuntimeHelpers.RunClassConstructor(type.TypeHandle);
    }

    /// <summary>
    /// Checks if <paramref name="type"/> is equivalent to a generic type.
    /// </summary>
    /// <remarks>
    /// Equivalent to checking if <paramref name="type"/> has <see cref="Type.IsGenericType"/>
    /// set as <see langword="true"/> and that the generic <see cref="Type"/> received via
    /// <see cref="Type.GetGenericTypeDefinition"/> is yielding true with <see cref="Type.IsEquivalentTo"/>, getting
    /// <paramref name="otherType"/> passed.
    /// </remarks>
    /// <example>
    /// <code>typeof(Nullable&lt;int&gt;).IsGenericType&lt;Nullable&lt;&gt;&gt;() // true</code>
    /// </example>>
    /// <param name="type">The type to check.</param>
    /// <param name="otherType">The generic type to check against</param>
    /// <returns><see langword="true"/> if <paramref name="type"/> is equivalent to <paramref name="otherType"/>.</returns>
    public static bool IsGenericType(this Type type, Type otherType)
        => type.IsGenericType && type.GetGenericTypeDefinition().IsEquivalentTo(otherType);

    /// <summary>
    /// Checks if <paramref name="type"/> is assignable to a generic type.
    /// </summary>
    /// <remarks>
    /// This is equivalent to <see cref="IsGenericType"/> in every aspect but that the check is using
    /// <see cref="Type.IsAssignableFrom"/> and having the arg and base swapped.
    /// </remarks>
    /// <param name="type">The type to check.</param>
    /// <param name="otherType">The generic type to check against.</param>
    /// <returns><see langword="true"/> if <paramref name="type"/> is assignable to <paramref name="otherType"/>.</returns>
    public static bool IsAssignableToGenericType(this Type type, Type otherType)
        => type.IsGenericType && otherType.IsAssignableFrom(type.GetGenericTypeDefinition());

    /// <summary>
    /// Checks if <paramref name="type"/> is assignable to a generic type.
    /// </summary>
    /// <remarks>
    /// This is equivalent to <see cref="IsGenericType"/> in every aspect but that the check is using
    /// <see cref="Type.IsAssignableFrom"/>.
    /// </remarks>
    /// <param name="type">The type to check.</param>
    /// <param name="otherType">The generic type to check against.</param>
    /// <returns><see langword="true"/> if <paramref name="type"/> is assignable to <paramref name="otherType"/>.</returns>
    public static bool IsAssignableFromGenericType(this Type type, Type otherType)
        => type.IsGenericType && type.GetGenericTypeDefinition().IsAssignableFrom(otherType);

    /// <summary>
    /// Checks if the given <paramref name="type"/> has the <see cref="ObsoleteAttribute"/> placed and hence is
    /// considered obsolete.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to check.</param>
    /// <param name="useCache">
    ///     If <see langword="true"/>, the reflection lookup will be performed once and successive calls are served
    ///     from a cache.
    ///     If <see langword="false"/>, the reflection lookup is performed every time.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <paramref name="type"/> is obsolete, <see langword="false"/> if not.
    /// </returns>
    public static bool IsObsolete(this Type type, bool useCache = true)
    {
        if (useCache && IsObsoleteCache.TryGetValue(type, out var flag))
            return flag;
        var attribute = type.GetCustomAttribute<ObsoleteAttribute>();
        var tmp = attribute is not null;
        if (tmp is false && type.DeclaringType?.IsObsolete(useCache: useCache) is { } classObsolete)
            tmp = classObsolete;
        if (useCache)
            IsObsoleteCache[type] = tmp;
        return tmp;
    }


    /// <summary>
    /// Returns a string, qualifying the provided <paramref name="type"/> against eg.
    /// <see cref="Type.GetType(string)"/>. Unlike <see cref="Type.AssemblyQualifiedName"/>,
    /// this method will provide the assembly qualified name without version or culture information.
    /// </summary>
    /// <param name="type">The type to get the assembly qualified name of.</param>
    /// <returns>The AQN without version information.</returns>
    public static string AssemblyQualifiedNameWithoutVersion(this Type type)
    {
        var custom = string.Join(
                    ", ",
                    type.FullName,
                    type.Assembly.GetName()
                        .Name
                );
        return custom;
    }
}