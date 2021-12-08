using System.ComponentModel;

namespace X39.Util.Console;

public static partial class AskConsole
{
    /// <summary>
    /// Prompts the console user to enter a value of the type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="askText">
    /// The text to display when asking.
    /// </param>
    /// <param name="writeAskTextLine">
    /// Whether to output <paramref name="askText"/> using <see cref="ConsoleString.WriteLine"/> (true)
    /// or <see cref="ConsoleString.Write"/> (false).
    /// </param>
    /// <param name="invalidFormatText">
    /// The text to display when <see cref="TypeConverter.IsValid(object?)"/> returns false.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> that can be cancelled to abort the loop.
    /// Will <b>NOT</b> cancel the blocking operation of reading from the console!
    /// </param>
    /// <typeparam name="T">
    /// The type to prompt for.
    /// Type must have a valid <see cref="TypeConverter"/> available that is receivable
    /// using <see cref="TypeDescriptor.GetConverter(Type)"/>.
    /// </typeparam>
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static T? ForValueOfType<T>(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
    {
        var converter = TypeDescriptor.GetConverter(typeof(T))
            ?? throw new NotSupportedException("No type converter found.");
        do
        {
            if (writeAskTextLine)
                askText.WriteLine();
            else
                askText.Write();
            var input = System.Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                continue;
            if (converter.IsValid(input))
                return (T?) converter.ConvertFrom(input);
            if (!invalidFormatText.Text.IsNullOrWhiteSpace())
                invalidFormatText.WriteLine();
        } while (!cancellationToken.IsCancellationRequested);

        return default;
    }
}