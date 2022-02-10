using System.Diagnostics.CodeAnalysis;

namespace X39.Util;

/// <summary>
/// Contains utility classes for <see cref="System.String"/>
/// </summary>
public static class StringExtensionMethods
{
    /// <inheritdoc cref="string.IsNullOrWhiteSpace"/>
    [Pure]
    [ContractAnnotation("null=>true", true)]
    public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
        => string.IsNullOrWhiteSpace(value);

    /// <inheritdoc cref="string.IsNullOrEmpty"/>
    [Pure]
    [ContractAnnotation("null=>true", true)]
    public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
        => string.IsNullOrEmpty(value);
}