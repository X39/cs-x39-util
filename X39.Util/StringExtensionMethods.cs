using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X39.Util;

/// <summary>
/// Contains utility classes for <see cref="System.String"/>
/// </summary>
public static class StringExtensionMethods
{
    /// <inheritdoc cref="string.IsNullOrWhiteSpace"/>
    [Pure]
    [ContractAnnotation("null=>true", true)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
        => string.IsNullOrWhiteSpace(value);

    /// <inheritdoc cref="string.IsNullOrEmpty"/>
    [Pure]
    [ContractAnnotation("null=>true", true)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
        => string.IsNullOrEmpty(value);

    /// <inheritdoc cref="string.Format(string,object)"/>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [StringFormatMethod("format")]
    public static string Format(this string format, object arg0)
        => string.Format(format, arg0);

    /// <inheritdoc cref="string.Format(string,object,object)"/>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [StringFormatMethod("format")]
    public static string Format(this string format, object arg0, object arg1)
        => string.Format(format, arg0, arg1);

    /// <inheritdoc cref="string.Format(string,object,object, object)"/>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [StringFormatMethod("format")]
    public static string Format(this string format, object arg0, object arg1, object arg2)
        => string.Format(format, arg0, arg1, arg2);

    /// <inheritdoc cref="string.Format(string,object[])"/>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [StringFormatMethod("format")]
    public static string Format(this string format, params object[] args)
        => string.Format(format, args);

    /// <inheritdoc cref="ToUri(string, UriKind)"/>
    public static Uri ToUri(this string source)
        => new(source);
    
    /// <summary>
    /// Creates a new <see cref="Uri"/> from <paramref name="source"/>.
    /// </summary>
    /// <param name="source">The string containing a uri.</param>
    /// <param name="uriKind">The kind of uri that <paramref name="source"/> is.</param>
    /// <returns>A new <see cref="Uri"/> instance.</returns>
    public static Uri ToUri(this string source, UriKind uriKind)
        => new(source, uriKind);
}