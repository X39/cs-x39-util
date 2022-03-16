namespace X39.Util.Console;

[PublicAPI]

#if NET5_0_OR_GREATER
public readonly record struct ConsoleString
{
    public ConsoleColor Foreground { get; init; } = System.Console.ForegroundColor;
    public ConsoleColor Background { get; init; } = System.Console.BackgroundColor;
    public string Text { get; init; } = string.Empty;
#else
public struct ConsoleString
{
    public ConsoleColor Foreground { get; set; } = System.Console.ForegroundColor;
    public ConsoleColor Background { get; set; } = System.Console.BackgroundColor;
    public string Text { get; set; } = string.Empty;
#endif

    public ConsoleString(string text)
    {
        Text = text;
    }

    /// <summary>
    /// Method to deconstruct the ConsoleString.
    /// </summary>
    /// <example>
    /// <code>
    /// var (foreground, background, text) = consoleString;
    /// </code>
    /// </example>
    /// <example>
    /// <code>
    /// consoleString.Deconstruct(out var foreground, out var background, out var text);
    /// </code>
    /// </example>
    /// <param name="foreground">Will contain contents of <see cref="Foreground"/></param>
    /// <param name="background">Will contain contents of <see cref="Background"/></param>
    /// <param name="text">Will contain contents of <see cref="Text"/></param>
    public void Deconstruct(out ConsoleColor foreground, out ConsoleColor background, out string text)
    {
        foreground = Foreground;
        background = Background;
        text = Text;
    }

    /// <summary>
    /// Implicitly converts the given <see cref="string"/> to a <see cref="ConsoleString"/>.
    /// </summary>
    /// <param name="text">The <see cref="string"/> to use.</param>
    /// <returns>A valid <see cref="ConsoleString"/> structure.</returns>
    public static implicit operator ConsoleString(string text) => new() {Text = text};

    /// <summary>
    /// Implicitly converts the given <see cref="ConsoleString"/> back to a <see cref="string"/>.
    /// </summary>
    /// <param name="consoleString">The <see cref="ConsoleString"/> to use.</param>
    /// <returns>A valid <see cref="string"/>.</returns>
    public static implicit operator string(ConsoleString consoleString) => consoleString.Text;

    /// <summary>
    /// Writes the <see cref="Text"/> string value to the standard output stream.
    /// </summary>
    /// <exception cref="IOException">An I/O error occurred.</exception>
    public void Write()
    {
        System.Console.ForegroundColor = Foreground;
        System.Console.BackgroundColor = Background;
        System.Console.Write(Text);
        System.Console.ResetColor();
    }

    /// <summary>
    /// Writes the <see cref="Text"/> string value, followed by the current line terminator, to the standard output
    /// </summary>
    /// <exception cref="IOException">An I/O error occurred.</exception>
    public void WriteLine()
    {
        System.Console.ForegroundColor = Foreground;
        System.Console.BackgroundColor = Background;
        System.Console.WriteLine(Text);
        System.Console.ResetColor();
    }

    /// <summary>
    /// Emits the '\b' character enough times to clear the line from this <see cref="ConsoleString"/>.
    /// </summary>
    /// <remarks>
    /// Could also be thought of as undoing the effects of <see cref="Write"/> in a normal command line interface.
    /// </remarks>
    /// <exception cref="InvalidOperationException"><see cref="Text"/> contains a line terminator ('\n').</exception>
    /// <exception cref="IOException">An I/O error occurred.</exception>
    public void WriteBackspaces()
    {
        if (Text.Contains('\n'))
            throw new InvalidOperationException("Cannot clear console strings containing line terminator.");
        System.Console.Write(string.Concat('\r', new string(' ', Text.Length), '\r'));
    }

    /// <summary>
    /// Creates and returns a new <see cref="ConsoleString"/> that has the given
    /// <paramref name="text"/> prepended to its very own <see cref="Text"/>.
    /// </summary>
    /// <param name="text">The text to prepend.</param>
    /// <returns>A new <see cref="ConsoleString"/> that has the given
    /// <paramref name="text"/> prepended to its very own <see cref="Text"/>.</returns>
    public ConsoleString Prepend(string text)
    {
        return this with {Text = string.Concat(text, Text)};
    }

    /// <summary>
    /// Creates and returns a new <see cref="ConsoleString"/> that has the given
    /// <paramref name="text"/> appended to its very own <see cref="Text"/>.
    /// </summary>
    /// <param name="text">The text to append.</param>
    /// <returns>A new <see cref="ConsoleString"/> that has the given
    /// <paramref name="text"/> appended to its very own <see cref="Text"/>.</returns>
    public ConsoleString Append(string text)
    {
        return this with {Text = string.Concat(Text, text)};
    }
}