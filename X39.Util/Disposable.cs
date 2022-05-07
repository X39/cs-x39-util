namespace X39.Util;

public sealed class Disposable : IDisposable
{
    private readonly Action _onDispose;

    public Disposable()
    {
        _onDispose = () => { };
    }
    public Disposable(Action onDispose)
    {
        _onDispose = onDispose;
    }
    public Disposable([InstantHandle] Action onEnter, Action onDispose)
    {
        onEnter();
        _onDispose = onDispose;
    }
    public void Dispose()
    {
        _onDispose();
    }
}