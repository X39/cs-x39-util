using System.Threading;

namespace X39.Util.Threading;

/// <summary>
/// Contains utility classes for <see cref="ReaderWriterLockSlim"/>
/// </summary>
public static class ReaderWriterLockSlimExtensions
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
    public static void ReadLocked(this ReaderWriterLockSlim readerWriterLockSlim, Action action)
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
    public static void WriteLocked(this ReaderWriterLockSlim readerWriterLockSlim, Action action)
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
    public static void UpgradeableReadLocked(this ReaderWriterLockSlim readerWriterLockSlim, Action action)
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
    public static T ReadLocked<T>(this ReaderWriterLockSlim readerWriterLockSlim, Func<T> action)
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
    public static T WriteLocked<T>(this ReaderWriterLockSlim readerWriterLockSlim, Func<T> action)
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
    public static T UpgradeableReadLocked<T>(this ReaderWriterLockSlim readerWriterLockSlim, Func<T> action)
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
}