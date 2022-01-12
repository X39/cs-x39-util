using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace X39.Util.Collections.Concurrent;

[PublicAPI]
// ReSharper disable once InconsistentNaming
public sealed class RWLConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDisposable
    where TKey : notnull
{
    private readonly Dictionary<TKey, TValue> _dictionary = new();
    private readonly ReaderWriterLockSlim _lock = new();

    public void Dispose()
    {
        _lock.Dispose();
    }


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
    {
        _lock.EnterWriteLock();
        try
        {
            ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).Add(item);
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    /// <inheritdoc cref="Dictionary{TKey,TValue}.Clear"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a write-lock.
    /// </remarks>
    public void Clear()
    {
        _lock.EnterWriteLock();
        try
        {
            _dictionary.Clear();
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    /// <inheritdoc cref="ICollection{T}.Contains"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        _lock.EnterReadLock();
        try
        {
            return _dictionary.Contains(item);
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    /// <inheritdoc cref="ICollection{T}.CopyTo"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        _lock.EnterReadLock();
        try
        {
            ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).CopyTo(array, arrayIndex);
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    /// <inheritdoc cref="ICollection{T}.Remove"/>
    /// <remarks>
    /// Thread safety guaranteed by entering an upgradable read-lock,
    /// checking whether the dictionary actually contains the key and then entering the write-lock.
    /// </remarks>
    public bool Remove(KeyValuePair<TKey, TValue> item)
    {
        _lock.EnterUpgradeableReadLock();
        try
        {
            if (!_dictionary.Contains(item))
                return false;
            _lock.EnterWriteLock();
            try
            {
                return ((ICollection<KeyValuePair<TKey, TValue>>) _dictionary).Remove(item);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
        finally
        {
            _lock.ExitUpgradeableReadLock();
        }
    }

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
    {
        _lock.EnterWriteLock();
        try
        {
            _dictionary.Add(key, value);
        }
        finally
        {
            _lock.ExitWriteLock();
        }
    }

    /// <inheritdoc cref="Dictionary{TKey,TValue}.ContainsKey"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
    {
        _lock.EnterReadLock();
        try
        {
            return _dictionary.ContainsKey(key);
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    /// <inheritdoc cref="Dictionary{TKey,TValue}.Remove(TKey)"/>
    /// <remarks>
    /// Thread safety guaranteed by entering an upgradable read-lock,
    /// checking whether the dictionary actually contains the key and then entering the write-lock.
    /// </remarks>
    public bool Remove(TKey key)
    {
        _lock.EnterUpgradeableReadLock();
        try
        {
            if (!_dictionary.ContainsKey(key))
                return false;
            _lock.EnterWriteLock();
            try
            {
                return _dictionary.Remove(key);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
        finally
        {
            _lock.ExitUpgradeableReadLock();
        }
    }

    /// <inheritdoc cref="Dictionary{TKey,TValue}.TryGetValue"/>
    /// <remarks>
    /// Thread safety guaranteed by entering a read-lock.
    /// </remarks>
    // ReSharper disable once ArgumentsStyleLiteral
    // ReSharper disable once RedundantNullableFlowAttribute
#pragma warning disable CS8767
    public bool TryGetValue(TKey key, [MaybeNullWhen(returnValue: false)] out TValue? value)
#pragma warning restore CS8767
    {
        _lock.EnterReadLock();
        try
        {
            return _dictionary.TryGetValue(key, out value);
        }
        finally
        {
            _lock.ExitReadLock();
        }
    }

    /// <inheritdoc cref="Dictionary{TKey,TValue}.this"/>
    /// <remarks>
    /// GET: Thread safety guaranteed by entering a read-lock.
    /// SET: Thread safety guaranteed by entering a write-lock.
    /// </remarks>
    public TValue this[TKey key]
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _dictionary[key];
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _dictionary[key] = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    ICollection<TKey> IDictionary<TKey, TValue>.Keys
        => throw new NotSupportedException(
            "This operation is not supported as thread safety cannot be guaranteed for Keys-Collection.");

    ICollection<TValue> IDictionary<TKey, TValue>.Values
        => throw new NotSupportedException(
            "This operation is not supported as thread safety cannot be guaranteed for Keys-Collection.");
}