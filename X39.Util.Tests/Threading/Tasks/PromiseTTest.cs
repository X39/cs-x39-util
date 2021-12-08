using System.Threading.Tasks;
using NUnit.Framework;
using X39.Util.Threading.Tasks;

namespace X39.Util.Tests.Threading.Tasks;

public class PromiseTTests
{
    [Test]
    public async Task AwaitPromiseTWithValue()
    {
        var promise = new Promise<int>();
        var completed = false;
        await TestHelpers.AvoidDeadlockHelperAsync(
            () =>
            {
                completed = true;
                promise.Complete(0);
            },
            async () => await promise);
        Assert.True(completed);
    }

    [Test]
    public async Task GetResultPromiseTWithValue()
    {
        var promise = new Promise<int>();
        var completed = false;
        await TestHelpers.AvoidDeadlockHelperAsync(
            () =>
            {
                completed = true;
                promise.Complete(0);
            },
            () => promise.GetAwaiter().GetResult());
        Assert.True(completed);
    }

    [Test]
    public async Task AwaitPromiseTWithValueThrowing()
    {
        var promise = new Promise<int>();
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
    public async Task GetResultTPromiseWithValueThrowing()
    {
        var promise = new Promise<int>();
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