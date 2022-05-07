namespace X39.Util;

public static class ObjectExtensionMethods
{
    /// <summary>
    /// Creates a new <see cref="IEnumerable{T}"/>, yielding <paramref name="self"/>.
    /// </summary>
    /// <param name="self">this</param>
    /// <typeparam name="T">type of <paramref name="self"/></typeparam>
    /// <returns>An <see cref="IEnumerable{T}"/> containing <paramref name="self"/></returns>
    public static IEnumerable<T> MakeEnumerable<T>(this T self)
    {
        yield return self;
    }
    
    /// <summary>
    /// Creates a new array and puts <paramref name="self"/> in it.
    /// </summary>
    /// <remarks>
    /// Equivalent to calling
    /// <code>
    /// new []{self}
    /// </code>
    /// </remarks>
    /// <param name="self">this</param>
    /// <typeparam name="T">type of <paramref name="self"/></typeparam>
    /// <returns>An array containing <paramref name="self"/></returns>
    public static T[] MakeArray<T>(this T self)
    {
        return new []{self};
    }
}