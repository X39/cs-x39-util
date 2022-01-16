using System.Diagnostics.CodeAnalysis;

namespace X39.Util;

/// <summary>
/// Contains utility classes for <see cref="System.String"/>
/// </summary>
public static class StringExtensionMethods
{
    /// <summary>
    /// Indicates whether a specified <see cref="string"/> is null,
    /// <see cref="string.Empty"/>,
    /// or consists only of white-space characters.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to test.</param>
    /// <returns>
    /// True if the value parameter is null,
    /// or <see cref="string.Empty"/>,
    /// or if value consists exclusively of white-space characters.
    /// </returns>
    [ContractAnnotation("null=>true", true)]
    [Pure]
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
        => string.IsNullOrWhiteSpace(value);
    /// <summary>
    /// Indicates whether the specified <see cref="string"/> is null or an <see cref="string.Empty"/> <see cref="string"/> ("").
    /// </summary>
    /// <param name="value">The <see cref="string"/> to test.</param>
    /// <returns>
    /// True if the value parameter is null or an <see cref="string.Empty"/> <see cref="string"/> (""); otherwise, false.
    /// </returns>
    [ContractAnnotation("null=>true", true)]
    [Pure]
    public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
        => string.IsNullOrEmpty(value);
}