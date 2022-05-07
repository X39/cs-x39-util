using System.Runtime.CompilerServices;

namespace X39.Util.Threading.Tasks;

public readonly struct PromiseAwaiter<T> : INotifyCompletion
{
    private readonly Promise<T> _promise;
    public bool IsCompleted => _promise.State != EPromiseState.Primed;

    public T GetResult()
    {
        var tmp = _promise;
        if (tmp.State == EPromiseState.Primed)
            SpinWait.SpinUntil(() => tmp.State != EPromiseState.Primed);
        switch (tmp.State)
        {
            case EPromiseState.Completed:
                return tmp.Result!;
            case EPromiseState.Failed:
                throw new AggregateException(
                    tmp.Exception
                    ?? throw new Exception("Failure set without exception"));
            case EPromiseState.Primed:
            default:
                throw new InvalidOperationException();
        }
    }

    internal PromiseAwaiter(Promise<T> promise) => _promise = promise;
    public void OnCompleted(Action completion) => _promise.Callbacks.Add(completion);
}