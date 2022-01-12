namespace X39.Util.Threading;

/// <summary>
/// Contains utility classes for ReaderWriterLockSlim
/// </summary>
public static class ReaderWriterLockSlimExtensions
{
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