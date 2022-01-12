﻿using System;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using X39.Util.Threading.Tasks;

namespace X39.Util.Tests;

public static class TestHelpers
{
    public static Exception GetPrimedException()
    {
        try
        {
            throw new Exception("Primed Exception");
        }
        catch (Exception ex)
        {
            return ex;
        }
    }

    public static async Task<Exception?> AvoidDeadlockHelperAsync(
        Action complete,
        Func<Task> test)
    {
        _ = Task.Run(async () =>
        {
            await Task.Delay(500);
            complete();
        });
        Exception? ex = null;
        var thread = new Thread(() =>
        {
            try
            {
                Task.Run(async () => { await test(); }).GetAwaiter().GetResult();
            }
            catch (ThreadInterruptedException)
            {
                /* ignored */
            }
            catch (Exception e)
            {
                ex = e;
            }
        });
        thread.Start();
        await Task.WhenAny(Task.Delay(1000), Task.Run(() => thread.Join()));
        if (thread.IsAlive)
        {
            thread.Interrupt();
            thread.Join();
            Assert.Fail();
        }
        else
        {
            Assert.Pass();
        }

        return ex;
    }

    public static async Task<Exception?> AvoidDeadlockHelperAsync(
        Action complete,
        Action test)
    {
        _ = Task.Run(async () =>
        {
            await Task.Delay(500);
            complete();
        });
        Exception? ex = null;
        var thread = new Thread(() =>
        {
            try
            {
                test();
            }
            catch (ThreadInterruptedException)
            {
                /* ignored */
            }
            catch (Exception e)
            {
                ex = e;
            }
        });
        thread.Start();
        await Task.WhenAny(Task.Delay(1000), Task.Run(() => thread.Join()));
        if (thread.IsAlive)
        {
            thread.Interrupt();
            thread.Join();
            Assert.Fail();
        }
        else
        {
            Assert.Pass();
        }

        return ex;
    }
}