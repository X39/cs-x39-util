#nullable enable
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using X39.Util.Collections.Concurrent;

namespace X39.Util;

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

    public static T CreateInstance<T>(this Type t) => (T) CreateInstance(t);

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

    public static T CreateInstance<T>(this Type t, params object[] args)
        => (T) CreateInstance(t, args);

    public static object CreateInstance(this Type t, params object[] args)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (t, args.Select((q) => q.GetType()).ToArray());
#else
        var key = Tuple.Create(t, args.Select((q) => q.GetType()).ToArray());
#endif
        if (CreateInstanceCache.TryGetValue(key, out var @delegate))
            return @delegate.DynamicInvoke()!;
        var constructor = t.GetConstructor(
                              bindingAttr: System.Reflection.BindingFlags.Public |
                                           System.Reflection.BindingFlags.Instance |
                                           System.Reflection.BindingFlags.NonPublic,
                              binder: Type.DefaultBinder,
                              types: args.Select((it) => it.GetType()).ToArray(),
                              modifiers: Array.Empty<System.Reflection.ParameterModifier>())
                          ?? throw new NullReferenceException("Constructor method is null.");

        var parameterExpressions = args
            .Select((obj, i) => Expression.Parameter(obj.GetType(), $"arg{i}"))
            .ToArray();
        // ReSharper disable once CoVariantArrayConversion
        var newExpression = Expression.New(constructor, parameterExpressions);
        var lambdaExpression = Expression.Lambda(newExpression, parameterExpressions);
        CreateInstanceCache[key] = @delegate = lambdaExpression.Compile();
        return @delegate.DynamicInvoke(args)!;
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