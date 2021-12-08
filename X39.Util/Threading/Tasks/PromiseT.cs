namespace X39.Util.Threading.Tasks;

public class Promise<T>
{
    internal Exception? Exception;
    internal T? Result;
    internal EPromiseState State;
    internal readonly List<Action> Callbacks = new();
    public PromiseAwaiter<T> GetAwaiter() => new(this);

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

    public void Complete(T result)
    {
        if (State != EPromiseState.Primed)
            throw new InvalidOperationException("Already completed.");
        Result = result;
        State = EPromiseState.Completed;
        Continue();
    }

    public void Complete(Exception exception)
    {
        if (State != EPromiseState.Primed)
            throw new InvalidOperationException("Already completed.");
        Exception = exception;
        State = EPromiseState.Failed;
        Continue();
    }
}