
using System.Linq.Expressions;

namespace X39.Util;
public static partial class TypeExtensionMethods
{
    private static void ClearDynCache()
    {
        CreateInstanceDelegate1Cache.Clear();
        CreateInstanceDelegate2Cache.Clear();
        CreateInstanceDelegate3Cache.Clear();
        CreateInstanceDelegate4Cache.Clear();
        CreateInstanceDelegate5Cache.Clear();
        CreateInstanceDelegate6Cache.Clear();
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate7Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate8Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate9Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate10Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate11Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate12Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate13Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate14Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate15Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate16Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate17Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate18Cache.Clear();
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        CreateInstanceDelegate19Cache.Clear();
#endif
    }

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate1Cache = new(); 
    public static object CreateInstance<TArg1>(this Type t, TArg1 arg1)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1)});
        if (CreateInstanceDelegate1Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate1Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate2Cache = new(); 
    public static object CreateInstance<TArg1, TArg2>(this Type t, TArg1 arg1, TArg2 arg2)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2)});
        if (CreateInstanceDelegate2Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate2Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate3Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3)});
        if (CreateInstanceDelegate3Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate3Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate4Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4)});
        if (CreateInstanceDelegate4Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate4Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate5Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5)});
        if (CreateInstanceDelegate5Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate5Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate6Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6)});
        if (CreateInstanceDelegate6Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate6Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate7Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7)});
        if (CreateInstanceDelegate7Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate7Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate8Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8)});
        if (CreateInstanceDelegate8Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate8Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate9Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9)});
        if (CreateInstanceDelegate9Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate9Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate10Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10)});
        if (CreateInstanceDelegate10Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate10Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate11Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11)});
        if (CreateInstanceDelegate11Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate11Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate12Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12)});
        if (CreateInstanceDelegate12Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate12Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate13Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13)});
        if (CreateInstanceDelegate13Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            ex.Data.Add("arg13", arg13);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12)),
            Expression.Parameter(typeof(TArg13))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate13Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate14Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14)});
        if (CreateInstanceDelegate14Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            ex.Data.Add("arg13", arg13);
            ex.Data.Add("arg14", arg14);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12)),
            Expression.Parameter(typeof(TArg13)),
            Expression.Parameter(typeof(TArg14))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate14Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate15Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15)});
        if (CreateInstanceDelegate15Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            ex.Data.Add("arg13", arg13);
            ex.Data.Add("arg14", arg14);
            ex.Data.Add("arg15", arg15);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12)),
            Expression.Parameter(typeof(TArg13)),
            Expression.Parameter(typeof(TArg14)),
            Expression.Parameter(typeof(TArg15))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate15Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate16Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16)});
        if (CreateInstanceDelegate16Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            ex.Data.Add("arg13", arg13);
            ex.Data.Add("arg14", arg14);
            ex.Data.Add("arg15", arg15);
            ex.Data.Add("arg16", arg16);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12)),
            Expression.Parameter(typeof(TArg13)),
            Expression.Parameter(typeof(TArg14)),
            Expression.Parameter(typeof(TArg15)),
            Expression.Parameter(typeof(TArg16))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate16Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15,
            arg16
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate17Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16), typeof(TArg17)});
        if (CreateInstanceDelegate17Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16), typeof(TArg17)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            ex.Data.Add("arg13", arg13);
            ex.Data.Add("arg14", arg14);
            ex.Data.Add("arg15", arg15);
            ex.Data.Add("arg16", arg16);
            ex.Data.Add("arg17", arg17);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12)),
            Expression.Parameter(typeof(TArg13)),
            Expression.Parameter(typeof(TArg14)),
            Expression.Parameter(typeof(TArg15)),
            Expression.Parameter(typeof(TArg16)),
            Expression.Parameter(typeof(TArg17))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate17Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15,
            arg16,
            arg17
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate18Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16), typeof(TArg17), typeof(TArg18)});
        if (CreateInstanceDelegate18Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16), typeof(TArg17), typeof(TArg18)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            ex.Data.Add("arg13", arg13);
            ex.Data.Add("arg14", arg14);
            ex.Data.Add("arg15", arg15);
            ex.Data.Add("arg16", arg16);
            ex.Data.Add("arg17", arg17);
            ex.Data.Add("arg18", arg18);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12)),
            Expression.Parameter(typeof(TArg13)),
            Expression.Parameter(typeof(TArg14)),
            Expression.Parameter(typeof(TArg15)),
            Expression.Parameter(typeof(TArg16)),
            Expression.Parameter(typeof(TArg17)),
            Expression.Parameter(typeof(TArg18))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate18Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15,
            arg16,
            arg17,
            arg18
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

    internal static readonly Dictionary<InstanceCacheKey, Delegate> CreateInstanceDelegate19Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this Type t, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19)
    {
        var key = new InstanceCacheKey(t, new[]{typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16), typeof(TArg17), typeof(TArg18), typeof(TArg19)});
        if (CreateInstanceDelegate19Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19)
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4), typeof(TArg5), typeof(TArg6), typeof(TArg7), typeof(TArg8), typeof(TArg9), typeof(TArg10), typeof(TArg11), typeof(TArg12), typeof(TArg13), typeof(TArg14), typeof(TArg15), typeof(TArg16), typeof(TArg17), typeof(TArg18), typeof(TArg19)});
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add("arg1", arg1);
            ex.Data.Add("arg2", arg2);
            ex.Data.Add("arg3", arg3);
            ex.Data.Add("arg4", arg4);
            ex.Data.Add("arg5", arg5);
            ex.Data.Add("arg6", arg6);
            ex.Data.Add("arg7", arg7);
            ex.Data.Add("arg8", arg8);
            ex.Data.Add("arg9", arg9);
            ex.Data.Add("arg10", arg10);
            ex.Data.Add("arg11", arg11);
            ex.Data.Add("arg12", arg12);
            ex.Data.Add("arg13", arg13);
            ex.Data.Add("arg14", arg14);
            ex.Data.Add("arg15", arg15);
            ex.Data.Add("arg16", arg16);
            ex.Data.Add("arg17", arg17);
            ex.Data.Add("arg18", arg18);
            ex.Data.Add("arg19", arg19);
            throw ex;
        }
        var expParameters = new Expression[] {
            Expression.Parameter(typeof(TArg1)),
            Expression.Parameter(typeof(TArg2)),
            Expression.Parameter(typeof(TArg3)),
            Expression.Parameter(typeof(TArg4)),
            Expression.Parameter(typeof(TArg5)),
            Expression.Parameter(typeof(TArg6)),
            Expression.Parameter(typeof(TArg7)),
            Expression.Parameter(typeof(TArg8)),
            Expression.Parameter(typeof(TArg9)),
            Expression.Parameter(typeof(TArg10)),
            Expression.Parameter(typeof(TArg11)),
            Expression.Parameter(typeof(TArg12)),
            Expression.Parameter(typeof(TArg13)),
            Expression.Parameter(typeof(TArg14)),
            Expression.Parameter(typeof(TArg15)),
            Expression.Parameter(typeof(TArg16)),
            Expression.Parameter(typeof(TArg17)),
            Expression.Parameter(typeof(TArg18)),
            Expression.Parameter(typeof(TArg19))
            };
        var expNew = Expression.New(constructor, expParameters);
        CreateInstanceDelegate19Cache[key] = del = Expression.Lambda(expNew, expParameters.Cast<ParameterExpression>()).Compile();
        var result = del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15,
            arg16,
            arg17,
            arg18,
            arg19
            );
        return result
               ?? throw new NullReferenceException("Constructor yielded null result.");
    }
#endif
}
