namespace X39.Util;

/// <summary>
/// Contains utility classes for <see cref="System.String"/>
/// </summary>
public static class MulticastDelegateMethodExtensions
{
    public static async Task DynamicInvokeAsync(this MulticastDelegate? multiCastDelegate, params object[] args)
    {
        if (multiCastDelegate is null) { return; }
        // Receive the subscribed handlers
        var invocationDelegates = multiCastDelegate?.GetInvocationList() ?? Array.Empty<Delegate>();

        // Spawn the range of tasks for them
        var tasks = invocationDelegates
            .Select((q) => q.DynamicInvoke(args) as Task)
            .Where((q) => q is not null)
            .ToArray();

        // Wait all tasks
        await Task.WhenAll(tasks!);
    }
}