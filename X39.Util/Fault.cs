using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace X39.Util;

/// <summary>
/// Utility class to collect common functionality regarding fault (try-catch-finally) handling
/// </summary>
[PublicAPI]
public static partial class Fault
{
    /// <summary>
    /// Enum to allow an exception handling methods return value
    /// to be marked with a proper "throw or not to throw" indication
    /// instead of eg. convention "throw if true, no throw if false".
    /// </summary>
    public enum Happened
    {
        /// <summary>
        /// Indicates that an exception should be thrown.
        /// </summary>
        Throw,

        /// <summary>
        /// Indicates that an exception should not be thrown.
        /// </summary>
        NoThrow,
    }

    /// <summary>
    /// Usability constant to allow semantically nicer access of <see cref="Happened.Throw"/>.
    /// </summary>
    public const Happened Throw = Happened.Throw;

    /// <summary>
    /// Usability constant to allow semantically nicer access of <see cref="Happened.NoThrow"/>.
    /// </summary>
    public const Happened NoThrow = Happened.NoThrow;

    /// <summary>
    /// Calls <paramref name="action"/> and ignores any potential exception that may be raised.
    /// </summary>
    /// <param name="action">The action to perform</param>
    /// <returns>
    /// <see langword="true"/> if any <see cref="Exception"/> was raised and
    /// <see langword="false"/> only if <paramref name="action"/> ran without any <see cref="Exception"/>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Ignore([InstantHandle] Action action)
    {
        try
        {
            action();
            return false;
        }
        catch
        {
            // ignore
            return true;
        }
    }

    /// <summary>
    /// Calls <paramref name="action"/> returning the evaluated value.
    /// In the case of an exception, the exception is ignored and <paramref name="defaultValue"/>
    /// is returned.
    /// </summary>
    /// <param name="action">The action to perform</param>
    /// <param name="defaultValue">The value to return in case of an exception</param>
    /// <returns>Either the result of <paramref name="action"/> or <paramref name="defaultValue"/></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Ignore<T>([InstantHandle] Func<T> action, T defaultValue)
    {
        try
        {
            return action();
        }
        catch
        {
            // ignore
            return defaultValue;
        }
    }

    /// <summary>
    /// Calls <paramref name="action"/> returning the evaluated value.
    /// In the case of an exception, the exception is ignored and the result of <paramref name="defaultValueFactory"/>
    /// is returned.
    /// </summary>
    /// <remarks>
    /// <paramref name="defaultValueFactory"/> is not protected by a try-catch guard!
    /// </remarks>
    /// <param name="action">The action to perform</param>
    /// <param name="defaultValueFactory">The function that will generate the value to return in case of an exception</param>
    /// <returns>Either the result of <paramref name="action"/> or <paramref name="defaultValueFactory"/></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Ignore<T>([InstantHandle] Func<T> action, [InstantHandle] Func<T> defaultValueFactory)
    {
        try
        {
            return action();
        }
        catch
        {
            // ignore
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// Guard method to prevent accidental (and intentional) use of async in sync context.
    /// </summary>
    /// <remarks>
    /// This mostly is for IDE support and will always throw an exception and be marked as "obsolete".
    /// </remarks>
    /// <exception cref="InvalidOperationException">Always thrown when used.</exception>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use IgnoreAsync instead.", true)]
    public static Task Ignore(
        [InstantHandle] Func<Task> action)
        => throw new InvalidOperationException("Use IgnoreAsync instead.");

    /// <summary>
    /// Guard method to prevent accidental (and intentional) use of async in sync context.
    /// </summary>
    /// <remarks>
    /// This mostly is for IDE support and will always throw an exception and be marked as "obsolete".
    /// </remarks>
    /// <exception cref="InvalidOperationException">Always thrown when used.</exception>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use IgnoreAsync instead.", true)]
    public static Task<T> Ignore<T>(
        [InstantHandle] Func<Task<T>> action,
        [InstantHandle] T defaultValueFactory)
        => throw new InvalidOperationException("Use IgnoreAsync instead.");

    /// <summary>
    /// Guard method to prevent accidental (and intentional) use of async in sync context.
    /// </summary>
    /// <remarks>
    /// This mostly is for IDE support and will always throw an exception and be marked as "obsolete".
    /// </remarks>
    /// <exception cref="InvalidOperationException">Always thrown when used.</exception>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use IgnoreAsync instead.", true)]
    public static Task<T> Ignore<T>(
        [InstantHandle] Func<Task<T>> action,
        [InstantHandle] Func<T> defaultValueFactory)
        => throw new InvalidOperationException("Use IgnoreAsync instead.");

    /// <summary>
    /// Guard method to prevent accidental (and intentional) use of async in sync context.
    /// </summary>
    /// <remarks>
    /// This mostly is for IDE support and will always throw an exception and be marked as "obsolete".
    /// </remarks>
    /// <exception cref="InvalidOperationException">Always thrown when used.</exception>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use IgnoreAsync instead.", true)]
    public static Task<T> Ignore<T>(
        [InstantHandle] Func<Task<T>> action,
        [InstantHandle] Func<Task<T>> defaultValueFactory)
        => throw new InvalidOperationException("Use IgnoreAsync instead.");

    /// <summary>
    /// Calls <paramref name="action"/> and ignores any potential <see cref="Exception"/> that may be raised.
    /// </summary>
    /// <param name="action">The action to perform</param>
    /// <returns>
    /// <see langword="true"/> if any <see cref="Exception"/> was raised and
    /// <see langword="false"/> only if <paramref name="action"/> ran without any <see cref="Exception"/>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<bool> IgnoreAsync(
        [InstantHandle(RequireAwait = true)] Func<Task> action)
    {
        try
        {
            await action();
            return false;
        }
        catch
        {
            // ignore
            return true;
        }
    }

    /// <summary>
    /// Calls <paramref name="action"/> returning the evaluated value.
    /// In the case of an exception, the exception is ignored and <paramref name="defaultValue"/>
    /// is returned.
    /// </summary>
    /// <param name="action">The action to perform</param>
    /// <param name="defaultValue">The value to return in case of an exception</param>
    /// <returns>Either the result of <paramref name="action"/> or <paramref name="defaultValue"/></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<T> IgnoreAsync<T>(
        [InstantHandle(RequireAwait = true)] Func<Task<T>> action,
        T defaultValue)
    {
        try
        {
            return await action();
        }
        catch
        {
            // ignore
            return defaultValue;
        }
    }

    /// <summary>
    /// Calls <paramref name="action"/> returning the evaluated value.
    /// In the case of an exception, the exception is ignored and the result of <paramref name="defaultValueFactory"/>
    /// is returned.
    /// </summary>
    /// <remarks>
    /// <paramref name="defaultValueFactory"/> is not protected by a try-catch guard!
    /// </remarks>
    /// <param name="action">The action to perform</param>
    /// <param name="defaultValueFactory">The function that will generate the value to return in case of an exception</param>
    /// <returns>Either the result of <paramref name="action"/> or <paramref name="defaultValueFactory"/></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<T> IgnoreAsync<T>(
        [InstantHandle(RequireAwait = true)] Func<Task<T>> action,
        [InstantHandle(RequireAwait = true)] Func<Task<T>> defaultValueFactory)
    {
        try
        {
            return await action();
        }
        catch
        {
            // ignore
            return await defaultValueFactory();
        }
    }

    /// <summary>
    /// Calls <paramref name="action"/> returning the evaluated value.
    /// In the case of an exception, the exception is ignored and the result of <paramref name="defaultValueFactory"/>
    /// is returned.
    /// </summary>
    /// <remarks>
    /// <paramref name="defaultValueFactory"/> is not protected by a try-catch guard!
    /// </remarks>
    /// <param name="action">The action to perform</param>
    /// <param name="defaultValueFactory">The function that will generate the value to return in case of an exception</param>
    /// <returns>Either the result of <paramref name="action"/> or <paramref name="defaultValueFactory"/></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static async Task<T> IgnoreAsync<T>(
        [InstantHandle(RequireAwait = true)] Func<Task<T>> action,
        [InstantHandle(RequireAwait = true)] Func<T> defaultValueFactory)
    {
        try
        {
            return await action();
        }
        catch
        {
            // ignore
            return defaultValueFactory();
        }
    }
}