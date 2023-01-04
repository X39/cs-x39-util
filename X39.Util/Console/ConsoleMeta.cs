namespace X39.Util.Console;

/// <summary>
/// Contains function to allow console-related meta interactions such as
/// getting a string that spans across the width of the whole console window.
/// </summary>
public static class ConsoleMeta
{
    /// <summary>
    /// Returns a horizontal line that covers the console over the whole window-width.
    /// </summary>
    /// <remarks>
    /// Automatic detection requires console window support. Some console windows may not support the required
    /// hooks properly (including some sessions of console windows) at which point <paramref name="abortWidth"/> gets
    /// important as they tend to report absurd numbers.
    /// </remarks>
    /// <param name="c">The character to use for the horizontal line.</param>
    /// <param name="abortWidth">
    ///     The maximum allowed number of characters to accepted characters before a value
    ///     is deemed "unsupported".
    ///     Depending on the font face and size used, this should be ~300 characters for a normal
    ///     16:9 widescreen display.
    /// </param>
    /// <returns></returns>
    public static string HorizontalRuler(char c = '-', int abortWidth = 1000)
        => new(c,
            System.Console.BufferWidth >= abortWidth || System.Console.BufferWidth < 0
                ? 32
                : System.Console.BufferWidth - 1);
}