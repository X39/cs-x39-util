using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace X39.Util;

[PublicAPI]
public static partial class TypeExtensionMethods
{
    /// <summary>
    /// Generates a valid C#-Code name from any type, including generics.
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string FullName(this Type t)
    {
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
        return builder.ToString();
    }

    /// <summary>
    /// Generates a valid C#-Code name from any type, including generics.
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string Name(this Type t)
    {
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
        if (type.IsArray)
        {
            return type.GetElementType()
                   ?? throw new NullReferenceException();
        }

        if (type.IsGenericType && typeof(IGrouping<,>).IsEquivalentTo(type.GetGenericTypeDefinition()))
        {
            return type.GetGenericArguments().Skip(1).First();
        }

        if (type.IsGenericType && type.GetInterfaces().Any(
                (@interface) => @interface.IsGenericType
                    ? typeof(IEnumerable<>).IsEquivalentTo(@interface.GetGenericTypeDefinition())
                    : typeof(System.Collections.IEnumerable).IsEquivalentTo(@interface)))
        {
            return type.GetGenericArguments().First();
        }

        // Has no element type, exit
        return type;
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
        if (!type.IsGenericType)
        {
            return type;
        }

        var genericType = type.GetGenericTypeDefinition();
        return genericType.IsEquivalentTo(typeof(Nullable<>))
            ? type.GetGenericArguments().First()
            : type;
    }

    public static T CreateInstance<T>(this Type t) =>
        (T) Expression.Lambda(Expression.New(t)).Compile().DynamicInvoke()!;

    public static object CreateInstance(this Type t)
        => Expression.Lambda(Expression.New(t)).Compile().DynamicInvoke()!;

    public static T CreateInstance<T>(this Type t, params object[] args)
    {
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
        var @delegate = lambdaExpression.Compile();
        return (T) @delegate.DynamicInvoke(args)!;
    }

    /// <inheritdoc cref="RuntimeHelpers.RunClassConstructor"/>
    public static void RunClassConstructors(this Type type)
    {
        RuntimeHelpers.RunClassConstructor(type.TypeHandle);
    }
}