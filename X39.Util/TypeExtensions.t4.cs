
using System.Linq.Expressions;

namespace X39.Util;
public static partial class TypeExtensionMethods
{
    private static readonly Dictionary<(
            Type,
            Type
            ), Delegate> CreateInstanceDelegate1Cache = new(); 
    public static object CreateInstance<TArg1>(
        this Type t,
        TArg1 arg1)
    {
        var key = (
            t,
            typeof(TArg1)
            );
        if (CreateInstanceDelegate1Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate2Cache = new(); 
    public static object CreateInstance<TArg1, TArg2>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2)
            );
        if (CreateInstanceDelegate2Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate3Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3)
            );
        if (CreateInstanceDelegate3Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
            ex.Data.Add(typeof(TArg3), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate4Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4)
            );
        if (CreateInstanceDelegate4Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
            ex.Data.Add(typeof(TArg3), arg1);
            ex.Data.Add(typeof(TArg4), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate5Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5)
            );
        if (CreateInstanceDelegate5Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
            ex.Data.Add(typeof(TArg3), arg1);
            ex.Data.Add(typeof(TArg4), arg1);
            ex.Data.Add(typeof(TArg5), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate6Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6)
            );
        if (CreateInstanceDelegate6Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
            ex.Data.Add(typeof(TArg3), arg1);
            ex.Data.Add(typeof(TArg4), arg1);
            ex.Data.Add(typeof(TArg5), arg1);
            ex.Data.Add(typeof(TArg6), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate7Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7)
            );
        if (CreateInstanceDelegate7Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
            ex.Data.Add(typeof(TArg3), arg1);
            ex.Data.Add(typeof(TArg4), arg1);
            ex.Data.Add(typeof(TArg5), arg1);
            ex.Data.Add(typeof(TArg6), arg1);
            ex.Data.Add(typeof(TArg7), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate8Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8)
            );
        if (CreateInstanceDelegate8Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
            ex.Data.Add(typeof(TArg3), arg1);
            ex.Data.Add(typeof(TArg4), arg1);
            ex.Data.Add(typeof(TArg5), arg1);
            ex.Data.Add(typeof(TArg6), arg1);
            ex.Data.Add(typeof(TArg7), arg1);
            ex.Data.Add(typeof(TArg8), arg1);
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
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate9Cache = new(); 
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9)
    {
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9)
            );
        if (CreateInstanceDelegate9Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9
            )
                ?? throw new NullReferenceException("Constructor yielded null result.");
        var constructor = t.GetConstructor(new[] {
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9)
            });
        if (constructor == null)
        {
            var ex = new InvalidOperationException("No matching constructor existing.");
            ex.Data.Add("Target", t);
            ex.Data.Add(typeof(TArg1), arg1);
            ex.Data.Add(typeof(TArg2), arg1);
            ex.Data.Add(typeof(TArg3), arg1);
            ex.Data.Add(typeof(TArg4), arg1);
            ex.Data.Add(typeof(TArg5), arg1);
            ex.Data.Add(typeof(TArg6), arg1);
            ex.Data.Add(typeof(TArg7), arg1);
            ex.Data.Add(typeof(TArg8), arg1);
            ex.Data.Add(typeof(TArg9), arg1);
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
}
