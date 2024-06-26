// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace System
{
    public delegate void Action();

    public delegate void Action<in T>(T obj)
        where T : allows ref struct;

    public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2)
        where T1 : allows ref struct
        where T2 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct
        where T14 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct
        where T14 : allows ref struct
        where T15 : allows ref struct;

    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct
        where T14 : allows ref struct
        where T15 : allows ref struct
        where T16 : allows ref struct;

    // This should probably technically be T? rather than T to match `IComparer<T>`.  However, the use cases are generally different,
    // with Comparison<T> typically being used via a lambda, with the T inferred from the type of the collection being sorted,
    // and forcing nullable warnings onto all such usage leads to many spurious warnings.
    public delegate int Comparison<in T>(T x, T y)
        where T : allows ref struct;

    public delegate TOutput Converter<in TInput, out TOutput>(TInput input)
        where TInput : allows ref struct
        where TOutput : allows ref struct;

    public delegate bool Predicate<in T>(T obj)
        where T : allows ref struct;
}

namespace System.Buffers
{
    public delegate void SpanAction<T, in TArg>(Span<T> span, TArg arg)
        where TArg : allows ref struct;

    public delegate void ReadOnlySpanAction<T, in TArg>(ReadOnlySpan<T> span, TArg arg)
        where TArg : allows ref struct;

    internal delegate TResult SpanFunc<TSpan, in T1, in T2, in T3, out TResult>(Span<TSpan> span, T1 arg1, T2 arg2, T3 arg3);
}
