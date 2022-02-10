namespace X39.Util;

/// <summary>
/// Contains utility classes for <see cref="System.Char"/>
/// </summary>
public static class CharExtensionMethods
{
    /// <summary>
    /// Transforms the provided <paramref name="charArray"/> to a <see cref="string"/> by calling
    /// <see cref="string.string(char[])"/>.
    /// </summary>
    /// <param name="charArray">The characters to create a string from.</param>
    /// <returns>A newly created string.</returns>
    public static string AsString(this char[] charArray)
        => new(charArray);

    /// <summary>
    /// Transforms the provided <paramref name="chars"/> to a <see cref="string"/> by calling
    /// <see cref="string.string(char[])"/> after converting the <paramref name="chars"/> to an array, using
    /// <see cref="Enumerable.ToArray{TSource}"/>. 
    /// </summary>
    /// <param name="chars">The characters to create a string from.</param>
    /// <returns>A newly created string.</returns>
    public static string AsString(this IEnumerable<char> chars)
        => new(chars.ToArray());

    /// <inheritdoc cref="char.ToUpper(char)"/>
    public static char ToUpper(this char c)
        => char.ToUpperInvariant(c);

    /// <inheritdoc cref="char.ToLower(char)"/>
    public static char ToLower(this char c)
        => char.ToLower(c);

    /// <inheritdoc cref="char.ToUpperInvariant(char)"/>
    public static char ToUpperInvariant(this char c)
        => char.ToUpperInvariant(c);

    /// <inheritdoc cref="char.ToLowerInvariant(char)"/>
    public static char ToLowerInvariant(this char c)
        => char.ToLowerInvariant(c);

    /// <inheritdoc cref="char.IsNumber(char)"/>
    public static bool IsNumber(this char c)
        => char.IsNumber(c);

    /// <inheritdoc cref="char.IsAscii(char)"/>
    public static bool IsAscii(this char c)
        => char.IsAscii(c);

    /// <inheritdoc cref="char.IsDigit(char)"/>
    public static bool IsDigit(this char c)
        => char.IsDigit(c);

    /// <inheritdoc cref="char.IsLetter(char)"/>
    public static bool IsLetter(this char c)
        => char.IsLetter(c);

    /// <inheritdoc cref="char.IsPunctuation(char)"/>
    public static bool IsPunctuation(this char c)
        => char.IsPunctuation(c);

    /// <inheritdoc cref="char.IsLower(char)"/>
    public static bool IsLower(this char c)
        => char.IsLower(c);

    /// <inheritdoc cref="char.IsUpper(char)"/>
    public static bool IsUpper(this char c)
        => char.IsUpper(c);

    /// <inheritdoc cref="char.IsSymbol(char)"/>
    public static bool IsSymbol(this char c)
        => char.IsSymbol(c);

    /// <inheritdoc cref="char.IsSurrogate(char)"/>
    public static bool IsSurrogate(this char c)
        => char.IsSurrogate(c);

    /// <inheritdoc cref="char.IsHighSurrogate(char)"/>
    public static bool IsHighSurrogate(this char c)
        => char.IsHighSurrogate(c);

    /// <inheritdoc cref="char.IsSeparator(char)"/>
    public static bool IsSeparator(this char c)
        => char.IsSeparator(c);

    /// <inheritdoc cref="char.IsWhiteSpace(char)"/>
    public static bool IsWhiteSpace(this char c)
        => char.IsWhiteSpace(c);

    /// <inheritdoc cref="char.IsLetterOrDigit(char)"/>
    public static bool IsLetterOrDigit(this char c)
        => char.IsLetterOrDigit(c);
}