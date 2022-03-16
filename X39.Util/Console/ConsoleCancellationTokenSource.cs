using JetBrains.Annotations;

namespace X39.Util.Console
{
    [PublicAPI]
    public sealed class ConsoleCancellationTokenSource :
        IDisposable
#if NET5_0_OR_GREATER
        , IAsyncDisposable
#endif
    {
        [PublicAPI]
        public enum EOnCancelResult
        {
            ProceedWithCancellation,
            AbortCancellationAttempt,
        }

        public Threading.Tasks.Promise CancellationPromise { get; } = new();

        private readonly CancellationTokenSource _cancellationTokenSource;
        private readonly ConsoleSpecialKey _consoleSpecialKey;
        private readonly Func<EOnCancelResult> _onCancel;

        public bool IsCancellationRequested => _cancellationTokenSource.IsCancellationRequested;
        public CancellationToken Token => _cancellationTokenSource.Token;

        public void Dispose()
        {
            System.Console.CancelKeyPress -= ConsoleOnCancelKeyPress;
            _cancellationTokenSource.Dispose();
            if (!CancellationPromise.IsComplete)
            {
                CancellationPromise.Complete();
            }
        }

        #if NET5_0_OR_GREATER
        public ValueTask DisposeAsync()
        {
            System.Console.CancelKeyPress -= ConsoleOnCancelKeyPress;
            _cancellationTokenSource.Dispose();
            if (!CancellationPromise.IsComplete)
            {
                CancellationPromise.Complete();
            }
            return default;
        }
        #endif

        /// <summary>
        /// Creates a new <see cref="CancellationToken"/> source that is
        /// cancellable using <code>CTRL + C</code> in a console window.
        /// </summary>
        public ConsoleCancellationTokenSource() : this(ConsoleSpecialKey.ControlC)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CancellationToken"/> source that is
        /// cancellable using <paramref name="consoleSpecialKey"/> in a console window.
        /// </summary>
        /// <param name="consoleSpecialKey">The key to use.</param>
        public ConsoleCancellationTokenSource(ConsoleSpecialKey consoleSpecialKey) : this(consoleSpecialKey, () => { })
        {
        }

        /// <summary>
        /// Creates a new <see cref="CancellationToken"/> source that is
        /// cancellable using <code>CTRL + C</code> in a console window.
        /// </summary>
        /// <param name="onCancel">
        /// A method that gets executed prior to cancelling the <see cref="Token"/>.
        /// </param>
        public ConsoleCancellationTokenSource(Action onCancel) : this(
            ConsoleSpecialKey.ControlC, () =>
            {
                onCancel();
                return EOnCancelResult.ProceedWithCancellation;
            })
        {
        }

        /// <summary>
        /// Creates a new <see cref="CancellationToken"/> source that is
        /// cancellable using <code>CTRL + C</code> in a console window.
        /// </summary>
        /// <param name="onCancel">
        /// A method that gets executed prior to cancelling the <see cref="Token"/>
        /// that may refuse the cancellation attempt by returning <see cref="EOnCancelResult.AbortCancellationAttempt"/>.
        /// </param>
        public ConsoleCancellationTokenSource(Func<EOnCancelResult> onCancel) : this(ConsoleSpecialKey.ControlC,
            onCancel)
        {
        }

        /// <summary>
        /// Creates a new <see cref="CancellationToken"/> source that is
        /// cancellable using <paramref name="consoleSpecialKey"/> in a console window.
        /// </summary>
        /// <param name="consoleSpecialKey">The key to use.</param>
        /// <param name="onCancel">
        /// A method that gets executed prior to cancelling the <see cref="Token"/>.
        /// </param>
        public ConsoleCancellationTokenSource(ConsoleSpecialKey consoleSpecialKey, Action onCancel) : this(
            consoleSpecialKey, () =>
            {
                onCancel();
                return EOnCancelResult.ProceedWithCancellation;
            })
        {
        }


        /// <summary>
        /// Creates a new <see cref="CancellationToken"/> source that is
        /// cancellable using <paramref name="consoleSpecialKey"/> in a console window.
        /// </summary>
        /// <param name="consoleSpecialKey">The key to use.</param>
        /// <param name="onCancel">
        /// A method that gets executed prior to cancelling the <see cref="Token"/>
        /// that may refuse the cancellation attempt by returning <see cref="EOnCancelResult.AbortCancellationAttempt"/>.
        /// </param>
        public ConsoleCancellationTokenSource(ConsoleSpecialKey consoleSpecialKey, Func<EOnCancelResult> onCancel)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            System.Console.CancelKeyPress += ConsoleOnCancelKeyPress;
            _consoleSpecialKey = consoleSpecialKey;
            _onCancel = onCancel;
        }

        public void Cancel() => _cancellationTokenSource.Cancel();

        public void CancelAfter(TimeSpan delay) => _cancellationTokenSource.CancelAfter(delay);
#if NET6_0_OR_GREATER
        public bool TryReset() => _cancellationTokenSource.TryReset();
#endif
        private void ConsoleOnCancelKeyPress(object? sender, ConsoleCancelEventArgs args)
        {
            if (args.SpecialKey != _consoleSpecialKey
                || _onCancel() != EOnCancelResult.ProceedWithCancellation)
                return;
            _cancellationTokenSource.Cancel();
            CancellationPromise.Complete();
        }
    }
}