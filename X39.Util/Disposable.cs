namespace X39.Util;

public sealed class Disposable : IDisposable
{
    private readonly Action _onDispose;
    public Disposable() : this(() => { }) { }
    public Disposable(Action onDispose) { _onDispose = onDispose; }
    public Disposable([InstantHandle]Action onEnter, Action onDispose) : this(onDispose) { onEnter(); }
    public void Dispose()
    {
        _onDispose();
    }
}