using System.ComponentModel;
using System.Globalization;

namespace X39.Util.Console;

[PublicAPI]
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
    public static T? ForValue<T>(
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

    /// <summary>
    /// Prompts the console user to choose a value from a list of items in <see cref="source"/>.
    /// </summary>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> that can be cancelled to abort the loop.
    /// Will <b>NOT</b> cancel the blocking operation of reading from the console!
    /// </param>
    /// <param name="tToString">Function to transform <typeparamref name="T"/> to string.</param>
    /// <param name="invalidSelectionText">
    /// The text to display when the selection is out of range or not a number.
    /// </param>
    /// <param name="source"></param>
    /// <typeparam name="T">The type of the <paramref name="source"/>.</typeparam>
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    public static T ForValueFromCollection<T>(
        IEnumerable<T> source,
        Func<T, ConsoleString>? tToString = default,
        ConsoleString invalidSelectionText = default,
        CancellationToken cancellationToken = default)
    {
        var sourceArray = source as T[] ?? source.ToArray();
        if (sourceArray.Length is 0)
            throw new ArgumentException("Empty collection passed.", nameof(source));
        tToString ??= (t) => t?.ToString() ?? string.Empty;
#pragma warning disable CA1305
        var maxIndexCharacters = sourceArray.Length.ToString().Length;
#pragma warning restore CA1305
        for (var i = 0; i < sourceArray.Length; i++)
        {
            var display = tToString(sourceArray[i]);
#pragma warning disable CA1305
            display.Prepend(string.Format($"{{0,{maxIndexCharacters}}}: ", i)).WriteLine();
#pragma warning restore CA1305
        }

        System.Console.Write('>');
        int index;
        do
        {
            index = ForValue<int>(">", writeAskTextLine: false, cancellationToken: cancellationToken);
            if (index >= 0 && index < sourceArray.Length)
                break;
            if (!invalidSelectionText.Text.IsNullOrWhiteSpace())
                invalidSelectionText.WriteLine();
            cancellationToken.ThrowIfCancellationRequested();
        } while (true);

        return sourceArray[index];
    }

    /// <summary>
    /// Prompts the console user to choose a value from a list of enum values available in <typeparamref name="T"/>.
    /// </summary>
    /// <param name="cancellationToken">
    ///     A <see cref="CancellationToken"/> that can be cancelled to abort the loop.
    ///     Will <b>NOT</b> cancel the blocking operation of reading from the console!
    /// </param>
    /// <param name="tToString">
    ///     Function to transform <typeparamref name="T"/> to string.
    ///     Defaults to <see cref="Enum.GetName"/>.
    /// </param>
    /// <param name="invalidSelectionText">
    ///     The text to display when the selection is out of range or not a number.
    /// </param>
    /// <typeparam name="T">The type of the enum.</typeparam>
    /// <returns>
    ///     The value returned by <see cref="TypeConverter"/> when given the input string
    ///     after the input string not being empty and the input string being validly convertible,
    ///     confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    public static T ForEnumValue<T>(
        Func<T, ConsoleString>? tToString = default,
        ConsoleString invalidSelectionText = default,
        CancellationToken cancellationToken = default)
        where T : Enum
    {
        var enumValues = Enum.GetValues(typeof(T));
        return ForValueFromCollection(enumValues.Cast<T>(), tToString, invalidSelectionText, cancellationToken);
    }
}