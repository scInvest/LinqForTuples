using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqForTuplesExtensionsStandard;
using LinqForTuplesExtensionsStandard.GeneratedCode;

namespace LinqForTuplesExtensionsStandard.GeneratedCode
{
    public static class TupleToEnumerable_Many
    {
        #region generated code block

        public static IEnumerable<T> Many<T>(this System.ValueTuple<T> collection)
        {
        	yield return collection.Item1;
        }
        public static IEnumerable<T> Many<T>(this (T, T) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        }
        public static IEnumerable<T> Many<T>(this (T, T, T) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T, T) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        	yield return collection.Item6;
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T, T, T) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        	yield return collection.Item6;
        	yield return collection.Item7;
        }
        public static IEnumerable<T> Many<T>(this (T, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        	if(collection.Item8 == null)
              yield break;
        foreach (var item in collection.Item8)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        	if(collection.Item8 == null)
              yield break;
        foreach (var item in collection.Item8)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        	if(collection.Item8 == null)
              yield break;
        foreach (var item in collection.Item8)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        	if(collection.Item8 == null)
              yield break;
        foreach (var item in collection.Item8)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T, T, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        	yield return collection.Item6;
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (T, T, T, T, T, T, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	yield return collection.Item1;
        	yield return collection.Item2;
        	yield return collection.Item3;
        	yield return collection.Item4;
        	yield return collection.Item5;
        	yield return collection.Item6;
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        	if(collection.Item8 == null)
              yield break;
        foreach (var item in collection.Item8)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (IEnumerable<T>, IEnumerable<T>) collection)
        {
        	if(collection.Item1 == null)
              yield break;
        foreach (var item in collection.Item1)
        {
            yield return item;
        }
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	if(collection.Item1 == null)
              yield break;
        foreach (var item in collection.Item1)
        {
            yield return item;
        }
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	if(collection.Item1 == null)
              yield break;
        foreach (var item in collection.Item1)
        {
            yield return item;
        }
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	if(collection.Item1 == null)
              yield break;
        foreach (var item in collection.Item1)
        {
            yield return item;
        }
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	if(collection.Item1 == null)
              yield break;
        foreach (var item in collection.Item1)
        {
            yield return item;
        }
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        }
        public static IEnumerable<T> Many<T>(this (IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) collection)
        {
        	if(collection.Item1 == null)
              yield break;
        foreach (var item in collection.Item1)
        {
            yield return item;
        }
        	if(collection.Item2 == null)
              yield break;
        foreach (var item in collection.Item2)
        {
            yield return item;
        }
        	if(collection.Item3 == null)
              yield break;
        foreach (var item in collection.Item3)
        {
            yield return item;
        }
        	if(collection.Item4 == null)
              yield break;
        foreach (var item in collection.Item4)
        {
            yield return item;
        }
        	if(collection.Item5 == null)
              yield break;
        foreach (var item in collection.Item5)
        {
            yield return item;
        }
        	if(collection.Item6 == null)
              yield break;
        foreach (var item in collection.Item6)
        {
            yield return item;
        }
        	if(collection.Item7 == null)
              yield break;
        foreach (var item in collection.Item7)
        {
            yield return item;
        }
        }
        #endregion generated code block
    }
}
