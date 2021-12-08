namespace X39.Util.Console;

[PublicAPI]
public readonly record struct ConsoleString
{
    public ConsoleColor Foreground { get; init; } = System.Console.ForegroundColor;
    public ConsoleColor Background { get; init; } = System.Console.BackgroundColor;
    public string Text { get; init; } = string.Empty;

    public void Deconstruct(out ConsoleColor foreground, out ConsoleColor background, out string text)
    {
        foreground = Foreground;
        background = Background;
        text = Text;
    }

    public static implicit operator ConsoleString(string text) => new() { Text = text };

    public void Write()
    {
        System.Console.ForegroundColor = Foreground;
        System.Console.BackgroundColor = Background;
        System.Console.Write(Text);
        System.Console.ResetColor();
    }
    public void WriteLine()
    {
        System.Console.ForegroundColor = Foreground;
        System.Console.BackgroundColor = Background;
        System.Console.WriteLine(Text);
        System.Console.ResetColor();
    }
}