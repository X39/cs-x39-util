using System.Threading.Tasks;
using NUnit.Framework;
using X39.Util.Threading.Tasks;

namespace X39.Util.Tests.Threading.Tasks;

public class PromiseTests
{
    [Test]
    public async Task AwaitPromiseWithValue()
    {
        var promise = new Promise();
        var completed = false;
        await TestHelpers.AvoidDeadlockHelperAsync(
            () =>
            {
                completed = true;
                promise.Complete();
            },
            async () => await promise);
        Assert.True(completed);
    }

    [Test]
    public async Task GetResultPromiseWithValue()
    {
        var promise = new Promise();
        var completed = false;
        await TestHelpers.AvoidDeadlockHelperAsync(
            () =>
            {
                completed = true;
                promise.Complete();
            },
            () => promise.GetAwaiter().GetResult());
        Assert.True(completed);
    }

    [Test]
    public async Task AwaitPromiseWithValueThrowing()
    {
        var promise = new Promise();
        var completed = false;
        var ex = await TestHelpers.AvoidDeadlockHelperAsync(
            () =>
            {
                completed = true;
                promise.Complete(TestHelpers.GetPrimedException());
            },
            async () => await promise);
        Assert.True(completed);
        Assert.NotNull(ex);
    }

    [Test]
    public async Task GetResultPromiseWithValueThrowing()
    {
        var promise = new Promise();
        var completed = false;
        var ex = await TestHelpers.AvoidDeadlockHelperAsync(
            () =>
            {
                completed = true;
                promise.Complete(TestHelpers.GetPrimedException());
            },
            () => promise.GetAwaiter().GetResult());
        Assert.True(completed);
        Assert.NotNull(ex);
    }
}