using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace X39.Util;

/// <summary>
/// Contains utility classes for <see cref="System.String"/>
/// </summary>
[PublicAPI]
public static partial class StringExtensionMethods
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
    
    /// <summary>
    /// Inverted function of <see cref="IsNullOrWhiteSpace"/>.
    /// Indicates whether a specified string is not <see langword="null"/>, an empty string (""),
    /// or consists only of white-space characters.
    /// </summary>
    /// <param name="value">The string to test.</param>
    /// <returns>
    ///     <see langword="false"/> if the value parameter is <see langword="null"/> or an empty string (""),
    ///     or if value consists exclusively of white-space characters.
    /// </returns>
    [Pure]
    [ContractAnnotation("null=>false", true)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNullOrWhiteSpace([NotNullWhen(true)] this string? value)
        => !string.IsNullOrWhiteSpace(value);

    /// <summary>
    /// Inverted function of <see cref="IsNullOrEmpty"/>.
    /// Indicates whether a specified string is not <see langword="null"/> or an empty string ("").
    /// </summary>
    /// <param name="value">The string to test.</param>
    /// <returns>
    ///     <see langword="false"/> if the value parameter is <see langword="null"/> or an empty string ("").
    /// </returns>
    [Pure]
    [ContractAnnotation("null=>false", true)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNullOrEmpty([NotNullWhen(true)] this string? value)
        => !string.IsNullOrEmpty(value);

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


#if NET7_0_OR_GREATER

    /// <summary>
    /// Converts this <see cref="string"/> to the given <typeparamref name="T"/> that must implement the
    /// <see cref="IParsable{TSelf}"/> <see langword="interface"/>.
    /// Will parse <typeparamref name="T"/> with <see cref="CultureInfo.CurrentCulture"/>.
    /// </summary>
    /// <param name="self">The source <see cref="string"/> to convert from.</param>
    /// <typeparam name="T">The <see cref="Type"/> to return.</typeparam>
    /// <returns>The value that was returned by <see cref="IParsable{TSelf}.Parse"/>.</returns>
    public static T ToParsable<T>(this string self) where T : IParsable<T>
    {
        return T.Parse(self, CultureInfo.CurrentCulture);
    }

    /// <summary>
    /// Converts this <see cref="string"/> to the given <typeparamref name="T"/> that must implement the
    /// <see cref="IParsable{TSelf}"/> <see langword="interface"/>.
    /// </summary>
    /// <param name="self">The source <see cref="string"/> to convert from.</param>
    /// <param name="formatProvider">
    ///     An optional <see cref="IFormatProvider"/> to specify the format used.
    ///     Defaults to <see cref="CultureInfo.CurrentCulture"/> if <see langword="null"/> is provided.
    /// </param>
    /// <typeparam name="T">The <see cref="Type"/> to return.</typeparam>
    /// <returns>The value that was returned by <see cref="IParsable{TSelf}.Parse"/>.</returns>
    public static T ToParsable<T>(this string self, IFormatProvider formatProvider) where T : IParsable<T>
    {
        return T.Parse(self, formatProvider);
    }

    /// <summary>
    /// Converts this <see cref="string"/> to the given <typeparamref name="T"/> that must implement the
    /// <see cref="ISpanParsable{TSelf}"/> <see langword="interface"/>.
    /// Will parse <typeparamref name="T"/> with <see cref="CultureInfo.CurrentCulture"/>.
    /// </summary>
    /// <param name="self">The source <see cref="string"/> to convert from.</param>
    /// <typeparam name="T">The <see cref="Type"/> to return.</typeparam>
    /// <returns>
    ///     The value that was returned by
    ///     <see cref="ISpanParsable{TSelf}.Parse(System.ReadOnlySpan{char},System.IFormatProvider?)"/>.
    /// </returns>
    public static T ToSpanParsable<T>(this string self)
        where T : ISpanParsable<T>
    {
        return T.Parse(self.AsSpan(), CultureInfo.CurrentCulture);
    }

    /// <summary>
    /// Converts this <see cref="string"/> to the given <typeparamref name="T"/> that must implement the
    /// <see cref="ISpanParsable{TSelf}"/> <see langword="interface"/>.
    /// </summary>
    /// <param name="self">The source <see cref="string"/> to convert from.</param>
    /// <param name="formatProvider">
    ///     An optional <see cref="IFormatProvider"/> to specify the format used.
    ///     Defaults to <see cref="CultureInfo.CurrentCulture"/> if <see langword="null"/> is provided.
    /// </param>
    /// <typeparam name="T">The <see cref="Type"/> to return.</typeparam>
    /// <returns>
    ///     The value that was returned by
    ///     <see cref="ISpanParsable{TSelf}.Parse(System.ReadOnlySpan{char},System.IFormatProvider?)"/>.
    /// </returns>
    public static T ToSpanParsable<T>(this string self, IFormatProvider? formatProvider)
        where T : ISpanParsable<T>
    {
        return T.Parse(self.AsSpan(), formatProvider);
    }

#endif
}