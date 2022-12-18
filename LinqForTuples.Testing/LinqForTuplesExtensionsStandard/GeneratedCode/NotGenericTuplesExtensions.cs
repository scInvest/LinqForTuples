using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqForTuplesExtensionsStandard;

namespace LinqForTuplesExtensionsStandard.GeneratedCode
{
    public static class NotGenericTuplesExtensions
    {
        #region generated code block

        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on key equality and groups the
        /// results. A specified System.Collections.Generic.IEqualityComparer`1 is used to
        /// compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on equality of keys and groups
        /// the results. The default equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from an element from the first sequence and a collection of matching elements from the second sequence. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements of type TResult
        /// that are obtained by performing a grouped join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
        	return outer.ToEnumerable().GroupJoin(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. The default
        /// equality comparer is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this System.ValueTuple<TOuter> outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  IEnumerable<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  System.ValueTuple<TInner> inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Correlates the elements of two sequences based on matching keys. A specified
        /// System.Collections.Generic.IEqualityComparer`1 is used to compare keys.
        ///</summary>
        ///<param name="outer" >The first sequence to join. </param>
        ///<param name="inner" >The sequence to join to the first sequence. </param>
        ///<param name="outerKeySelector" >A function to extract the join key from each element of the first sequence. </param>
        ///<param name="innerKeySelector" >A function to extract the join key from each element of the second sequence. </param>
        ///<param name="resultSelector" >A function to create a result element from two matching elements. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to hash and compare keys. </param>
        ///<typeparam name="TOuter" >The type of the elements of the first sequence. </typeparam>
        ///<typeparam name="TInner" >The type of the elements of the second sequence. </typeparam>
        ///<typeparam name="TKey" >The type of the keys returned by the key selector functions. </typeparam>
        ///<typeparam name="TResult" >The type of the result elements. </typeparam>
        ///<returns>
        /// An System.ValueTuple that has elements of type TResult
        /// that are obtained by performing an inner join on two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >outer or inner or outerKeySelector or innerKeySelector or resultSelector is null. </exception>
        public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this (TOuter, TOuter, TOuter, TOuter, TOuter, TOuter, TOuter) outer,  (TInner, TInner, TInner, TInner, TInner, TInner, TInner) inner,  Func<TOuter, TKey> outerKeySelector,  Func<TInner, TKey> innerKeySelector,  Func<TOuter, TInner, TResult> resultSelector,  IEqualityComparer<TKey> comparer)
        {
        	return outer.ToEnumerable().Join(inner.ToEnumerable(), outerKeySelector, innerKeySelector, resultSelector, comparer);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  IEnumerable<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this System.ValueTuple<TFirst> first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  IEnumerable<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  IEnumerable<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  IEnumerable<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  IEnumerable<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  IEnumerable<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  IEnumerable<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  System.ValueTuple<TSecond> second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        ///<summary>
        /// Applies a specified function to the corresponding elements of two sequences,
        /// producing a sequence of the results.
        ///</summary>
        ///<param name="first" >The first sequence to merge. </param>
        ///<param name="second" >The second sequence to merge. </param>
        ///<param name="resultSelector" >A function that specifies how to merge the elements from the two sequences. </param>
        ///<typeparam name="TFirst" >The type of the elements of the first input sequence. </typeparam>
        ///<typeparam name="TSecond" >The type of the elements of the second input sequence. </typeparam>
        ///<typeparam name="TResult" >The type of the elements of the result sequence. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains merged elements of
        /// two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this (TFirst, TFirst, TFirst, TFirst, TFirst, TFirst, TFirst) first,  (TSecond, TSecond, TSecond, TSecond, TSecond, TSecond, TSecond) second,  Func<TFirst, TSecond, TResult> resultSelector)
        {
        	return first.ToEnumerable().Zip(second.ToEnumerable(), resultSelector);
        }
        #endregion generated code block
    }
}
