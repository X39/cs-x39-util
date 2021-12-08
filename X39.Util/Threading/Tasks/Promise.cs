namespace X39.Util.Threading.Tasks;

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

    public void Complete()
    {
        if (State != EPromiseState.Primed)
            throw new InvalidOperationException("Already completed.");
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