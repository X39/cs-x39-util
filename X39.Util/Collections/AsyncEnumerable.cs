#if NET6_0_OR_GREATER
using System.Runtime.CompilerServices;

namespace X39.Util.Collections;

/// Provides a set of static methods for asynchronous operations on sequences.
[PublicAPI]
public static class AsyncEnumerable
{
    #region ToDictionaryAsync

    /// <summary>
    ///     Asynchronously creates a dictionary from an <see cref="IAsyncEnumerable{T}"/>
    ///     where each element is transformed into a key-value pair.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TKey">The type of the key returned by the key selector function.</typeparam>
    /// <param name="values">The source sequence of elements to transform into a dictionary.</param>
    /// <param name="keySelector">A function to extract a key from each element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    ///     A <see cref="Task{TResult}"/> that represents the asynchronous operation.
    ///     The task result contains a dictionary that contains keys and values assembled from the input sequence.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown when the keySelector produces <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">Thrown when keySelector produces duplicate keys for two elements.</exception>
    public static async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(
        this IAsyncEnumerable<T> values,
        Func<T, TKey> keySelector,
        CancellationToken cancellationToken = default
    ) where TKey : notnull
    {
        var dictionary = new Dictionary<TKey, T>();

        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            var key = keySelector(t);
            dictionary.Add(key, t);
        }

        return dictionary;
    }

    /// <summary>
    ///     Asynchronously creates a dictionary from an <see cref="IAsyncEnumerable{T}"/>
    ///     where each element is transformed into a key-value pair using an asynchronous key selector.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TKey">The type of the key returned by the key selector function.</typeparam>
    /// <param name="values">The source sequence of elements to transform into a dictionary.</param>
    /// <param name="keySelector">A function to asynchronously extract a key from each element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    ///     A <see cref="Task{TResult}"/> that represents the asynchronous operation.
    ///     The task result contains a dictionary that contains keys and values assembled from the input sequence.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown when the keySelector produces <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">Thrown when keySelector produces duplicate keys for two elements.</exception>
    public static async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(
        this IAsyncEnumerable<T> values,
        Func<T, ValueTask<TKey>> keySelector,
        CancellationToken cancellationToken = default
    ) where TKey : notnull
    {
        var dictionary = new Dictionary<TKey, T>();

        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            var key = await keySelector(t).ConfigureAwait(false);
            dictionary.Add(key, t);
        }

        return dictionary;
    }

    /// <summary>
    /// Asynchronously creates a dictionary from an <see cref="IAsyncEnumerable{T}"/>
    /// where each element is transformed into a key-value pair using the provided key and value selector functions.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TKey">The type of the key returned by the key selector function.</typeparam>
    /// <typeparam name="TValue">The type of the value returned by the value selector function.</typeparam>
    /// <param name="values">The source sequence of elements to transform into a dictionary.</param>
    /// <param name="keySelector">A function to extract a key from each element.</param>
    /// <param name="valueSelector">A function to extract a value from each element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// A <see cref="Task{TResult}"/> that represents the asynchronous operation.
    /// The task result contains a dictionary that contains keys and values assembled from the input sequence.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown when the keySelector or valueSelector produces <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">Thrown when keySelector produces duplicate keys for two elements.</exception>
    public static async Task<Dictionary<TKey, TValue>> ToDictionaryAsync<T, TKey, TValue>(
        this IAsyncEnumerable<T> values,
        Func<T, TKey> keySelector,
        Func<T, TValue> valueSelector,
        CancellationToken cancellationToken = default
    ) where TKey : notnull
    {
        var dictionary = new Dictionary<TKey, TValue>();

        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            var key = keySelector(t);
            var value = valueSelector(t);
            dictionary.Add(key, value);
        }

        return dictionary;
    }

    /// <summary>
    /// Asynchronously creates a dictionary from an <see cref="IAsyncEnumerable{T}"/>
    /// where each element is transformed into a key-value pair with the specified key and value async selectors.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TKey">The type of the key returned by the key selector function.</typeparam>
    /// <typeparam name="TValue">The type of the value returned by the value selector function.</typeparam>
    /// <param name="values">The source sequence of elements to transform into a dictionary.</param>
    /// <param name="keySelector">A function to asynchronously extract a key from each element.</param>
    /// <param name="valueSelector">A function to asynchronously extract a value from each element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// A <see cref="Task{TResult}"/> that represents the asynchronous operation.
    /// The task result contains a dictionary that contains keys and values assembled from the input sequence.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown when the keySelector or valueSelector produces <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">Thrown when keySelector produces duplicate keys for two elements.</exception>
    public static async Task<Dictionary<TKey, TValue>> ToDictionaryAsync<T, TKey, TValue>(
        this IAsyncEnumerable<T> values,
        Func<T, ValueTask<TKey>> keySelector,
        Func<T, ValueTask<TValue>> valueSelector,
        CancellationToken cancellationToken = default
    ) where TKey : notnull
    {
        var dictionary = new Dictionary<TKey, TValue>();

        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            var key = await keySelector(t).ConfigureAwait(false);
            var value = await valueSelector(t).ConfigureAwait(false);
            dictionary.Add(key, value);
        }

        return dictionary;
    }

    #endregion


    /// <summary>
    /// Concatenates two <see cref="IAsyncEnumerable{T}"/> sequences and returns a single merged sequence.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the input sequences.</typeparam>
    /// <param name="source">The first async enumerable sequence to concatenate.</param>
    /// <param name="values">The second async enumerable sequence to concatenate.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> that contains the elements of both input sequences, in order.
    /// </returns>
    /// <exception cref="OperationCanceledException">The operation is canceled.</exception>
    public static async IAsyncEnumerable<T> Concat<T>(
        this IAsyncEnumerable<T> source,
        IAsyncEnumerable<T> values,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        await foreach (var t in source.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return t;
        }

        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return t;
        }
    }

    /// <summary>
    /// Asynchronously creates a <see cref="List{T}"/> from an <see cref="IAsyncEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <param name="values">The source sequence of elements to transform into a list.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// A <see cref="Task{TResult}"/> that represents the asynchronous operation.
    /// The task result contains a list that includes all the elements from the input sequence.
    /// </returns>
    public static async Task<List<T>> ToListAsync<T>(
        this IAsyncEnumerable<T> values,
        CancellationToken cancellationToken = default
    )
    {
        var collection = new List<T>();

        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            collection.Add(t);
        }

        return collection;
    }

    /// <summary>
    /// Returns an empty <see cref="IAsyncEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements to return from the enumerable.</typeparam>
    /// <returns>An empty <see cref="IAsyncEnumerable{T}"/>.</returns>
    public static IAsyncEnumerable<T> Empty<T>()
    {
        return EmptyAsyncEnumerable<T>.Instance;
    }

    /// <summary>
    /// Appends a specified value to the end of an <see cref="IAsyncEnumerable{T}"/> sequence.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="values">The source sequence of elements to append the value to.</param>
    /// <param name="value">The value to append to the end of the sequence.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> that contains the elements of the
    /// input sequence followed by the appended value.
    /// </returns>
    public static async IAsyncEnumerable<T> Append<T>(
        this IAsyncEnumerable<T> values,
        T value,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return t;
        }

        yield return value;
    }

    /// <summary>
    /// Asynchronously prepends a value to an <see cref="IAsyncEnumerable{T}"/> sequence.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <param name="values">The source sequence of elements to which the value is prepended.</param>
    /// <param name="value">The value to prepend to the sequence.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> containing the prepended value followed by the elements of the input sequence.
    /// </returns>
    public static async IAsyncEnumerable<T> Prepend<T>(
        this IAsyncEnumerable<T> values,
        T value,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        yield return value;

        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return t;
        }
    }

    #region Where

    /// <summary>
    /// Asynchronously filters an <see cref="IAsyncEnumerable{T}"/> based on a predicate.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <param name="values">The source sequence to filter.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> that contains elements from the input sequence that satisfy the condition.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown when the predicate is null.</exception>
    public static async IAsyncEnumerable<T> Where<T>(
        this IAsyncEnumerable<T> values,
        Func<T, bool> predicate,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            if (predicate(t))
                yield return t;
        }
    }

    /// <summary>
    /// Filters the elements of an <see cref="IAsyncEnumerable{T}"/> based on a predicate.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <param name="values">The source sequence to filter.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> that contains elements from the input sequence that satisfy the condition specified by predicate.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown when the predicate is <see langword="null"/>.</exception>
    public static async IAsyncEnumerable<T> Where<T>(
        this IAsyncEnumerable<T> values,
        Func<T, ValueTask<bool>> predicate,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            if (await predicate(t).ConfigureAwait(false))
                yield return t;
        }
    }

    /// <summary>
    /// Asynchronously filters the elements of an <see cref="IAsyncEnumerable{T}"/> based on a specified predicate
    /// that incorporates the element's index into the logic of the predicate.
    /// </summary>
    /// <typeparam name="T">The type of the elements of the source sequence.</typeparam>
    /// <param name="values">The source sequence of elements to filter.</param>
    /// <param name="predicate">
    /// A function to test each element for a condition, which receives the element and its zero-based index
    /// in the sequence as parameters.
    /// </param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> that contains the elements from the input sequence
    /// that satisfy the condition specified by the predicate.
    /// </returns>
    public static async IAsyncEnumerable<T> Where<T>(
        this IAsyncEnumerable<T> values,
        Func<T, int, bool> predicate,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        var i = 0;
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            if (predicate(t, i++))
                yield return t;
        }
    }

    /// <summary>
    /// Asynchronously filters an <see cref="IAsyncEnumerable{T}"/> based on a predicate function that takes
    /// the element and its index in the sequence.
    /// </summary>
    /// <typeparam name="T">The type of elements in the source sequence.</typeparam>
    /// <param name="values">The source sequence of elements to filter.</param>
    /// <param name="predicate">
    /// A function to test each element and its index for a condition,
    /// returning a <see cref="ValueTask{Boolean}"/> that evaluates to <c>true</c> if the element should be included.
    /// </param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>An <see cref="IAsyncEnumerable{T}"/> that contains elements from the input sequence that satisfy the condition.</returns>
    public static async IAsyncEnumerable<T> Where<T>(
        this IAsyncEnumerable<T> values,
        Func<T, int, ValueTask<bool>> predicate,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        var i = 0;
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            if (await predicate(t, i++).ConfigureAwait(false))
                yield return t;
        }
    }

    #endregion

    #region Select

    /// <summary>
    /// Projects each element of an <see cref="IAsyncEnumerable{T}"/> into a new form by incorporating the specified transformation function.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TSelect">The type of the elements in the resulting sequence.</typeparam>
    /// <param name="values">The source sequence of elements to transform.</param>
    /// <param name="func">A transform function to apply to each element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> whose elements are the result of invoking the transform function on each element of the source sequence.
    /// </returns>
    public static async IAsyncEnumerable<TSelect> Select<T, TSelect>(
        this IAsyncEnumerable<T> values,
        Func<T, TSelect> func,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return func(t);
        }
    }

    /// <summary>
    /// Asynchronously projects each element of a sequence into a new form.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TSelect">The type of the elements in the resulting sequence.</typeparam>
    /// <param name="values">The source sequence of elements to be projected.</param>
    /// <param name="func">A transform function to apply to each element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> that contains each transformed element.
    /// </returns>
    public static async IAsyncEnumerable<TSelect> Select<T, TSelect>(
        this IAsyncEnumerable<T> values,
        Func<T, ValueTask<TSelect>> func,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return await func(t).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Asynchronously projects each element of an <see cref="IAsyncEnumerable{T}"/>
    /// to a new form by incorporating the element's index.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TSelect">The type of the value returned by the transformation function.</typeparam>
    /// <param name="values">The source sequence of elements to transform.</param>
    /// <param name="func">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>
    /// An <see cref="IAsyncEnumerable{T}"/> whose elements are the result of invoking the transform function on each element of the input sequence.
    /// </returns>
    public static async IAsyncEnumerable<TSelect> Select<T, TSelect>(
        this IAsyncEnumerable<T> values,
        Func<T, int, TSelect> func,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        var i = 0;
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return func(t, i++);
        }
    }

    /// <summary>
    /// Asynchronously projects each element of an <see cref="IAsyncEnumerable{T}"/> into a new form
    /// by incorporating the element's index.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the source sequence.</typeparam>
    /// <typeparam name="TSelect">The type of the value returned by the transform function.</typeparam>
    /// <param name="values">The source sequence of elements to project.</param>
    /// <param name="func">A transform function to apply to each element; the second parameter of the function represents the index of the source element.</param>
    /// <param name="cancellationToken">A token to observe for cancellation requests.</param>
    /// <returns>An <see cref="IAsyncEnumerable{T}"/> whose elements are the result of invoking the transform function on each element of the source.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the transform function is <see langword="null"/>.</exception>
    public static async IAsyncEnumerable<TSelect> Select<T, TSelect>(
        this IAsyncEnumerable<T> values,
        Func<T, int, ValueTask<TSelect>> func,
        [EnumeratorCancellation] CancellationToken cancellationToken = default
    )
    {
        var i = 0;
        await foreach (var t in values.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            yield return await func(t, i++).ConfigureAwait(false);
        }
    }

    #endregion

    private class EmptyAsyncEnumerable<T> : IAsyncEnumerator<T>, IAsyncEnumerable<T>
    {
        private static EmptyAsyncEnumerable<T>? _instance;
        internal static EmptyAsyncEnumerable<T> Instance => _instance ??= new EmptyAsyncEnumerable<T>();

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = new())
        {
            return this;
        }

        public ValueTask DisposeAsync()
        {
            return default;
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return new ValueTask<bool>(false);
        }

        public T Current => default!;
    }
}
#endif