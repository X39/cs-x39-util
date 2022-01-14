// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable RedundantNameQualifier
using System.ComponentModel;

namespace X39.Util.Console;

public static partial class AskConsole
{
    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.Byte"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static Byte? ForByte(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.Byte>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.SByte"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static SByte? ForSByte(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.SByte>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.Int32"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static Int32? ForInt32(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.Int32>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.UInt32"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static UInt32? ForUInt32(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.UInt32>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.Int16"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static Int16? ForInt16(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.Int16>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.UInt16"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static UInt16? ForUInt16(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.UInt16>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.Int64"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static Int64? ForInt64(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.Int64>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.UInt64"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static UInt64? ForUInt64(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.UInt64>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.Single"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static Single? ForSingle(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.Single>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.Double"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static Double? ForDouble(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.Double>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

    /// <summary>
    /// Prompts the console user to enter a value of the type <see name="System.Decimal"/>.
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
    /// <returns>
    /// The value returned by <see cref="TypeConverter"/> when given the input string
    /// after the input string not being empty and the input string being validly convertible,
    /// confirmed using <see cref="TypeConverter.IsValid(object?)"/>.
    /// </returns>
    /// <exception cref="NotSupportedException">Thrown when no <see cref="TypeConverter"/> is found.</exception>
    public static Decimal? ForDecimal(
        ConsoleString askText,
        bool writeAskTextLine = true,
        ConsoleString invalidFormatText = default,
        CancellationToken cancellationToken = default)
        => ForValue<System.Decimal>(
            askText,
            writeAskTextLine,
            invalidFormatText,
            cancellationToken);

}