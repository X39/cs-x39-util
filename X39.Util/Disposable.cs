namespace X39.Util;

/// <summary>
/// A simple class, implementing the <see cref="IDisposable"/> interface.
/// </summary>
public sealed class Disposable : IDisposable
{
    private readonly Action _onDispose;

    /// <summary>
    /// Creates a new, empty instance of the <see cref="Disposable"/> class.
    /// </summary>
    public static Disposable Empty => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Disposable"/> class.
    /// </summary>
    public Disposable()
    {
        _onDispose = () => { };
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Disposable"/> class.
    /// Once <see cref="Dispose"/> is called, the <paramref name="onDispose"/>
    /// method will be called.
    /// </summary>
    /// <param name="onDispose">The action to do on <see cref="Dispose"/>.</param>
    public Disposable(Action onDispose)
    {
        _onDispose = onDispose;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Disposable"/> class.
    /// The constructor will immediately call <paramref name="onEnter"/>.
    /// Once <see cref="Dispose"/> is called, the <paramref name="onDispose"/>
    /// method will be called.
    /// </summary>
    /// <param name="onEnter">An action to execute immediately.</param>
    /// <param name="onDispose">The action to do on <see cref="Dispose"/></param>
    public Disposable([InstantHandle] Action onEnter, Action onDispose)
    {
        onEnter();
        _onDispose = onDispose;
    }

    /// <summary>
    /// Calls the dispose action passed when constructing this <see cref="Disposable"/>.
    /// </summary>
    public void Dispose()
    {
        _onDispose();
    }
}