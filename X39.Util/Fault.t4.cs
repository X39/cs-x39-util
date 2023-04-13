// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable RedundantNameQualifier
using System.ComponentModel;

namespace X39.Util;

public static partial class Fault
{
#region Synchrounous


    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1) where TException1 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2) where TException1 : Exception where TException2 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3) where TException1 : Exception where TException2 : Exception where TException3 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12, Func<TException13, TResult> exceptionHandler13) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
        catch (TException13 ex)
        {
            return exceptionHandler13(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12, Func<TException13, TResult> exceptionHandler13, Func<TException14, TResult> exceptionHandler14) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
        catch (TException13 ex)
        {
            return exceptionHandler13(ex);
        }
        catch (TException14 ex)
        {
            return exceptionHandler14(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12, Func<TException13, TResult> exceptionHandler13, Func<TException14, TResult> exceptionHandler14, Func<TException15, TResult> exceptionHandler15) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
        catch (TException13 ex)
        {
            return exceptionHandler13(ex);
        }
        catch (TException14 ex)
        {
            return exceptionHandler14(ex);
        }
        catch (TException15 ex)
        {
            return exceptionHandler15(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12, Func<TException13, TResult> exceptionHandler13, Func<TException14, TResult> exceptionHandler14, Func<TException15, TResult> exceptionHandler15, Func<TException16, TResult> exceptionHandler16) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
        catch (TException13 ex)
        {
            return exceptionHandler13(ex);
        }
        catch (TException14 ex)
        {
            return exceptionHandler14(ex);
        }
        catch (TException15 ex)
        {
            return exceptionHandler15(ex);
        }
        catch (TException16 ex)
        {
            return exceptionHandler16(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// <item>Handles any <typeparamref name="TException17"/> that might occur with the provided <paramref name="exceptionHandler17"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <typeparam name="TException17">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler17"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12, Func<TException13, TResult> exceptionHandler13, Func<TException14, TResult> exceptionHandler14, Func<TException15, TResult> exceptionHandler15, Func<TException16, TResult> exceptionHandler16, Func<TException17, TResult> exceptionHandler17) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
        catch (TException13 ex)
        {
            return exceptionHandler13(ex);
        }
        catch (TException14 ex)
        {
            return exceptionHandler14(ex);
        }
        catch (TException15 ex)
        {
            return exceptionHandler15(ex);
        }
        catch (TException16 ex)
        {
            return exceptionHandler16(ex);
        }
        catch (TException17 ex)
        {
            return exceptionHandler17(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// <item>Handles any <typeparamref name="TException17"/> that might occur with the provided <paramref name="exceptionHandler17"/></item>
    /// <item>Handles any <typeparamref name="TException18"/> that might occur with the provided <paramref name="exceptionHandler18"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <typeparam name="TException17">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler17"/>.</typeparam>
    /// <typeparam name="TException18">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler18"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12, Func<TException13, TResult> exceptionHandler13, Func<TException14, TResult> exceptionHandler14, Func<TException15, TResult> exceptionHandler15, Func<TException16, TResult> exceptionHandler16, Func<TException17, TResult> exceptionHandler17, Func<TException18, TResult> exceptionHandler18) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
        catch (TException13 ex)
        {
            return exceptionHandler13(ex);
        }
        catch (TException14 ex)
        {
            return exceptionHandler14(ex);
        }
        catch (TException15 ex)
        {
            return exceptionHandler15(ex);
        }
        catch (TException16 ex)
        {
            return exceptionHandler16(ex);
        }
        catch (TException17 ex)
        {
            return exceptionHandler17(ex);
        }
        catch (TException18 ex)
        {
            return exceptionHandler18(ex);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// <item>Handles any <typeparamref name="TException17"/> that might occur with the provided <paramref name="exceptionHandler17"/></item>
    /// <item>Handles any <typeparamref name="TException18"/> that might occur with the provided <paramref name="exceptionHandler18"/></item>
    /// <item>Handles any <typeparamref name="TException19"/> that might occur with the provided <paramref name="exceptionHandler19"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <typeparam name="TException17">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler17"/>.</typeparam>
    /// <typeparam name="TException18">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler18"/>.</typeparam>
    /// <typeparam name="TException19">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler19"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
    public static TResult Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18, TException19>(Func<TResult> func, Func<TException1, TResult> exceptionHandler1, Func<TException2, TResult> exceptionHandler2, Func<TException3, TResult> exceptionHandler3, Func<TException4, TResult> exceptionHandler4, Func<TException5, TResult> exceptionHandler5, Func<TException6, TResult> exceptionHandler6, Func<TException7, TResult> exceptionHandler7, Func<TException8, TResult> exceptionHandler8, Func<TException9, TResult> exceptionHandler9, Func<TException10, TResult> exceptionHandler10, Func<TException11, TResult> exceptionHandler11, Func<TException12, TResult> exceptionHandler12, Func<TException13, TResult> exceptionHandler13, Func<TException14, TResult> exceptionHandler14, Func<TException15, TResult> exceptionHandler15, Func<TException16, TResult> exceptionHandler16, Func<TException17, TResult> exceptionHandler17, Func<TException18, TResult> exceptionHandler18, Func<TException19, TResult> exceptionHandler19) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception where TException19 : Exception
    {
        try
        {
            return func();
        }
        catch (TException1 ex)
        {
            return exceptionHandler1(ex);
        }
        catch (TException2 ex)
        {
            return exceptionHandler2(ex);
        }
        catch (TException3 ex)
        {
            return exceptionHandler3(ex);
        }
        catch (TException4 ex)
        {
            return exceptionHandler4(ex);
        }
        catch (TException5 ex)
        {
            return exceptionHandler5(ex);
        }
        catch (TException6 ex)
        {
            return exceptionHandler6(ex);
        }
        catch (TException7 ex)
        {
            return exceptionHandler7(ex);
        }
        catch (TException8 ex)
        {
            return exceptionHandler8(ex);
        }
        catch (TException9 ex)
        {
            return exceptionHandler9(ex);
        }
        catch (TException10 ex)
        {
            return exceptionHandler10(ex);
        }
        catch (TException11 ex)
        {
            return exceptionHandler11(ex);
        }
        catch (TException12 ex)
        {
            return exceptionHandler12(ex);
        }
        catch (TException13 ex)
        {
            return exceptionHandler13(ex);
        }
        catch (TException14 ex)
        {
            return exceptionHandler14(ex);
        }
        catch (TException15 ex)
        {
            return exceptionHandler15(ex);
        }
        catch (TException16 ex)
        {
            return exceptionHandler16(ex);
        }
        catch (TException17 ex)
        {
            return exceptionHandler17(ex);
        }
        catch (TException18 ex)
        {
            return exceptionHandler18(ex);
        }
        catch (TException19 ex)
        {
            return exceptionHandler19(ex);
        }
    }
#endregion

#region Asynchronous


    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1) where TException1 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1) where TException1 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2) where TException1 : Exception where TException2 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2) where TException1 : Exception where TException2 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3) where TException1 : Exception where TException2 : Exception where TException3 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3) where TException1 : Exception where TException2 : Exception where TException3 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12, Func<TException13, ValueTask<TResult>> exceptionHandler13) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
        catch (TException13 ex)
        {
            return await exceptionHandler13(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12, Func<TException13, ValueTask<TResult>> exceptionHandler13, Func<TException14, ValueTask<TResult>> exceptionHandler14) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
        catch (TException13 ex)
        {
            return await exceptionHandler13(ex)
                .ConfigureAwait(false);
        }
        catch (TException14 ex)
        {
            return await exceptionHandler14(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12, Func<TException13, ValueTask<TResult>> exceptionHandler13, Func<TException14, ValueTask<TResult>> exceptionHandler14, Func<TException15, ValueTask<TResult>> exceptionHandler15) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
        catch (TException13 ex)
        {
            return await exceptionHandler13(ex)
                .ConfigureAwait(false);
        }
        catch (TException14 ex)
        {
            return await exceptionHandler14(ex)
                .ConfigureAwait(false);
        }
        catch (TException15 ex)
        {
            return await exceptionHandler15(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12, Func<TException13, ValueTask<TResult>> exceptionHandler13, Func<TException14, ValueTask<TResult>> exceptionHandler14, Func<TException15, ValueTask<TResult>> exceptionHandler15, Func<TException16, ValueTask<TResult>> exceptionHandler16) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
        catch (TException13 ex)
        {
            return await exceptionHandler13(ex)
                .ConfigureAwait(false);
        }
        catch (TException14 ex)
        {
            return await exceptionHandler14(ex)
                .ConfigureAwait(false);
        }
        catch (TException15 ex)
        {
            return await exceptionHandler15(ex)
                .ConfigureAwait(false);
        }
        catch (TException16 ex)
        {
            return await exceptionHandler16(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// <item>Handles any <typeparamref name="TException17"/> that might occur with the provided <paramref name="exceptionHandler17"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <typeparam name="TException17">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler17"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12, Func<TException13, ValueTask<TResult>> exceptionHandler13, Func<TException14, ValueTask<TResult>> exceptionHandler14, Func<TException15, ValueTask<TResult>> exceptionHandler15, Func<TException16, ValueTask<TResult>> exceptionHandler16, Func<TException17, ValueTask<TResult>> exceptionHandler17) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16, Func<TException17, Task<TResult>> exceptionHandler17) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
        catch (TException13 ex)
        {
            return await exceptionHandler13(ex)
                .ConfigureAwait(false);
        }
        catch (TException14 ex)
        {
            return await exceptionHandler14(ex)
                .ConfigureAwait(false);
        }
        catch (TException15 ex)
        {
            return await exceptionHandler15(ex)
                .ConfigureAwait(false);
        }
        catch (TException16 ex)
        {
            return await exceptionHandler16(ex)
                .ConfigureAwait(false);
        }
        catch (TException17 ex)
        {
            return await exceptionHandler17(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// <item>Handles any <typeparamref name="TException17"/> that might occur with the provided <paramref name="exceptionHandler17"/></item>
    /// <item>Handles any <typeparamref name="TException18"/> that might occur with the provided <paramref name="exceptionHandler18"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <typeparam name="TException17">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler17"/>.</typeparam>
    /// <typeparam name="TException18">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler18"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12, Func<TException13, ValueTask<TResult>> exceptionHandler13, Func<TException14, ValueTask<TResult>> exceptionHandler14, Func<TException15, ValueTask<TResult>> exceptionHandler15, Func<TException16, ValueTask<TResult>> exceptionHandler16, Func<TException17, ValueTask<TResult>> exceptionHandler17, Func<TException18, ValueTask<TResult>> exceptionHandler18) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16, Func<TException17, Task<TResult>> exceptionHandler17, Func<TException18, Task<TResult>> exceptionHandler18) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
        catch (TException13 ex)
        {
            return await exceptionHandler13(ex)
                .ConfigureAwait(false);
        }
        catch (TException14 ex)
        {
            return await exceptionHandler14(ex)
                .ConfigureAwait(false);
        }
        catch (TException15 ex)
        {
            return await exceptionHandler15(ex)
                .ConfigureAwait(false);
        }
        catch (TException16 ex)
        {
            return await exceptionHandler16(ex)
                .ConfigureAwait(false);
        }
        catch (TException17 ex)
        {
            return await exceptionHandler17(ex)
                .ConfigureAwait(false);
        }
        catch (TException18 ex)
        {
            return await exceptionHandler18(ex)
                .ConfigureAwait(false);
        }
    }
    /// <summary>
    /// Executes the provided <paramref name="func"/> and:
    /// <list type="bullet">
    /// <item>Handles any <typeparamref name="TException1"/> that might occur with the provided <paramref name="exceptionHandler1"/></item>
    /// <item>Handles any <typeparamref name="TException2"/> that might occur with the provided <paramref name="exceptionHandler2"/></item>
    /// <item>Handles any <typeparamref name="TException3"/> that might occur with the provided <paramref name="exceptionHandler3"/></item>
    /// <item>Handles any <typeparamref name="TException4"/> that might occur with the provided <paramref name="exceptionHandler4"/></item>
    /// <item>Handles any <typeparamref name="TException5"/> that might occur with the provided <paramref name="exceptionHandler5"/></item>
    /// <item>Handles any <typeparamref name="TException6"/> that might occur with the provided <paramref name="exceptionHandler6"/></item>
    /// <item>Handles any <typeparamref name="TException7"/> that might occur with the provided <paramref name="exceptionHandler7"/></item>
    /// <item>Handles any <typeparamref name="TException8"/> that might occur with the provided <paramref name="exceptionHandler8"/></item>
    /// <item>Handles any <typeparamref name="TException9"/> that might occur with the provided <paramref name="exceptionHandler9"/></item>
    /// <item>Handles any <typeparamref name="TException10"/> that might occur with the provided <paramref name="exceptionHandler10"/></item>
    /// <item>Handles any <typeparamref name="TException11"/> that might occur with the provided <paramref name="exceptionHandler11"/></item>
    /// <item>Handles any <typeparamref name="TException12"/> that might occur with the provided <paramref name="exceptionHandler12"/></item>
    /// <item>Handles any <typeparamref name="TException13"/> that might occur with the provided <paramref name="exceptionHandler13"/></item>
    /// <item>Handles any <typeparamref name="TException14"/> that might occur with the provided <paramref name="exceptionHandler14"/></item>
    /// <item>Handles any <typeparamref name="TException15"/> that might occur with the provided <paramref name="exceptionHandler15"/></item>
    /// <item>Handles any <typeparamref name="TException16"/> that might occur with the provided <paramref name="exceptionHandler16"/></item>
    /// <item>Handles any <typeparamref name="TException17"/> that might occur with the provided <paramref name="exceptionHandler17"/></item>
    /// <item>Handles any <typeparamref name="TException18"/> that might occur with the provided <paramref name="exceptionHandler18"/></item>
    /// <item>Handles any <typeparamref name="TException19"/> that might occur with the provided <paramref name="exceptionHandler19"/></item>
    /// </list>
    /// </summary>
    /// <param name="func">The function to execute.</param>
    /// <param name="exceptionHandler1">The exception handler for <typeparamref name="TException1"/>. If raised, the value returned by this handler will be returned by the method as a whole.</param>
    /// <typeparam name="TResult">The return type of the provided <paramref name="func"/> and the exception handlers.</typeparam>
    /// <typeparam name="TException1">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler1"/>.</typeparam>
    /// <typeparam name="TException2">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler2"/>.</typeparam>
    /// <typeparam name="TException3">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler3"/>.</typeparam>
    /// <typeparam name="TException4">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler4"/>.</typeparam>
    /// <typeparam name="TException5">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler5"/>.</typeparam>
    /// <typeparam name="TException6">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler6"/>.</typeparam>
    /// <typeparam name="TException7">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler7"/>.</typeparam>
    /// <typeparam name="TException8">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler8"/>.</typeparam>
    /// <typeparam name="TException9">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler9"/>.</typeparam>
    /// <typeparam name="TException10">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler10"/>.</typeparam>
    /// <typeparam name="TException11">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler11"/>.</typeparam>
    /// <typeparam name="TException12">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler12"/>.</typeparam>
    /// <typeparam name="TException13">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler13"/>.</typeparam>
    /// <typeparam name="TException14">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler14"/>.</typeparam>
    /// <typeparam name="TException15">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler15"/>.</typeparam>
    /// <typeparam name="TException16">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler16"/>.</typeparam>
    /// <typeparam name="TException17">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler17"/>.</typeparam>
    /// <typeparam name="TException18">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler18"/>.</typeparam>
    /// <typeparam name="TException19">The type of the exception that might be raised by the provided <paramref name="func"/> and that will be handled by the provided <paramref name="exceptionHandler19"/>.</typeparam>
    /// <returns>The value returned by the provided <paramref name="func"/> or the value returned by the provided exception handlers if the exception was handled by one.</returns>
#if NETSTANDARD2_1_OR_GREATER
    public static async ValueTask<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18, TException19>(Func<ValueTask<TResult>> func, Func<TException1, ValueTask<TResult>> exceptionHandler1, Func<TException2, ValueTask<TResult>> exceptionHandler2, Func<TException3, ValueTask<TResult>> exceptionHandler3, Func<TException4, ValueTask<TResult>> exceptionHandler4, Func<TException5, ValueTask<TResult>> exceptionHandler5, Func<TException6, ValueTask<TResult>> exceptionHandler6, Func<TException7, ValueTask<TResult>> exceptionHandler7, Func<TException8, ValueTask<TResult>> exceptionHandler8, Func<TException9, ValueTask<TResult>> exceptionHandler9, Func<TException10, ValueTask<TResult>> exceptionHandler10, Func<TException11, ValueTask<TResult>> exceptionHandler11, Func<TException12, ValueTask<TResult>> exceptionHandler12, Func<TException13, ValueTask<TResult>> exceptionHandler13, Func<TException14, ValueTask<TResult>> exceptionHandler14, Func<TException15, ValueTask<TResult>> exceptionHandler15, Func<TException16, ValueTask<TResult>> exceptionHandler16, Func<TException17, ValueTask<TResult>> exceptionHandler17, Func<TException18, ValueTask<TResult>> exceptionHandler18, Func<TException19, ValueTask<TResult>> exceptionHandler19) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception where TException19 : Exception
#else
    public static async Task<TResult> HandleAsync<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18, TException19>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16, Func<TException17, Task<TResult>> exceptionHandler17, Func<TException18, Task<TResult>> exceptionHandler18, Func<TException19, Task<TResult>> exceptionHandler19) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception where TException19 : Exception
#endif
    {
        try
        {
            return await func()
                .ConfigureAwait(false);
        }
        catch (TException1 ex)
        {
            return await exceptionHandler1(ex)
                .ConfigureAwait(false);
        }
        catch (TException2 ex)
        {
            return await exceptionHandler2(ex)
                .ConfigureAwait(false);
        }
        catch (TException3 ex)
        {
            return await exceptionHandler3(ex)
                .ConfigureAwait(false);
        }
        catch (TException4 ex)
        {
            return await exceptionHandler4(ex)
                .ConfigureAwait(false);
        }
        catch (TException5 ex)
        {
            return await exceptionHandler5(ex)
                .ConfigureAwait(false);
        }
        catch (TException6 ex)
        {
            return await exceptionHandler6(ex)
                .ConfigureAwait(false);
        }
        catch (TException7 ex)
        {
            return await exceptionHandler7(ex)
                .ConfigureAwait(false);
        }
        catch (TException8 ex)
        {
            return await exceptionHandler8(ex)
                .ConfigureAwait(false);
        }
        catch (TException9 ex)
        {
            return await exceptionHandler9(ex)
                .ConfigureAwait(false);
        }
        catch (TException10 ex)
        {
            return await exceptionHandler10(ex)
                .ConfigureAwait(false);
        }
        catch (TException11 ex)
        {
            return await exceptionHandler11(ex)
                .ConfigureAwait(false);
        }
        catch (TException12 ex)
        {
            return await exceptionHandler12(ex)
                .ConfigureAwait(false);
        }
        catch (TException13 ex)
        {
            return await exceptionHandler13(ex)
                .ConfigureAwait(false);
        }
        catch (TException14 ex)
        {
            return await exceptionHandler14(ex)
                .ConfigureAwait(false);
        }
        catch (TException15 ex)
        {
            return await exceptionHandler15(ex)
                .ConfigureAwait(false);
        }
        catch (TException16 ex)
        {
            return await exceptionHandler16(ex)
                .ConfigureAwait(false);
        }
        catch (TException17 ex)
        {
            return await exceptionHandler17(ex)
                .ConfigureAwait(false);
        }
        catch (TException18 ex)
        {
            return await exceptionHandler18(ex)
                .ConfigureAwait(false);
        }
        catch (TException19 ex)
        {
            return await exceptionHandler19(ex)
                .ConfigureAwait(false);
        }
    }
#endregion

#region Async Guards


    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1) where TException1 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2) where TException1 : Exception where TException2 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3) where TException1 : Exception where TException2 : Exception where TException3 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16, Func<TException17, Task<TResult>> exceptionHandler17) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16, Func<TException17, Task<TResult>> exceptionHandler17, Func<TException18, Task<TResult>> exceptionHandler18) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use HandleAsync instead.", true)]
    public static Task<TResult> Handle<TResult, TException1, TException2, TException3, TException4, TException5, TException6, TException7, TException8, TException9, TException10, TException11, TException12, TException13, TException14, TException15, TException16, TException17, TException18, TException19>(Func<Task<TResult>> func, Func<TException1, Task<TResult>> exceptionHandler1, Func<TException2, Task<TResult>> exceptionHandler2, Func<TException3, Task<TResult>> exceptionHandler3, Func<TException4, Task<TResult>> exceptionHandler4, Func<TException5, Task<TResult>> exceptionHandler5, Func<TException6, Task<TResult>> exceptionHandler6, Func<TException7, Task<TResult>> exceptionHandler7, Func<TException8, Task<TResult>> exceptionHandler8, Func<TException9, Task<TResult>> exceptionHandler9, Func<TException10, Task<TResult>> exceptionHandler10, Func<TException11, Task<TResult>> exceptionHandler11, Func<TException12, Task<TResult>> exceptionHandler12, Func<TException13, Task<TResult>> exceptionHandler13, Func<TException14, Task<TResult>> exceptionHandler14, Func<TException15, Task<TResult>> exceptionHandler15, Func<TException16, Task<TResult>> exceptionHandler16, Func<TException17, Task<TResult>> exceptionHandler17, Func<TException18, Task<TResult>> exceptionHandler18, Func<TException19, Task<TResult>> exceptionHandler19) where TException1 : Exception where TException2 : Exception where TException3 : Exception where TException4 : Exception where TException5 : Exception where TException6 : Exception where TException7 : Exception where TException8 : Exception where TException9 : Exception where TException10 : Exception where TException11 : Exception where TException12 : Exception where TException13 : Exception where TException14 : Exception where TException15 : Exception where TException16 : Exception where TException17 : Exception where TException18 : Exception where TException19 : Exception
    {
        throw new NotSupportedException("Use HandleAsync instead.");
    }
#endregion
}