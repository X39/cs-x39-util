namespace X39.Util.Collections;

public static class ListExtensionMethods
{
    /// <summary>
    /// Iterates over all entries and randomizes them using the provided <paramref name="random"/>
    /// instance or a new one if null is passed.
    /// </summary>
    /// <param name="list">The list to randomize.</param>
    /// <param name="random">An instance of <see cref="Random"/> or null to use a newly created one.</param>
    /// <typeparam name="T"></typeparam>
    public static void Randomize<T>(this IList<T> list, Random? random = null)
    {
        random ??= new Random();
        for (var i = 0; i < list.Count; i++)
        {
            var tmp = list[i];
            var r = random.Next(i, list.Count);
            list[i] = list[r];
            list[r] = tmp;
        }
    }
    
}