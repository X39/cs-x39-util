namespace X39.Util.Threading.Tasks;

[PublicAPI]
public class Promise
{
    internal Exception? Exception;
    internal EPromiseState State;
    internal readonly List<Action> Callbacks = new();
    public PromiseAwaiter GetAwaiter() => new(this);

    private void Continue()
    {
        var exceptions = new List<Exception>();
        foreach (var callback in Callbacks)
        {
            try
            {
                callback();
            }
            catch (Exception e)
            {
                exceptions.Add(e);
            }
        }

        if (exceptions.Any())
        {
            throw new AggregateException(exceptions);
        }
    }

    private async Task ContinueAsync()
    {
        var exceptions = new List<Exception>();
        var tasks = Callbacks.Select(callback => Task.Run(() =>
        {
            try
            {
                callback();
            }
            catch (Exception e)
            {
                lock (exceptions) exceptions.Add(e);
            }
        })).ToArray();

        await Task.WhenAll(tasks);
        if (exceptions.Any())
        {
            throw new AggregateException(exceptions);
        }
    }

    public bool IsComplete => State != EPromiseState.Primed;

    public Task CompleteAsync()
    {
        if (IsComplete)
            throw new InvalidOperationException("Already completed.");
        State = EPromiseState.Completed;
        return ContinueAsync();
    }

    public void Complete()
    {
        if (IsComplete)
            throw new InvalidOperationException("Already completed.");
        State = EPromiseState.Completed;
        Continue();
    }

    public AggregateException? Complete(Exception exception)
    {
        if (IsComplete)
            throw new InvalidOperationException("Already completed.");
        Exception = exception;
        State = EPromiseState.Failed;
        try
        {
            Continue();
        }
        catch (AggregateException ex)
        {
            return ex;
        }

        return null;
    }

    public async Task<AggregateException?> CompleteAsync(Exception exception)
    {
        if (IsComplete)
            throw new InvalidOperationException("Already completed.");
        Exception = exception;
        State = EPromiseState.Failed;
        try
        {
            await ContinueAsync();
        }
        catch (AggregateException ex)
        {
            return ex;
        }

        return null;
    }

    public async Task<AggregateException?> CompleteAsync(Exception exception)
    {
        if (IsComplete)
            throw new InvalidOperationException("Already completed.");
        Exception = exception;
        State = EPromiseState.Failed;
        try
        {
            await ContinueAsync();
        }
        catch (AggregateException ex)
        {
            return ex;
        }

        return null;
    }
}