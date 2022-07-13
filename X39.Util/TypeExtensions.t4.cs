
using System.Linq.Expressions;

namespace X39.Util;
public static partial class TypeExtensionMethods
{

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
    private static readonly Dictionary<(
            Type,
            Type
            ), Delegate> CreateInstanceDelegate1Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type
            >, Delegate> CreateInstanceDelegate1Cache = new(); 
#endif
    public static object CreateInstance<TArg1>(
        this Type t,
        TArg1 arg1)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (
            t,
            typeof(TArg1)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1)
            );
#endif
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
    private static readonly Dictionary<(
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate2Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type
            >, Delegate> CreateInstanceDelegate2Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2)
            );
#endif
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate3Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type
            >, Delegate> CreateInstanceDelegate3Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3)
            );
#endif
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate4Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type
            >, Delegate> CreateInstanceDelegate4Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4)
            );
#endif
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate5Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            >, Delegate> CreateInstanceDelegate5Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5)
            );
#endif
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
    private static readonly Dictionary<(
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate6Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            >, Delegate> CreateInstanceDelegate6Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
        var key = (
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6)
            );
#endif
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
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            >, Delegate> CreateInstanceDelegate7Cache = new(); 
#endif
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
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7)
            );
#endif
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
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            >, Delegate> CreateInstanceDelegate8Cache = new(); 
#endif
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
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
#else
        var key = Tuple.Create(
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
#endif
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
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
#else
    private static readonly Dictionary<Tuple<
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
            >, Delegate> CreateInstanceDelegate9Cache = new(); 
#endif
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
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
#else
        var key = Tuple.Create(
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
#endif
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
#endif
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type
            ), Delegate> CreateInstanceDelegate10Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
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
            >, Delegate> CreateInstanceDelegate10Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10)
            );
#endif
        if (CreateInstanceDelegate10Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10
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
            typeof(TArg9),
            typeof(TArg10)
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
            ex.Data.Add(typeof(TArg10), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate11Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate11Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11)
            );
#endif
        if (CreateInstanceDelegate11Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate12Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate12Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12)
            );
#endif
        if (CreateInstanceDelegate12Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate13Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate13Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12,
        TArg13 arg13)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13)
            );
#endif
        if (CreateInstanceDelegate13Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
            ex.Data.Add(typeof(TArg13), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate14Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate14Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12,
        TArg13 arg13,
        TArg14 arg14)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14)
            );
#endif
        if (CreateInstanceDelegate14Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
            ex.Data.Add(typeof(TArg13), arg1);
            ex.Data.Add(typeof(TArg14), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate15Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate15Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12,
        TArg13 arg13,
        TArg14 arg14,
        TArg15 arg15)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15)
            );
#endif
        if (CreateInstanceDelegate15Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
            ex.Data.Add(typeof(TArg13), arg1);
            ex.Data.Add(typeof(TArg14), arg1);
            ex.Data.Add(typeof(TArg15), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate16Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate16Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12,
        TArg13 arg13,
        TArg14 arg14,
        TArg15 arg15,
        TArg16 arg16)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16)
            );
#endif
        if (CreateInstanceDelegate16Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
            ex.Data.Add(typeof(TArg13), arg1);
            ex.Data.Add(typeof(TArg14), arg1);
            ex.Data.Add(typeof(TArg15), arg1);
            ex.Data.Add(typeof(TArg16), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type
            ), Delegate> CreateInstanceDelegate17Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate17Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12,
        TArg13 arg13,
        TArg14 arg14,
        TArg15 arg15,
        TArg16 arg16,
        TArg17 arg17)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17)
            );
#endif
        if (CreateInstanceDelegate17Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
            ex.Data.Add(typeof(TArg13), arg1);
            ex.Data.Add(typeof(TArg14), arg1);
            ex.Data.Add(typeof(TArg15), arg1);
            ex.Data.Add(typeof(TArg16), arg1);
            ex.Data.Add(typeof(TArg17), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            ), Delegate> CreateInstanceDelegate18Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate18Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12,
        TArg13 arg13,
        TArg14 arg14,
        TArg15 arg15,
        TArg16 arg16,
        TArg17 arg17,
        TArg18 arg18)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17),
            typeof(TArg18)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17),
            typeof(TArg18)
            );
#endif
        if (CreateInstanceDelegate18Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17),
            typeof(TArg18)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
            ex.Data.Add(typeof(TArg13), arg1);
            ex.Data.Add(typeof(TArg14), arg1);
            ex.Data.Add(typeof(TArg15), arg1);
            ex.Data.Add(typeof(TArg16), arg1);
            ex.Data.Add(typeof(TArg17), arg1);
            ex.Data.Add(typeof(TArg18), arg1);
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

#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            Type,
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
            ), Delegate> CreateInstanceDelegate19Cache = new(); 
#else
    private static readonly Dictionary<Tuple<
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
            Type,
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
            >, Delegate> CreateInstanceDelegate19Cache = new(); 
#endif
    public static object CreateInstance<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(
        this Type t,
        TArg1 arg1,
        TArg2 arg2,
        TArg3 arg3,
        TArg4 arg4,
        TArg5 arg5,
        TArg6 arg6,
        TArg7 arg7,
        TArg8 arg8,
        TArg9 arg9,
        TArg10 arg10,
        TArg11 arg11,
        TArg12 arg12,
        TArg13 arg13,
        TArg14 arg14,
        TArg15 arg15,
        TArg16 arg16,
        TArg17 arg17,
        TArg18 arg18,
        TArg19 arg19)
    {
#if NET5_0_OR_GREATER || NETSTANDARD2_0 || NETSTANDARD2_1 || NET47 || NET471 || NET472
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17),
            typeof(TArg18),
            typeof(TArg19)
            );
#else
        var key = Tuple.Create(
            t,
            typeof(TArg1),
            typeof(TArg2),
            typeof(TArg3),
            typeof(TArg4),
            typeof(TArg5),
            typeof(TArg6),
            typeof(TArg7),
            typeof(TArg8),
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17),
            typeof(TArg18),
            typeof(TArg19)
            );
#endif
        if (CreateInstanceDelegate19Cache.TryGetValue(key, out var del))
            return del.DynamicInvoke(arg1,
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
            typeof(TArg9),
            typeof(TArg10),
            typeof(TArg11),
            typeof(TArg12),
            typeof(TArg13),
            typeof(TArg14),
            typeof(TArg15),
            typeof(TArg16),
            typeof(TArg17),
            typeof(TArg18),
            typeof(TArg19)
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
            ex.Data.Add(typeof(TArg10), arg1);
            ex.Data.Add(typeof(TArg11), arg1);
            ex.Data.Add(typeof(TArg12), arg1);
            ex.Data.Add(typeof(TArg13), arg1);
            ex.Data.Add(typeof(TArg14), arg1);
            ex.Data.Add(typeof(TArg15), arg1);
            ex.Data.Add(typeof(TArg16), arg1);
            ex.Data.Add(typeof(TArg17), arg1);
            ex.Data.Add(typeof(TArg18), arg1);
            ex.Data.Add(typeof(TArg19), arg1);
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
