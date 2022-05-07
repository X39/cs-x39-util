namespace X39.Util.Threading;

/// <summary>
/// Contains utility classes for <see cref="ReaderWriterLockSlim"/>
/// </summary>
[PublicAPI]
public static class ReaderWriterLockSlimMethodExtensions
{
    /// <summary>
    /// Calls <see cref="ReaderWriterLockSlim.EnterReadLock"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="ReaderWriterLockSlim.ExitReadLock"/> is being done.
    /// </summary>
    /// <exception cref="LockRecursionException">
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/>
    /// property is <see cref="LockRecursionPolicy.NoRecursion"/>,
    /// and the current thread has attempted to acquire the
    /// read lock when it already holds the read lock.
    /// -or-
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is
    /// <see cref="LockRecursionPolicy.NoRecursion"/>,
    /// and the current thread has attempted to acquire the
    /// read lock when it already holds the write lock.
    /// -or-
    /// The recursion number would exceed the capacity of the counter.
    /// This limit is so large that applications should never encounter this exception.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The <see cref="ReaderWriterLockSlim"/> object has been disposed.</exception>
    /// <param name="readerWriterLockSlim">The valid <see cref="ReaderWriterLockSlim"/> instance.</param>
    /// <param name="action">The action to perform read-locked.</param>
    public static void ReadLocked(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Action action)
    {
        readerWriterLockSlim.EnterReadLock();
        try
        {
            action();
        }
        finally
        {
            readerWriterLockSlim.ExitReadLock();
        }
    }

    /// <summary>
    /// Calls <see cref="ReaderWriterLockSlim.EnterWriteLock"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="ReaderWriterLockSlim.ExitWriteLock"/> is being done.
    /// </summary>
    /// <exception cref="LockRecursionException">
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is
    /// <see cref="LockRecursionPolicy.NoRecursion"/> and the current
    /// thread has already entered the lock in any mode.
    /// -or-
    /// The current thread has entered read mode and doesn't already own a write lock,
    /// so trying to enter the lock in write mode would create the possibility of a deadlock.
    /// -or-
    /// The recursion number would exceed the capacity of the counter.
    /// The limit is so large that applications should never encounter it.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The <see cref="ReaderWriterLockSlim"/> object has been disposed.</exception>
    /// <param name="readerWriterLockSlim">The valid <see cref="ReaderWriterLockSlim"/> instance.</param>
    /// <param name="action">The action to perform read-locked.</param>
    public static void WriteLocked(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Action action)
    {
        readerWriterLockSlim.EnterWriteLock();
        try
        {
            action();
        }
        finally
        {
            readerWriterLockSlim.ExitWriteLock();
        }
    }

    /// <summary>
    /// Calls <see cref="ReaderWriterLockSlim.EnterUpgradeableReadLock"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="ReaderWriterLockSlim.ExitUpgradeableReadLock"/> is being done.
    /// </summary>
    /// <remarks>
    /// Allows for the passed action to call <see cref="WriteLocked"/>
    /// or <see cref="ReaderWriterLockSlim.EnterWriteLock"/>
    /// or <see cref="ReaderWriterLockSlim.ExitWriteLock"/>.
    /// </remarks>
    /// <exception cref="LockRecursionException">
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
    /// and the current thread has already entered the lock in any mode.
    /// -or-
    /// The current thread has entered read mode,
    /// so trying to enter upgradeable mode would create the possibility of a deadlock.
    /// -or-
    /// The recursion number would exceed the capacity of the counter.
    /// The limit is so large that applications should never encounter it.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The <see cref="ReaderWriterLockSlim"/> object has been disposed.</exception>
    /// <param name="readerWriterLockSlim">The valid <see cref="ReaderWriterLockSlim"/> instance.</param>
    /// <param name="action">The action to perform read-locked.</param>
    public static void UpgradeableReadLocked(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Action action)
    {
        readerWriterLockSlim.EnterUpgradeableReadLock();
        try
        {
            action();
        }
        finally
        {
            readerWriterLockSlim.ExitUpgradeableReadLock();
        }
    }

    /// <summary>
    /// Calls <see cref="ReaderWriterLockSlim.EnterReadLock"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="ReaderWriterLockSlim.ExitReadLock"/> is being done.
    /// </summary>
    /// <exception cref="LockRecursionException">
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/>
    /// property is <see cref="LockRecursionPolicy.NoRecursion"/>,
    /// and the current thread has attempted to acquire the
    /// read lock when it already holds the read lock.
    /// -or-
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is
    /// <see cref="LockRecursionPolicy.NoRecursion"/>,
    /// and the current thread has attempted to acquire the
    /// read lock when it already holds the write lock.
    /// -or-
    /// The recursion number would exceed the capacity of the counter.
    /// This limit is so large that applications should never encounter this exception.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The <see cref="ReaderWriterLockSlim"/> object has been disposed.</exception>
    /// <param name="readerWriterLockSlim">The valid <see cref="ReaderWriterLockSlim"/> instance.</param>
    /// <param name="action">The action to perform read-locked.</param>
    /// <returns>The value, returned by <paramref name="action"/>.</returns>
    public static T ReadLocked<T>(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Func<T> action)
    {
        readerWriterLockSlim.EnterReadLock();
        try
        {
            return action();
        }
        finally
        {
            readerWriterLockSlim.ExitReadLock();
        }
    }

    [Obsolete("ReaderWriterLockSlim may not be used with async.", true)]
    public static Task<T> ReadLocked<T>(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Func<Task<T>> action)
        => throw new InvalidOperationException("ReaderWriterLockSlim may not be used with async.");

    /// <summary>
    /// Calls <see cref="ReaderWriterLockSlim.EnterWriteLock"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="ReaderWriterLockSlim.ExitWriteLock"/> is being done.
    /// </summary>
    /// <exception cref="LockRecursionException">
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is
    /// <see cref="LockRecursionPolicy.NoRecursion"/> and the current
    /// thread has already entered the lock in any mode.
    /// -or-
    /// The current thread has entered read mode and doesn't already own a write lock,
    /// so trying to enter the lock in write mode would create the possibility of a deadlock.
    /// -or-
    /// The recursion number would exceed the capacity of the counter.
    /// The limit is so large that applications should never encounter it.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The <see cref="ReaderWriterLockSlim"/> object has been disposed.</exception>
    /// <param name="readerWriterLockSlim">The valid <see cref="ReaderWriterLockSlim"/> instance.</param>
    /// <param name="action">The action to perform read-locked.</param>
    /// <returns>The value, returned by <paramref name="action"/>.</returns>
    public static T WriteLocked<T>(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Func<T> action)
    {
        readerWriterLockSlim.EnterWriteLock();
        try
        {
            return action();
        }
        finally
        {
            readerWriterLockSlim.ExitWriteLock();
        }
    }

    [Obsolete("ReaderWriterLockSlim may not be used with async.", true)]
    public static Task<T> WriteLocked<T>(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Func<Task<T>> action)
        => throw new InvalidOperationException("ReaderWriterLockSlim may not be used with async.");

    /// <summary>
    /// Calls <see cref="ReaderWriterLockSlim.EnterUpgradeableReadLock"/> to enter the read-lock
    /// and then wraps <paramref name="action"/> in a try-finally to ensure, exiting
    /// the read-lock using <see cref="ReaderWriterLockSlim.ExitUpgradeableReadLock"/> is being done.
    /// </summary>
    /// <remarks>
    /// Allows for the passed action to call <see cref="WriteLocked"/>
    /// or <see cref="ReaderWriterLockSlim.EnterWriteLock"/>
    /// or <see cref="ReaderWriterLockSlim.ExitWriteLock"/>.
    /// </remarks>
    /// <exception cref="LockRecursionException">
    /// The <see cref="ReaderWriterLockSlim.RecursionPolicy"/> property is <see cref="LockRecursionPolicy.NoRecursion"/>
    /// and the current thread has already entered the lock in any mode.
    /// -or-
    /// The current thread has entered read mode,
    /// so trying to enter upgradeable mode would create the possibility of a deadlock.
    /// -or-
    /// The recursion number would exceed the capacity of the counter.
    /// The limit is so large that applications should never encounter it.
    /// </exception>
    /// <exception cref="ObjectDisposedException">The <see cref="ReaderWriterLockSlim"/> object has been disposed.</exception>
    /// <param name="readerWriterLockSlim">The valid <see cref="ReaderWriterLockSlim"/> instance.</param>
    /// <param name="action">The action to perform read-locked.</param>
    /// <returns>The value, returned by <paramref name="action"/>.</returns>
    public static T UpgradeableReadLocked<T>(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Func<T> action)
    {
        readerWriterLockSlim.EnterUpgradeableReadLock();
        try
        {
            return action();
        }
        finally
        {
            readerWriterLockSlim.ExitUpgradeableReadLock();
        }
    }

    [Obsolete("ReaderWriterLockSlim may not be used with async.", true)]
    public static Task<T> UpgradeableReadLocked<T>(
        this ReaderWriterLockSlim readerWriterLockSlim,
        [InstantHandle] Func<Task<T>> action)
        => throw new InvalidOperationException("ReaderWriterLockSlim may not be used with async.");
}