namespace X39.Util.Collections;

[PublicAPI]
public static class EnumerableExtensionMethods
{
    /// <summary>
    ///     Drops the nullable state and throws if any of the items given is null.
    /// </summary>
    /// <param name="source">The <see cref="Enumerable"/> without nullable reference types.</param>
    /// <returns>
    ///     A now non nullable <see cref="IEnumerable{T}"/>.
    /// </returns>
    public static IEnumerable<T> DropNull<T>(this IEnumerable<T?>? source)
        where T : class
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), nameof(source) + " is null.");

        return source.Select((q) => q ?? throw new NullReferenceException());
    }

    /// <summary>
    ///     Transformative <see cref="Enumerable.Where{TSource}(IEnumerable{TSource}, Func{TSource, bool})"/>
    ///     that clears the nullable state by checking if a given thing is null or not.
    /// </summary>
    /// <param name="source">The <see cref="Enumerable"/> with potential nullable reference types.</param>
    /// <returns>
    ///     A now non nullable <see cref="IEnumerable{T}"/>.
    /// </returns>
    public static IEnumerable<T> NotNull<T>(this IEnumerable<T?>? source)
        where T : class
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), nameof(source) + " is null.");

        return source.Where((t) => t != null)!;
    }

    /// <summary>
    ///     Transformative <see cref="Enumerable.Where{TSource}(IEnumerable{TSource}, Func{TSource, bool})"/>
    ///     that clears the nullable state by checking if a given thing is null or not.
    /// </summary>
    /// <param name="source">The <see cref="Enumerable"/> with potential nullable reference types.</param>
    /// <returns>
    ///     A now non nullable <see cref="IEnumerable{T}"/>.
    /// </returns>
    // ReSharper disable once ConvertNullableToShortForm
    public static IEnumerable<T> NotNull<T>(this IEnumerable<Nullable<T>>? source)
        where T : struct
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), nameof(source) + " is null.");

        return source.Where((t) => t.HasValue).Select((t) => t!.Value);
    }
}