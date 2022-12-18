
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqForTuples.NetFramework
{
    //Please add each method to correspoinding Data file.
    public class CustomTupleExtenstions
    {
        public static void ForEach<T>(IEnumerable<T> collection, Action<T> apply)
        {
            foreach (var item in collection)
            {
                apply(item);
            }
        }
        public static IEnumerable<T> Apply<T>(IEnumerable<T> collection, Action<T> apply)
        {
            foreach (var item in collection)
            {
                apply(item);
                yield return item;
            }
        }
        public static IEnumerable<T> Concat<T>(IEnumerable<T> collection, params T[] items)
        {
            return collection.Concat(items);
        }
        public static IEnumerable<T> Many<T>(IEnumerable<IEnumerable<T>> collection)
        {
            return collection.SelectMany(x => x);
        }
        public static bool IsNullOrEmpty<T>(IEnumerable<T> collection)
        {
            return collection?.Any() != true;
        }
        public static bool AnyIsNull<T>(IEnumerable<T> collection)
        {
            return collection.Any(x => x == null);
        }
        public static IEnumerable<T> WhereNotNull<T>(IEnumerable<T> collection)
        {
            return collection.Where(x => x != null);
        }
        public static IEnumerable<T> OrEmpty<T>(IEnumerable<T> collection)
        {
            return collection?.Any() != true ? Array.Empty<T>() : collection;
        }
    }
}
