using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqForTuples.DotNet6
{
    public class TupleEnumeration<T> : IReadOnlyList<T>
    {
        public static implicit operator TupleEnumeration<T>((T, T) tuple) => new TupleEnumeration<T>(tuple);
        public static implicit operator TupleEnumeration<T>((T, T, T) tuple) => new TupleEnumeration<T>(tuple);
        public static implicit operator TupleEnumeration<T>((T, T, T, T) tuple) => new TupleEnumeration<T>(tuple);
        public static implicit operator TupleEnumeration<T>((T, T, T, T, T) tuple) => new TupleEnumeration<T>(tuple);
        public static implicit operator TupleEnumeration<T>((T, T, T, T, T, T) tuple) => new TupleEnumeration<T>(tuple);
        public static implicit operator TupleEnumeration<T>((T, T, T, T, T, T, T) tuple) => new TupleEnumeration<T>(tuple);

        protected readonly List<T> items;

        protected TupleEnumeration()
        {
            items = new List<T>();
        }
        public T this[int index] => items[index];

        public int Count => items.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
        internal void Add(T item)
        {
            items.Add(item);
        }
        public TupleEnumeration(params T[] initItems)
        {
            items = new List<T>(initItems);
        }
        public TupleEnumeration(System.ValueTuple tuple)
        {
            items = new List<T>(0);
        }
        public TupleEnumeration(System.ValueTuple<T> tuple)
        {
            items = new List<T>(1);
            items.Add(tuple.Item1);
        }
        public TupleEnumeration((T, T) tuple)
        {
            items = new List<T>(2);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
        }

        public TupleEnumeration((T, T, T) tuple)
        {
            items = new List<T>(3);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
        }
        public TupleEnumeration((T, T, T, T) tuple)
        {
            items = new List<T>(4);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
        }
        public TupleEnumeration((T, T, T, T, T) tuple)
        {
            items = new List<T>(5);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            items.Add(tuple.Item5);
        }
        public TupleEnumeration((T, T, T, T, T, T) tuple)
        {
            items = new List<T>(6);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            items.Add(tuple.Item5);
            items.Add(tuple.Item6);
        }
        public TupleEnumeration((T, T, T, T, T, T, T) tuple)
        {
            items = new List<T>(7);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            items.Add(tuple.Item5);
            items.Add(tuple.Item6);
            items.Add(tuple.Item7);
        }
        public TupleEnumeration((T, T, T, T, T, T, T, T) tuple)
        {
            items = new List<T>(7);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            items.Add(tuple.Item5);
            items.Add(tuple.Item6);
            items.Add(tuple.Item7);
            items.Add(tuple.Item8);
        }
        public TupleEnumeration(System.ValueTuple<T, IEnumerable<T>> tuple)
        {
            items = new List<T>(1);
            items.Add(tuple.Item1);
            foreach (var item in tuple.Item2)
            {
                items.Add(item);
            }
        }
        public TupleEnumeration((T, T, IEnumerable<T>) tuple)
        {
            items = new List<T>(2);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            foreach (var item in tuple.Item3)
            {
                items.Add(item);
            }
        }

        public TupleEnumeration((T, T, T, IEnumerable<T>) tuple)
        {
            items = new List<T>(3);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            foreach (var item in tuple.Item4)
            {
                items.Add(item);
            }
        }
        public TupleEnumeration((T, T, T, T, IEnumerable<T>) tuple)
        {
            items = new List<T>(4);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            foreach (var item in tuple.Item5)
            {
                items.Add(item);
            }
        }
        public TupleEnumeration((T, T, T, T, T, IEnumerable<T>) tuple)
        {
            items = new List<T>(5);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            items.Add(tuple.Item5);
            foreach (var item in tuple.Item6)
            {
                items.Add(item);
            }
        }
        public TupleEnumeration((T, T, T, T, T, T, IEnumerable<T>) tuple)
        {
            items = new List<T>(6);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            items.Add(tuple.Item5);
            items.Add(tuple.Item6);
            foreach (var item in tuple.Item7)
            {
                items.Add(item);
            }
        }
        public TupleEnumeration((T, T, T, T, T, T, T, IEnumerable<T>) tuple)
        {
            items = new List<T>(7);
            items.Add(tuple.Item1);
            items.Add(tuple.Item2);
            items.Add(tuple.Item3);
            items.Add(tuple.Item4);
            items.Add(tuple.Item5);
            items.Add(tuple.Item6);
            items.Add(tuple.Item7);
            foreach (var item in tuple.Item8)
            {
                items.Add(item);
            }
        }

    }
}
