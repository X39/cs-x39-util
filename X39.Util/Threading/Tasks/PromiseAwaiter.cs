﻿using System.Runtime.CompilerServices;

namespace X39.Util.Threading.Tasks;

[PublicAPI]
public readonly struct PromiseAwaiter : INotifyCompletion
{
    private readonly Promise _promise;
    public bool IsCompleted => _promise.State != EPromiseState.Primed;

    public void GetResult()
    {
        var tmp = _promise;
        if (tmp.State == EPromiseState.Primed)
            SpinWait.SpinUntil(() => tmp.State != EPromiseState.Primed);
        switch (tmp.State)
        {
            case EPromiseState.Completed:
                return;
            case EPromiseState.Failed:
                throw new AggregateException(
                    tmp.Exception
                    ?? throw new Exception("Failure set without exception"));
            case EPromiseState.Primed:
            default: throw new InvalidOperationException();
        }
    }

    internal PromiseAwaiter(Promise promise) => _promise = promise;
    public void OnCompleted(Action completion) => _promise.Callbacks.Add(completion);
}

