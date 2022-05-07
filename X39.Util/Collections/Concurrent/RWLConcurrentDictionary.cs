using System.Collections;
using System.Diagnostics.CodeAnalysis;
using X39.Util.Threading;

namespace X39.Util.Collections.Concurrent;

/// <summary>
/// A concurrent <see cref="IDictionary{TKey,TValue}"/> that works by utilizing
/// <see cref="ReaderWriterLockSlim"/> for all operations.
/// </summary>
/// <typeparam name="TKey">The key type.</typeparam>
/// <typeparam name="TValue">The value type.</typeparam>
[PublicAPI]
// ReSharper disable once InconsistentNaming
public sealed class RWLConcurrentDictionary<TKey, TValue> :
    IDictionary<TKey, TValue>,
    IDisposable
#if NET5_0_OR_GREATER
    , IAsyncDisposable
#endif
    where TKey : notnull
{
    private readonly Dictionary<TKey, TValue> _dictionary = new();
    private readonly ReaderWriterLockSlim _lock = new();

    public void Dispose()
    {
        _lock.Dispose();
    }

#if NET5_0_OR_GREATER
    public ValueTask DisposeAsync()
    {
        _lock.Dispose();
        return default;
    }
#endif


    /// <inheritdoc cref="Dictionary{TKey,TValue}.GetEnumerator"/>
    /// <remarks>
    /// Thread-safety guaranteed by blocking the  <see cref="RWLConcurrentDictionary{TKey,TValue}"/>
    /// until the returned <see cref="IEnumerator{T}"/> was fully yielded.
    /// </remarks>
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        _lock.EnterReadLock();
        try
        {
            foreach (var keyValuePair in _dictionary)
            {
                yield return keyValuePair;
            }
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator"/>
    /// <remarks>
    /// Thread-safety guaranteed by blocking the  <see cref="RWLConcurrentDictionary{TKey,TValue}"/>
    /// until the returned <see cref="IEnumerator"/> was fully yielded.
    /// </remarks>
    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();

    /// <inheritdoc cref="ICollection{T}.Add"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a write-lock.
    /// </remarks>
    public void Add(KeyValuePair<TKey, TValue> item)
        => _lock.WriteLocked(() => ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).Add(item));

    /// <inheritdoc cref="Dictionary{TKey,TValue}.Clear"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a write-lock.
    /// </remarks>
    public void Clear()
        => _lock.WriteLocked(() => _dictionary.Clear());

    /// <inheritdoc cref="ICollection{T}.Contains"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    public bool Contains(KeyValuePair<TKey, TValue> item)
        => _lock.ReadLocked(() => _dictionary.Contains(item));

    /// <inheritdoc cref="ICollection{T}.CopyTo"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        => _lock.ReadLocked(() => ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).CopyTo(array, arrayIndex));

    /// <inheritdoc cref="ICollection{T}.Remove"/>
    /// <remarks>
    /// Thread safety guaranteed by entering an upgradable read-lock,
    /// checking whether the dictionary actually contains the key and then entering the write-lock.
    /// </remarks>
    public bool Remove(KeyValuePair<TKey, TValue> item)
        => _lock.UpgradeableReadLocked(
            () => _dictionary.Contains(item)
                  && _lock.WriteLocked(
                      () => ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).Remove(item)));

    /// <inheritdoc cref="Dictionary{TKey,TValue}.Count"/>
    public int Count
        => _dictionary.Count;

    /// <inheritdoc cref="ICollection{T}.IsReadOnly"/>
    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
        => ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).IsReadOnly;

    /// <inheritdoc cref="Dictionary{TKey,TValue}.Add"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a write-lock.
    /// </remarks>
    void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
        => _lock.WriteLocked(() => _dictionary.Add(key, value));

    /// <inheritdoc cref="Dictionary{TKey,TValue}.ContainsKey"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
        => _lock.ReadLocked(() => _dictionary.ContainsKey(key));

    /// <inheritdoc cref="Dictionary{TKey,TValue}.Remove(TKey)"/>
    /// <remarks>
    /// Thread safety guaranteed by entering an upgradable read-lock,
    /// checking whether the dictionary actually contains the key and then entering the write-lock.
    /// </remarks>
    public bool Remove(TKey key)
        => _lock.UpgradeableReadLocked(
            () => _dictionary.ContainsKey(key)
                  && _lock.WriteLocked(() => _dictionary.Remove(key)));

    /// <inheritdoc cref="Dictionary{TKey,TValue}.TryGetValue"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    // ReSharper disable once ArgumentsStyleLiteral
    // ReSharper disable once RedundantNullableFlowAttribute
    public bool TryGetValue(
        TKey key,
        [MaybeNullWhen(returnValue: false)]
        out TValue value)
    {
        TValue? tmp = default!;
        var result = _lock.ReadLocked(() =>
        {
            var tmpResult = _dictionary.TryGetValue(key, out tmp);
            return tmpResult;
        });
        value = tmp;
        return result;
    }

    /// <inheritdoc cref="Dictionary{TKey,TValue}.this"/>
    /// <remarks>
    /// GET: Thread safety guaranteed by entering a read-lock.
    /// SET: Thread safety guaranteed by entering a write-lock.
    /// </remarks>
    public TValue this[TKey key]
    {
        get => _lock.ReadLocked(() => _dictionary[key]);
        set => _lock.WriteLocked(() => _dictionary[key] = value);
    }

    ICollection<TKey> IDictionary<TKey, TValue>.Keys
        => throw new NotSupportedException(
            "This operation is not supported as thread safety cannot be guaranteed for Keys-Collection.");

    ICollection<TValue> IDictionary<TKey, TValue>.Values
        => throw new NotSupportedException(
            "This operation is not supported as thread safety cannot be guaranteed for Keys-Collection.");
}