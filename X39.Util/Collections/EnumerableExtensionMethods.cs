using System.Runtime.CompilerServices;

namespace X39.Util.Collections;

/// <summary>
/// Contains methods that extend the functionality of classes implementing the <see cref="IEnumerable{T}"/> interface.
/// </summary>
[PublicAPI]
public static class EnumerableExtensionMethods
{
    /// <summary>
    ///     Drops the nullable state and throws a <see cref="NullReferenceException"/>
    ///     if any of the items given is null.
    /// </summary>
    /// <param name="source">The <see cref="Enumerable"/> without nullable reference types.</param>
    /// <returns>
    ///     A now non nullable <see cref="IEnumerable{T}"/>.
    /// </returns>
    public static IEnumerable<T> DropNull<T>([NoEnumeration] this IEnumerable<T?> source)
        where T : class
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), nameof(source) + " is null.");

#pragma warning disable CA2201
        return source.Select((q) => q ?? throw new NullReferenceException(
            "A null element is present in the enumerable."));
#pragma warning restore CA2201
    }

    /// <summary>
    ///     Transformative <see cref="Enumerable.Where{TSource}(IEnumerable{TSource}, Func{TSource, bool})"/>
    ///     that clears the nullable state by checking if a given thing is null or not.
    /// </summary>
    /// <param name="source">The <see cref="Enumerable"/> with potential nullable reference types.</param>
    /// <returns>
    ///     A now non nullable <see cref="IEnumerable{T}"/>.
    /// </returns>
    public static IEnumerable<T> NotNull<T>([NoEnumeration] this IEnumerable<T?> source)
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
    public static IEnumerable<T> NotNull<T>([NoEnumeration] this IEnumerable<Nullable<T>> source)
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
    /// <exception cref="System.ArgumentNullException">
    /// <paramref name="source" /> is <see langword="null" />.
    /// </exception>
    /// <exception cref="System.ArgumentNullException">
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

    /// <summary>Determines whether a sequence is empty.</summary>
    /// <remarks>
    /// This is named the way it is to match the
    /// <see cref="None{T}(System.Collections.Generic.IEnumerable{T},System.Func{T,bool})"/> method.
    /// </remarks>
    /// <param name="source">An <see cref="IEnumerable{TSource}" /> that contains the elements to apply the predicate to.</param>
    /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
    /// <exception cref="System.ArgumentNullException">
    /// <paramref name="source" /> is <see langword="null" />.
    /// </exception>
    /// <returns>
    /// <see langword="false" /> if any element of the source sequence passes the test in the specified predicate;
    /// otherwise, <see langword="true" />.
    /// </returns>
    // ReSharper disable once ConvertNullableToShortForm
    public static bool None<T>(this IEnumerable<T> source)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), nameof(source) + " is null.");

        return !source.Any();
    }

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

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
    public static IEnumerable<(T value, int index)> Indexed<T>([NoEnumeration] this IEnumerable<T> source)
    {
        return source.Select((value, index) => (value, index));
    }

    /// <summary>
    /// Makes a <see cref="IEnumerable{T}"/> return its <typeparamref name="T"/> along with
    /// an index of the element.
    /// </summary>
    /// <remarks>
    /// Equivalent to calling <code>source.Select((value, index) => (value, index + offset))</code>
    /// </remarks>
    /// <param name="source">An <see cref="IEnumerable{TSource}" /> to add an index to.</param>
    /// <param name="offset">The offset for the index to be inserted.</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IEnumerable<(T value, int index)> Indexed<T>([NoEnumeration] this IEnumerable<T> source, int offset)
    {
        return source.Select((value, index) => (value, index + offset));
    }
#endif
}