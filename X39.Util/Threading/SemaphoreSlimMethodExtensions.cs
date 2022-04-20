namespace X39.Util.Threading;

/// <summary>
/// Contains utility classes for <see cref="SemaphoreSlim"/>
/// </summary>
[PublicAPI]
public static class SemaphoreSlimMethodExtensions
{
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    public static void Locked(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Action action)
    {
        semaphoreSlim.Wait();
        try
        {
            action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }

    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <param name="cancellationToken">Allows to cancel the wait for lock.</param>
    public static void Locked(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Action action,
        CancellationToken cancellationToken)
    {
        semaphoreSlim.Wait(cancellationToken);
        try
        {
            action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <typeparam name="T">The data type returned.</typeparam>
    public static T Locked<T>(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<T> action)
    {
        semaphoreSlim.Wait();
        try
        {
            return action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <typeparam name="T">The data type returned.</typeparam>
    /// <param name="cancellationToken">Allows to cancel the wait for lock.</param>
    public static T Locked<T>(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<T> action,
        CancellationToken cancellationToken)
    {
        semaphoreSlim.Wait(cancellationToken);
        try
        {
            return action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    public static async Task LockedAsync(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Action action)
    {
        await semaphoreSlim.WaitAsync();
        try
        {
            action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <param name="cancellationToken">Allows to cancel the wait for lock.</param>
    public static async Task LockedAsync(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Action action,
        CancellationToken cancellationToken)
    {
        await semaphoreSlim.WaitAsync(cancellationToken);
        try
        {
            action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    public static async Task LockedAsync(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<Task> action)
    {
        await semaphoreSlim.WaitAsync();
        try
        {
            await action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <param name="cancellationToken">Allows to cancel the wait for lock.</param>
    public static async Task LockedAsync(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<Task> action,
        CancellationToken cancellationToken)
    {
        await semaphoreSlim.WaitAsync(cancellationToken);
        try
        {
            await action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <typeparam name="T">The data type returned.</typeparam>
    public static async Task<T> LockedAsync<T>(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<T> action)
    {
        await semaphoreSlim.WaitAsync();
        try
        {
            return action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <typeparam name="T">The data type returned.</typeparam>
    /// <param name="cancellationToken">Allows to cancel the wait for lock.</param>
    public static async Task<T> LockedAsync<T>(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<T> action,
        CancellationToken cancellationToken)
    {
        await semaphoreSlim.WaitAsync(cancellationToken);
        try
        {
            return action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <typeparam name="T">The data type returned.</typeparam>
    public static async Task<T> LockedAsync<T>(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<Task<T>> action)
    {
        await semaphoreSlim.WaitAsync();
        try
        {
            return await action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }
    /// <summary>
    /// Calls <see cref="SemaphoreSlim.WaitAsync()"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="SemaphoreSlim.Release()"/> is being done.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The <see cref="SemaphoreSlim"/> object has been disposed.</exception>
    /// <param name="semaphoreSlim">The valid <see cref="SemaphoreSlim"/> instance.</param>
    /// <param name="action">The action to perform locked.</param>
    /// <typeparam name="T">The data type returned.</typeparam>
    /// <param name="cancellationToken">Allows to cancel the wait for lock.</param>
    public static async Task<T> LockedAsync<T>(
        this SemaphoreSlim semaphoreSlim,
        [InstantHandle] Func<Task<T>> action,
        CancellationToken cancellationToken)
    {
        await semaphoreSlim.WaitAsync(cancellationToken);
        try
        {
            return await action();
        }
        finally
        {
            semaphoreSlim.Release();
        }
    }

}