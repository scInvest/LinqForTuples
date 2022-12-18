using System;
using System.Linq;
using System.Collections.Generic;

namespace CutomExtenstions
{
    public class ForTupleExtensions
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

        public static IEnumerable<T> OrEmpty<T>(IEnumerable<T> collection)
        {
            return collection?.Any() != true ? Array.Empty<T>() : collection;
        }
    }
}
