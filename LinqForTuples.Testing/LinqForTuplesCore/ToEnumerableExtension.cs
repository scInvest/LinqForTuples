using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace LinqForTuplesCore
{
    public static class ToEnumerableExtension
    {
        public static IEnumerable<T> ToEnumerable<T>(this System.ValueTuple tuple)
        {
            yield break;
        }
        public static IEnumerable<T> ToEnumerable<T>(this System.ValueTuple<T> tuple)
        {
            yield return tuple.Item1;
        }
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> tuple, Action<T> action)
        {
            foreach (var item in tuple)
            {
                action(item);  
            }
            return tuple;
        }
        public static IEnumerable<T> Concat<T>(this IEnumerable<T> tuple, T item)
        {
            return tuple.Concat(new[] { item });
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, IEnumerable<T>) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, IEnumerable<T>) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, IEnumerable<T>) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T, IEnumerable<T>) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T, T) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T, T, IEnumerable<T>) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T, T, T) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T, T, T, IEnumerable<T>) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T, T, T, T) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<T> ToEnumerable<T>(this (T, T, T, T, T, T, T, IEnumerable<T>) tuple)
        {
            return new TupleEnumeration<T>(tuple);
        }
        public static IEnumerable<object> ToEnumerableAsObject<T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6, T7) tuple)
        {
            return new TupleEnumeration<object>(tuple);
        }
        public static IEnumerable<object> ToEnumerableAsObject<T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4, T5, T6) tuple)
        {
            return new TupleEnumeration<object>(tuple);
        }
        public static IEnumerable<object> ToEnumerableAsObject<T1, T2, T3, T4, T5>(this (T1, T2, T3, T4, T5) tuple)
        {
            return new TupleEnumeration<object>(tuple);
        }
        public static IEnumerable<object> ToEnumerableAsObject<T1, T2, T3, T4>(this (T1, T2, T3, T4) tuple)
        {
            return new TupleEnumeration<object>(tuple);
        }
        public static IEnumerable<object> ToEnumerableAsObject<T1, T2, T3>(this (T1, T2, T3) tuple)
        {
            return new TupleEnumeration<object>(tuple);
        }
        public static IEnumerable<object> ToEnumerableAsObject<T1, T2>(this (T1, T2) tuple)
        {
            return new TupleEnumeration<object>(tuple);
        }
    }
}

