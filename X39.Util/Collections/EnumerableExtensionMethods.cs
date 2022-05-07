using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
    public static IEnumerable<T> DropNull<T>(this IEnumerable<T?> source)
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
    public static IEnumerable<T> NotNull<T>(this IEnumerable<T?> source)
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
    public static IEnumerable<T> NotNull<T>(this IEnumerable<Nullable<T>> source)
        where T : struct
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), nameof(source) + " is null.");

        return source.Where((t) => t.HasValue).Select((t) => t!.Value);
    }
    
    

    /// <summary>Determines whether all elements of a sequence do not satisfy a condition.</summary>
    /// <param name="source">An <see cref="IEnumerable{TSource}" /> that contains the elements to apply the predicate to.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
    /// <exception cref="T:System.ArgumentNullException">
    /// <paramref name="source" /> is <see langword="null" />.
    /// </exception>
    /// <exception cref="T:System.ArgumentNullException">
    /// <paramref name="predicate" /> is <see langword="null" />.
    /// </exception>
    /// <returns>
    /// <see langword="false" /> if any element of the source sequence passes the test in the specified predicate;
    /// otherwise, <see langword="true" />.
    /// </returns>
    // ReSharper disable once ConvertNullableToShortForm
    public static bool None<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), nameof(source) + " is null.");
        if (predicate is null)
            throw new ArgumentNullException(nameof(predicate), nameof(predicate) + " is null.");

        return !source.Any(predicate);
    }
    
    /// <summary>
    /// Makes a <see cref="IEnumerable{T}"/> return its <typeparamref name="T"/> along with
    /// an index of the element.
    /// </summary>
    /// <remarks>
    /// Equivalent to calling <code>source.Select((value, index) => (value, index))</code>
    /// </remarks>
    /// <param name="source">An <see cref="IEnumerable{TSource}" /> to add an index to.</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IEnumerable<(T value, int index)> Indexed<T>(this IEnumerable<T> source)
    {
        return source.Select((value, index) => (value, index));
    }
}