namespace X39.Util;

public static class ObjectExtensionMethods
{
    /// <summary>
    /// Allows to flatten a nested <typeparamref name="T"/> into an <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <remarks>
    /// This call was specifically created to allow to flatten a parent-child hierarchy into a list of objects from
    /// the child to parent direction.
    /// </remarks>
    /// <param name="self">The start <typeparamref name="T"/>.</param>
    /// <param name="parent">
    ///     Function to select the next <typeparamref name="T"/>, relative to <paramref name="self"/> or
    ///     the object that was navigated prior using this parameter.
    /// </param>
    /// <typeparam name="T">The <see cref="Type"/> to navigate on.</typeparam>
    /// <returns></returns>
    public static IEnumerable<T> FlattenParentHierarchy<T>(this T self, Func<T, T?> parent)
    {
        var t = self;
        do
        {
            yield return t;
            t = parent(t);
        } while (t is not null);
    }

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