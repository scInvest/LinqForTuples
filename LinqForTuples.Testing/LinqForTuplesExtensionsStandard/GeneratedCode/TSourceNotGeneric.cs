using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqForTuplesExtensionsStandard;

namespace LinqForTuplesExtensionsStandard.GeneratedCode
{
   public static  class TSourceNotGeneric
    {
        #region generated code block

        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a sequence of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a sequence of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a sequence of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a sequence of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a sequence of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a sequence of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a sequence of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and compares the keys by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and compares the keys by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and compares the keys by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and compares the keys by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and compares the keys by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and compares the keys by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and compares the keys by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TSource>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TSource)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. Key values are compared
        /// by using a specified comparer, and the elements of each group are projected by
        /// using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. Key values are compared
        /// by using a specified comparer, and the elements of each group are projected by
        /// using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. Key values are compared
        /// by using a specified comparer, and the elements of each group are projected by
        /// using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. Key values are compared
        /// by using a specified comparer, and the elements of each group are projected by
        /// using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. Key values are compared
        /// by using a specified comparer, and the elements of each group are projected by
        /// using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. Key values are compared
        /// by using a specified comparer, and the elements of each group are projected by
        /// using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. Key values are compared
        /// by using a specified comparer, and the elements of each group are projected by
        /// using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a key selector function. The keys
        /// are compared by using a comparer and each group's elements are projected by using
        /// a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a key selector function. The keys
        /// are compared by using a comparer and each group's elements are projected by using
        /// a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a key selector function. The keys
        /// are compared by using a comparer and each group's elements are projected by using
        /// a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a key selector function. The keys
        /// are compared by using a comparer and each group's elements are projected by using
        /// a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a key selector function. The keys
        /// are compared by using a comparer and each group's elements are projected by using
        /// a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a key selector function. The keys
        /// are compared by using a comparer and each group's elements are projected by using
        /// a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a key selector function. The keys
        /// are compared by using a comparer and each group's elements are projected by using
        /// a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The keys are compared
        /// by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The keys are compared
        /// by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The keys are compared
        /// by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The keys are compared
        /// by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The keys are compared
        /// by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The keys are compared
        /// by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The keys are compared
        /// by using a specified comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys with. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The elements of each
        /// group are projected by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The elements of each
        /// group are projected by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The elements of each
        /// group are projected by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The elements of each
        /// group are projected by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The elements of each
        /// group are projected by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The elements of each
        /// group are projected by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and creates a result value from each group and its key. The elements of each
        /// group are projected by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in an System.Linq.IGrouping`2. </param>
        ///<param name="resultSelector" >A function to create a result value from each group. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in each System.Linq.IGrouping`2. </typeparam>
        ///<typeparam name="TResult" >The type of the result value returned by resultSelector. </typeparam>
        ///<returns>
        /// A collection of elements of type TResult where each element represents a projection
        /// over a group and its key.
        ///</returns>
        public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector, resultSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and projects the elements for each group by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in the System.Linq.IGrouping`2. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and projects the elements for each group by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in the System.Linq.IGrouping`2. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and projects the elements for each group by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in the System.Linq.IGrouping`2. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and projects the elements for each group by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in the System.Linq.IGrouping`2. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and projects the elements for each group by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in the System.Linq.IGrouping`2. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and projects the elements for each group by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in the System.Linq.IGrouping`2. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector);
        }
        ///<summary>
        /// Groups the elements of a sequence according to a specified key selector function
        /// and projects the elements for each group by using a specified function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to group. </param>
        ///<param name="keySelector" >A function to extract the key for each element. </param>
        ///<param name="elementSelector" >A function to map each source element to an element in the System.Linq.IGrouping`2. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the elements in the System.Linq.IGrouping`2. </typeparam>
        ///<returns>
        /// An IEnumerable<IGrouping<TKey, TElement>> in C# or IEnumerable(Of IGrouping(Of
        /// TKey, TElement)) in Visual Basic where each System.Linq.IGrouping`2 object contains
        /// a collection of objects of type TElement and a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().GroupBy(keySelector, elementSelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderBy(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderBy(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderBy(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderBy(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderBy(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderBy(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderBy(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderBy(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderBy(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderBy(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderBy(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderBy(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderBy(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted according to a
        /// key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderBy(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order according to a key.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector, comparer);
        }
        ///<summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        ///</summary>
        ///<param name="source" >A sequence of values to order. </param>
        ///<param name="keySelector" >A function to extract a key from an element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// An System.Linq.IOrderedEnumerable`1 whose elements are sorted in descending order
        /// according to a key.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IComparer<TKey> comparer)
        {
        	return source.ToEnumerable().OrderByDescending(keySelector, comparer);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form by incorporating the element's
        /// index.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, int, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form by incorporating the element's
        /// index.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource) source,  Func<TSource, int, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form by incorporating the element's
        /// index.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, int, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form by incorporating the element's
        /// index.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form by incorporating the element's
        /// index.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form by incorporating the element's
        /// index.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence into a new form by incorporating the element's
        /// index.
        ///</summary>
        ///<param name="source" >A sequence of values to invoke a transform function on. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the transform function on each element of source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> Select<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, TResult> selector)
        {
        	return source.ToEnumerable().Select(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// and flattens the resulting sequences into one sequence. The index of each source
        /// element is used in the projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of an input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, int, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// and flattens the resulting sequences into one sequence. The index of each source
        /// element is used in the projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of an input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource) source,  Func<TSource, int, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// and flattens the resulting sequences into one sequence. The index of each source
        /// element is used in the projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of an input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// and flattens the resulting sequences into one sequence. The index of each source
        /// element is used in the projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of an input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// and flattens the resulting sequences into one sequence. The index of each source
        /// element is used in the projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of an input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// and flattens the resulting sequences into one sequence. The index of each source
        /// element is used in the projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of an input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// and flattens the resulting sequences into one sequence. The index of each source
        /// element is used in the projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of an input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein. The index of each source element is used in
        /// the intermediate projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, int, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein. The index of each source element is used in
        /// the intermediate projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource) source,  Func<TSource, int, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein. The index of each source element is used in
        /// the intermediate projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein. The index of each source element is used in
        /// the intermediate projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein. The index of each source element is used in
        /// the intermediate projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein. The index of each source element is used in
        /// the intermediate projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein. The index of each source element is used in
        /// the intermediate projected form of that element.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each source element; the second parameter of the function represents the index of the source element. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each element of the input sequence. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each element of the input sequence. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource) source,  Func<TSource, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each element of the input sequence. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each element of the input sequence. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each element of the input sequence. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each element of the input sequence. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple,
        /// flattens the resulting sequences into one sequence, and invokes a result selector
        /// function on each element therein.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="collectionSelector" >A transform function to apply to each element of the input sequence. </param>
        ///<param name="resultSelector" >A transform function to apply to each element of the intermediate sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TCollection" >The type of the intermediate elements collected by collectionSelector. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the resulting sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function collectionSelector on each element
        /// of source and then mapping each of those sequence elements and their corresponding
        /// source element to a result element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or collectionSelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TCollection>> collectionSelector,  Func<TSource, TCollection, TResult> resultSelector)
        {
        	return source.ToEnumerable().SelectMany(collectionSelector, resultSelector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple
        /// and flattens the resulting sequences into one sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple
        /// and flattens the resulting sequences into one sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource) source,  Func<TSource, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple
        /// and flattens the resulting sequences into one sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple
        /// and flattens the resulting sequences into one sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple
        /// and flattens the resulting sequences into one sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple
        /// and flattens the resulting sequences into one sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Projects each element of a sequence to an System.ValueTuple
        /// and flattens the resulting sequences into one sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to project. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the sequence returned by selector. </typeparam>
        ///<returns>
        /// An System.ValueTuple whose elements are the result of
        /// invoking the one-to-many transform function on each element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, IEnumerable<TResult>> selector)
        {
        	return source.ToEnumerable().SelectMany(selector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer, and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer, and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer, and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer, and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer, and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer, and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Collections.Generic.Dictionary`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer, and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create a System.Collections.Generic.Dictionary`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        /// selected from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null.-or- keySelector produces a key that is null. </exception>
        ///<exception cref="System.ArgumentException" >keySelector produces duplicate keys for two elements. </exception>
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToDictionary(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function and key comparer.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains keys and values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector is null. </exception>
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to specified key selector and element selector functions.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this System.ValueTuple<TSource> source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector, comparer);
        }
        ///<summary>
        /// Creates a System.Linq.Lookup`2 from an System.ValueTuple
        /// according to a specified key selector function, a comparer and an element selector
        /// function.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Linq.Lookup`2 from. </param>
        ///<param name="keySelector" >A function to extract a key from each element. </param>
        ///<param name="elementSelector" >A transform function to produce a result element value from each element. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare keys. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TKey" >The type of the key returned by keySelector. </typeparam>
        ///<typeparam name="TElement" >The type of the value returned by elementSelector. </typeparam>
        ///<returns>
        /// A System.Linq.Lookup`2 that contains values of type TElement selected from the
        /// input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or keySelector or elementSelector is null. </exception>
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TKey> keySelector,  Func<TSource, TElement> elementSelector,  IEqualityComparer<TKey> comparer)
        {
        	return source.ToEnumerable().ToLookup(keySelector, elementSelector, comparer);
        }
        #endregion generated code block
    }
}
