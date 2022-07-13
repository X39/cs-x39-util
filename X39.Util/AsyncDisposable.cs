namespace X39.Util;
#if NET5_0_OR_GREATER
/// <summary>
/// A simple class, implementing the <see cref="IAsyncDisposable"/> interface.
/// </summary>
public sealed class AsyncDisposable : IAsyncDisposable
{
    private readonly Func<ValueTask> _onDispose;

    /// <summary>
    /// Creates a new, empty instance of the <see cref="AsyncDisposable"/> class.
    /// </summary>
    public static AsyncDisposable Empty => new();

    /// <summary>
    /// Creates a new, empty instance of the <see cref="AsyncDisposable"/> class.
    /// </summary>
    public AsyncDisposable()
    {
        _onDispose = () => ValueTask.CompletedTask;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="AsyncDisposable"/> class.
    /// Once <see cref="DisposeAsync"/> is called, the <paramref name="onDispose"/>
    /// method will be called.
    /// </summary>
    /// <param name="onDispose">The action to do on <see cref="DisposeAsync"/>.</param>
    public AsyncDisposable(Func<ValueTask> onDispose)
    {
        _onDispose = onDispose;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="AsyncDisposable"/> class.
    /// The constructor will immediately call <paramref name="onEnter"/>.
    /// Once <see cref="DisposeAsync"/> is called, the <paramref name="onDispose"/>
    /// method will be called.
    /// </summary>
    /// <param name="onEnter">An action to execute immediately.</param>
    /// <param name="onDispose">The <see langword="async"/> action to do on <see cref="DisposeAsync"/></param>
    public AsyncDisposable([InstantHandle] Action onEnter, Func<ValueTask> onDispose)
    {
        onEnter();
        _onDispose = onDispose;
    }


    /// <summary>
    /// Calls the dispose action passed when constructing this <see cref="Disposable"/> and
    /// returns the <see cref="ValueTask"/> produced.
    /// </summary>
    public ValueTask DisposeAsync()
    {
        return _onDispose();
    }
}
#endif