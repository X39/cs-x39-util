#nullable enable
using System.Runtime.CompilerServices;

namespace X39.Util.Collections;

/// <summary>
/// Contains methods that extend the functionality of classes implementing the <see cref="IDictionary{TKey,TValue}"/> interface.
/// </summary>
[PublicAPI]
public static class DictionaryExtensionMethods
{
    /// <summary>
    ///    Gets the value associated with the specified key or adds the value if it does not exist.
    /// </summary>
    /// <param name="dictionary">The <see cref="IDictionary{TKey,TValue}"/> to get or add the value to.</param>
    /// <param name="key">The key of the value to get or add.</param>
    /// <param name="value">The value to add if the key does not exist.</param>
    /// <typeparam name="TKey">The type of the keys in the <see cref="IDictionary{TKey,TValue}"/>.</typeparam>
    /// <typeparam name="TValue">The type of the values in the <see cref="IDictionary{TKey,TValue}"/>. This must be a reference type.</typeparam>
    /// <returns>The value associated with the specified key if the key is found; otherwise, the value that was added.</returns>
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        if (dictionary.TryGetValue(key, out var result))
            return result;

        dictionary.Add(key, value);
        return value;
    }
    
    /// <summary>
    ///    Gets the value associated with the specified key or adds the value if it does not exist.
    /// </summary>
    /// <param name="dictionary">The <see cref="IDictionary{TKey,TValue}"/> to get or add the value to.</param>
    /// <param name="key">The key of the value to get or add.</param>
    /// <param name="value">Factory method that creates the value to add if the key does not exist.</param>
    /// <typeparam name="TKey">The type of the keys in the <see cref="IDictionary{TKey,TValue}"/>.</typeparam>
    /// <typeparam name="TValue">The type of the values in the <see cref="IDictionary{TKey,TValue}"/>. This must be a reference type.</typeparam>
    /// <returns>The value associated with the specified key if the key is found; otherwise, the value that was added.</returns>
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> value)
    {
        if (dictionary.TryGetValue(key, out var result))
            return result;

        var valueToAdd = value();
        dictionary.Add(key, valueToAdd);
        return valueToAdd;
    }
}