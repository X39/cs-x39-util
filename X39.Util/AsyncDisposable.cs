namespace X39.Util;

#if NET5_0_OR_GREATER
public sealed class AsyncDisposable : IAsyncDisposable
{
    private readonly Func<ValueTask> _onDispose;
    public AsyncDisposable() : this(() => ValueTask.CompletedTask) { }
    public AsyncDisposable(Func<ValueTask> onDispose) { _onDispose = onDispose; }
    public ValueTask DisposeAsync()
    {
        return _onDispose();
    }
}
#endif