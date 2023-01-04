#nullable enable
using System.ComponentModel;
using System.Diagnostics;
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
    private static readonly RWLConcurrentDictionary<Type, Type> DeNulledTypeCache = new();
    private static readonly RWLConcurrentDictionary<Type, string> FullNameCache = new();
    private static readonly RWLConcurrentDictionary<Type, string> NameCache = new();
    private static readonly RWLConcurrentDictionary<Type, Type> BaseTypeCache = new();
    private static readonly RWLConcurrentDictionary<Type, bool> IsObsoleteCache = new();

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
    private static readonly RWLConcurrentDictionary<(Type returnType, Type[] arguments), Delegate> CreateInstanceCache =
        new();
#else
    private static readonly RWLConcurrentDictionary<Tuple<Type, Type[]>, Delegate> CreateInstanceCache =
        new();
#endif

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
    }

    /// <summary>
    /// Generates a valid C#-Code name from any type, including generics.
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string FullName(this Type t)
    {
        if (FullNameCache.TryGetValue(t, out var fullName))
            return fullName;
        if (t.IsGenericParameter)
            return t.Name;
        if (!t.IsGenericType)
            return t.FullName?.Replace('+', '.') ?? "NULL";

        var builder = new StringBuilder();
        builder.Append(t.Namespace);
        builder.Append('.');
#if NET5_0_OR_GREATER
        builder.Append(t.Name[..t.Name.IndexOf('`')].Replace('+', '.'));
#else
        builder.Append(t.Name.Substring(0, t.Name.IndexOf('`')).Replace('+', '-'));
#endif
        builder.Append('<');
        builder.Append(string.Join(", ", t.GetGenericArguments().Select(FullName)));
        builder.Append('>');
        return FullNameCache[t] = builder.ToString();
    }

    /// <summary>
    /// Generates a valid C#-Code name from any type, including generics.
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string Name(this Type t)
    {
        if (NameCache.TryGetValue(t, out var name))
            return name;
        if (!t.IsGenericType) return t.Name;
        var builder = new StringBuilder();
#if NET5_0_OR_GREATER
        builder.Append(t.Name[..t.Name.IndexOf('`')]);
#else
        builder.Append(t.Name.Substring(0, t.Name.IndexOf('`')));
#endif
        builder.Append('<');
        builder.Append(string.Join(", ", t.GetGenericArguments().Select(FullName)));
        builder.Append('>');
        return NameCache[t] = builder.ToString();
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
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (t, Type.EmptyTypes);
#else
        var key = Tuple.Create(t, Type.EmptyTypes);
#endif
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
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (t, types);
#else
        var key = Tuple.Create(t, types);
#endif
        if (CreateInstanceCache.TryGetValue(key, out var @delegate))
            return @delegate.DynamicInvoke()!;
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
        if (tmp is false && type.DeclaringType?.IsObsolete(useCache: useCache) is {} classObsolete)
            tmp = classObsolete;
        if (useCache)
            IsObsoleteCache[type] = tmp;
        return tmp;
    }
}