using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqForTuplesExtensionsStandard;

namespace LinqForTuplesExtensionsStandard.GeneratedCode
{
    public static class SimpleLinqTuplesExtensions
    {
        #region generated code block

        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        public static TAccumulate Aggregate<TSource, TAccumulate>(this System.ValueTuple<TSource> source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func)
        {
        	return source.ToEnumerable().Aggregate(seed, func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        public static TAccumulate Aggregate<TSource, TAccumulate>(this (TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func)
        {
        	return source.ToEnumerable().Aggregate(seed, func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        public static TAccumulate Aggregate<TSource, TAccumulate>(this (TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func)
        {
        	return source.ToEnumerable().Aggregate(seed, func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        public static TAccumulate Aggregate<TSource, TAccumulate>(this (TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func)
        {
        	return source.ToEnumerable().Aggregate(seed, func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        public static TAccumulate Aggregate<TSource, TAccumulate>(this (TSource, TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func)
        {
        	return source.ToEnumerable().Aggregate(seed, func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        public static TAccumulate Aggregate<TSource, TAccumulate>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func)
        {
        	return source.ToEnumerable().Aggregate(seed, func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        public static TAccumulate Aggregate<TSource, TAccumulate>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func)
        {
        	return source.ToEnumerable().Aggregate(seed, func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value, and the specified function is used to
        /// select the result value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<param name="resultSelector" >A function to transform the final accumulator value into the result value. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<typeparam name="TResult" >The type of the resulting value. </typeparam>
        ///<returns>
        /// The transformed final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func or resultSelector is null. </exception>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this System.ValueTuple<TSource> source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func,  Func<TAccumulate, TResult> resultSelector)
        {
        	return source.ToEnumerable().Aggregate(seed, func, resultSelector);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value, and the specified function is used to
        /// select the result value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<param name="resultSelector" >A function to transform the final accumulator value into the result value. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<typeparam name="TResult" >The type of the resulting value. </typeparam>
        ///<returns>
        /// The transformed final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func or resultSelector is null. </exception>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this (TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func,  Func<TAccumulate, TResult> resultSelector)
        {
        	return source.ToEnumerable().Aggregate(seed, func, resultSelector);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value, and the specified function is used to
        /// select the result value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<param name="resultSelector" >A function to transform the final accumulator value into the result value. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<typeparam name="TResult" >The type of the resulting value. </typeparam>
        ///<returns>
        /// The transformed final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func or resultSelector is null. </exception>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this (TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func,  Func<TAccumulate, TResult> resultSelector)
        {
        	return source.ToEnumerable().Aggregate(seed, func, resultSelector);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value, and the specified function is used to
        /// select the result value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<param name="resultSelector" >A function to transform the final accumulator value into the result value. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<typeparam name="TResult" >The type of the resulting value. </typeparam>
        ///<returns>
        /// The transformed final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func or resultSelector is null. </exception>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this (TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func,  Func<TAccumulate, TResult> resultSelector)
        {
        	return source.ToEnumerable().Aggregate(seed, func, resultSelector);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value, and the specified function is used to
        /// select the result value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<param name="resultSelector" >A function to transform the final accumulator value into the result value. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<typeparam name="TResult" >The type of the resulting value. </typeparam>
        ///<returns>
        /// The transformed final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func or resultSelector is null. </exception>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func,  Func<TAccumulate, TResult> resultSelector)
        {
        	return source.ToEnumerable().Aggregate(seed, func, resultSelector);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value, and the specified function is used to
        /// select the result value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<param name="resultSelector" >A function to transform the final accumulator value into the result value. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<typeparam name="TResult" >The type of the resulting value. </typeparam>
        ///<returns>
        /// The transformed final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func or resultSelector is null. </exception>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func,  Func<TAccumulate, TResult> resultSelector)
        {
        	return source.ToEnumerable().Aggregate(seed, func, resultSelector);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence. The specified seed value is
        /// used as the initial accumulator value, and the specified function is used to
        /// select the result value.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="seed" >The initial accumulator value. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<param name="resultSelector" >A function to transform the final accumulator value into the result value. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TAccumulate" >The type of the accumulator value. </typeparam>
        ///<typeparam name="TResult" >The type of the resulting value. </typeparam>
        ///<returns>
        /// The transformed final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func or resultSelector is null. </exception>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  TAccumulate seed,  Func<TAccumulate, TSource, TAccumulate> func,  Func<TAccumulate, TResult> resultSelector)
        {
        	return source.ToEnumerable().Aggregate(seed, func, resultSelector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the maximum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Max<TSource, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the maximum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Max<TSource, TResult>(this (TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the maximum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Max<TSource, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the maximum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Max<TSource, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the maximum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Max<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the maximum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Max<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the maximum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Max<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the minimum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Min<TSource, TResult>(this System.ValueTuple<TSource> source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the minimum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Min<TSource, TResult>(this (TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the minimum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Min<TSource, TResult>(this (TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the minimum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Min<TSource, TResult>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the minimum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Min<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the minimum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Min<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a generic sequence and returns
        /// the minimum resulting value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<typeparam name="TResult" >The type of the value returned by selector. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static TResult Min<TSource, TResult>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TResult> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static TSource Aggregate<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, TSource, TSource> func)
        {
        	return source.ToEnumerable().Aggregate(func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static TSource Aggregate<TSource>(this (TSource, TSource) source,  Func<TSource, TSource, TSource> func)
        {
        	return source.ToEnumerable().Aggregate(func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static TSource Aggregate<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, TSource, TSource> func)
        {
        	return source.ToEnumerable().Aggregate(func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static TSource Aggregate<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, TSource, TSource> func)
        {
        	return source.ToEnumerable().Aggregate(func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static TSource Aggregate<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TSource, TSource> func)
        {
        	return source.ToEnumerable().Aggregate(func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static TSource Aggregate<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TSource, TSource> func)
        {
        	return source.ToEnumerable().Aggregate(func);
        }
        ///<summary>
        /// Applies an accumulator function over a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to aggregate over. </param>
        ///<param name="func" >An accumulator function to be invoked on each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The final accumulator value.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or func is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static TSource Aggregate<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, TSource, TSource> func)
        {
        	return source.ToEnumerable().Aggregate(func);
        }
        ///<summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if every element of the source sequence passes the test in the specified
        /// predicate, or if the sequence is empty; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool All<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().All(predicate);
        }
        ///<summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if every element of the source sequence passes the test in the specified
        /// predicate, or if the sequence is empty; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool All<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().All(predicate);
        }
        ///<summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if every element of the source sequence passes the test in the specified
        /// predicate, or if the sequence is empty; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool All<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().All(predicate);
        }
        ///<summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if every element of the source sequence passes the test in the specified
        /// predicate, or if the sequence is empty; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool All<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().All(predicate);
        }
        ///<summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if every element of the source sequence passes the test in the specified
        /// predicate, or if the sequence is empty; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool All<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().All(predicate);
        }
        ///<summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if every element of the source sequence passes the test in the specified
        /// predicate, or if the sequence is empty; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool All<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().All(predicate);
        }
        ///<summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if every element of the source sequence passes the test in the specified
        /// predicate, or if the sequence is empty; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool All<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().All(predicate);
        }
        ///<summary>
        /// Determines whether any element of a sequence satisfies a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if any elements in the source sequence pass the test in the specified predicate;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool Any<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Any(predicate);
        }
        ///<summary>
        /// Determines whether any element of a sequence satisfies a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if any elements in the source sequence pass the test in the specified predicate;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Any(predicate);
        }
        ///<summary>
        /// Determines whether any element of a sequence satisfies a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if any elements in the source sequence pass the test in the specified predicate;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Any(predicate);
        }
        ///<summary>
        /// Determines whether any element of a sequence satisfies a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if any elements in the source sequence pass the test in the specified predicate;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Any(predicate);
        }
        ///<summary>
        /// Determines whether any element of a sequence satisfies a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if any elements in the source sequence pass the test in the specified predicate;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Any(predicate);
        }
        ///<summary>
        /// Determines whether any element of a sequence satisfies a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if any elements in the source sequence pass the test in the specified predicate;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Any(predicate);
        }
        ///<summary>
        /// Determines whether any element of a sequence satisfies a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple whose elements to apply the predicate to. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if any elements in the source sequence pass the test in the specified predicate;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Any(predicate);
        }
        ///<summary>
        /// Determines whether a sequence contains any elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to check for emptiness. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains any elements; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Any<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Any();
        }
        ///<summary>
        /// Determines whether a sequence contains any elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to check for emptiness. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains any elements; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Any();
        }
        ///<summary>
        /// Determines whether a sequence contains any elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to check for emptiness. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains any elements; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Any();
        }
        ///<summary>
        /// Determines whether a sequence contains any elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to check for emptiness. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains any elements; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Any();
        }
        ///<summary>
        /// Determines whether a sequence contains any elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to check for emptiness. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains any elements; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Any();
        }
        ///<summary>
        /// Determines whether a sequence contains any elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to check for emptiness. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains any elements; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Any();
        }
        ///<summary>
        /// Determines whether a sequence contains any elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to check for emptiness. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains any elements; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Any<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Any();
        }
        ///<summary>
        /// Appends a value to the end of the sequence.
        ///</summary>
        ///<param name="source" >A sequence of values. </param>
        ///<param name="element" >The value to append to source. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A new sequence that ends with element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Append<TSource>(this System.ValueTuple<TSource> source,  TSource element)
        {
        	return source.ToEnumerable().Append(element);
        }
        ///<summary>
        /// Appends a value to the end of the sequence.
        ///</summary>
        ///<param name="source" >A sequence of values. </param>
        ///<param name="element" >The value to append to source. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A new sequence that ends with element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Append<TSource>(this (TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Append(element);
        }
        ///<summary>
        /// Appends a value to the end of the sequence.
        ///</summary>
        ///<param name="source" >A sequence of values. </param>
        ///<param name="element" >The value to append to source. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A new sequence that ends with element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Append<TSource>(this (TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Append(element);
        }
        ///<summary>
        /// Appends a value to the end of the sequence.
        ///</summary>
        ///<param name="source" >A sequence of values. </param>
        ///<param name="element" >The value to append to source. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A new sequence that ends with element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Append<TSource>(this (TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Append(element);
        }
        ///<summary>
        /// Appends a value to the end of the sequence.
        ///</summary>
        ///<param name="source" >A sequence of values. </param>
        ///<param name="element" >The value to append to source. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A new sequence that ends with element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Append<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Append(element);
        }
        ///<summary>
        /// Appends a value to the end of the sequence.
        ///</summary>
        ///<param name="source" >A sequence of values. </param>
        ///<param name="element" >The value to append to source. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A new sequence that ends with element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Append<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Append(element);
        }
        ///<summary>
        /// Appends a value to the end of the sequence.
        ///</summary>
        ///<param name="source" >A sequence of values. </param>
        ///<param name="element" >The value to append to source. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A new sequence that ends with element.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Append<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Append(element);
        }
        ///<summary>
        /// Returns the input typed as System.ValueTuple.
        ///</summary>
        ///<param name="source" >The sequence to type as System.ValueTuple. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The input sequence typed as System.ValueTuple.
        ///</returns>
        public static IEnumerable<TSource> AsEnumerable<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().AsEnumerable();
        }
        ///<summary>
        /// Returns the input typed as System.ValueTuple.
        ///</summary>
        ///<param name="source" >The sequence to type as System.ValueTuple. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The input sequence typed as System.ValueTuple.
        ///</returns>
        public static IEnumerable<TSource> AsEnumerable<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().AsEnumerable();
        }
        ///<summary>
        /// Returns the input typed as System.ValueTuple.
        ///</summary>
        ///<param name="source" >The sequence to type as System.ValueTuple. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The input sequence typed as System.ValueTuple.
        ///</returns>
        public static IEnumerable<TSource> AsEnumerable<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().AsEnumerable();
        }
        ///<summary>
        /// Returns the input typed as System.ValueTuple.
        ///</summary>
        ///<param name="source" >The sequence to type as System.ValueTuple. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The input sequence typed as System.ValueTuple.
        ///</returns>
        public static IEnumerable<TSource> AsEnumerable<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().AsEnumerable();
        }
        ///<summary>
        /// Returns the input typed as System.ValueTuple.
        ///</summary>
        ///<param name="source" >The sequence to type as System.ValueTuple. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The input sequence typed as System.ValueTuple.
        ///</returns>
        public static IEnumerable<TSource> AsEnumerable<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().AsEnumerable();
        }
        ///<summary>
        /// Returns the input typed as System.ValueTuple.
        ///</summary>
        ///<param name="source" >The sequence to type as System.ValueTuple. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The input sequence typed as System.ValueTuple.
        ///</returns>
        public static IEnumerable<TSource> AsEnumerable<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().AsEnumerable();
        }
        ///<summary>
        /// Returns the input typed as System.ValueTuple.
        ///</summary>
        ///<param name="source" >The sequence to type as System.ValueTuple. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The input sequence typed as System.ValueTuple.
        ///</returns>
        public static IEnumerable<TSource> AsEnumerable<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().AsEnumerable();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average<TSource>(this (TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate an average. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate an average. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal Average<TSource>(this (TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate an average. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate an average. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate an average. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate an average. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate an average. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Average<TSource>(this (TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average<TSource>(this (TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Average<TSource>(this (TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values that are
        /// obtained by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average<TSource>(this (TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average<TSource>(this (TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        public static double? Average<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        public static double? Average<TSource>(this (TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        public static double? Average<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to calculate the average of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        public static double? Average<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Average(selector);
        }
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>
        ///<param name="first" >The first sequence to concatenate. </param>
        ///<param name="second" >The sequence to concatenate to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the concatenated elements
        /// of the two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Concat<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Concat(second);
        }
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>
        ///<param name="first" >The first sequence to concatenate. </param>
        ///<param name="second" >The sequence to concatenate to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the concatenated elements
        /// of the two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Concat<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Concat(second);
        }
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>
        ///<param name="first" >The first sequence to concatenate. </param>
        ///<param name="second" >The sequence to concatenate to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the concatenated elements
        /// of the two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Concat<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Concat(second);
        }
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>
        ///<param name="first" >The first sequence to concatenate. </param>
        ///<param name="second" >The sequence to concatenate to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the concatenated elements
        /// of the two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Concat<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Concat(second);
        }
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>
        ///<param name="first" >The first sequence to concatenate. </param>
        ///<param name="second" >The sequence to concatenate to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the concatenated elements
        /// of the two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Concat<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Concat(second);
        }
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>
        ///<param name="first" >The first sequence to concatenate. </param>
        ///<param name="second" >The sequence to concatenate to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the concatenated elements
        /// of the two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Concat<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Concat(second);
        }
        ///<summary>
        /// Concatenates two sequences.
        ///</summary>
        ///<param name="first" >The first sequence to concatenate. </param>
        ///<param name="second" >The sequence to concatenate to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the concatenated elements
        /// of the two input sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Concat<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Concat(second);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using a specified
        /// System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<param name="comparer" >An equality comparer to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this System.ValueTuple<TSource> source,  TSource value,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Contains(value, comparer);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using a specified
        /// System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<param name="comparer" >An equality comparer to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource) source,  TSource value,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Contains(value, comparer);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using a specified
        /// System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<param name="comparer" >An equality comparer to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource) source,  TSource value,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Contains(value, comparer);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using a specified
        /// System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<param name="comparer" >An equality comparer to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource) source,  TSource value,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Contains(value, comparer);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using a specified
        /// System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<param name="comparer" >An equality comparer to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  TSource value,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Contains(value, comparer);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using a specified
        /// System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<param name="comparer" >An equality comparer to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource value,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Contains(value, comparer);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using a specified
        /// System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<param name="comparer" >An equality comparer to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource value,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Contains(value, comparer);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using the default
        /// equality comparer.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this System.ValueTuple<TSource> source,  TSource value)
        {
        	return source.ToEnumerable().Contains(value);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using the default
        /// equality comparer.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource) source,  TSource value)
        {
        	return source.ToEnumerable().Contains(value);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using the default
        /// equality comparer.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource) source,  TSource value)
        {
        	return source.ToEnumerable().Contains(value);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using the default
        /// equality comparer.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource) source,  TSource value)
        {
        	return source.ToEnumerable().Contains(value);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using the default
        /// equality comparer.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  TSource value)
        {
        	return source.ToEnumerable().Contains(value);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using the default
        /// equality comparer.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource value)
        {
        	return source.ToEnumerable().Contains(value);
        }
        ///<summary>
        /// Determines whether a sequence contains a specified element by using the default
        /// equality comparer.
        ///</summary>
        ///<param name="source" >A sequence in which to locate a value. </param>
        ///<param name="value" >The value to locate in the sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// true if the source sequence contains an element that has the specified value;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static bool Contains<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource value)
        {
        	return source.ToEnumerable().Contains(value);
        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence
        /// satisfy a condition.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be tested and counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Count(predicate);
        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence
        /// satisfy a condition.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be tested and counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Count(predicate);
        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence
        /// satisfy a condition.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be tested and counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Count(predicate);
        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence
        /// satisfy a condition.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be tested and counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Count(predicate);
        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence
        /// satisfy a condition.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be tested and counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Count(predicate);
        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence
        /// satisfy a condition.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be tested and counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Count(predicate);
        }
        ///<summary>
        /// Returns a number that represents how many elements in the specified sequence
        /// satisfy a condition.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be tested and counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Count(predicate);
        }
        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Count();
        }
        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Count();
        }
        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Count();
        }
        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Count();
        }
        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Count();
        }
        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Count();
        }
        ///<summary>
        /// Returns the number of elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence that contains elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements in source is larger than System.Int32.MaxValue. </exception>
        public static int Count<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Count();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the type parameter's default
        /// value in a singleton collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return a default value for if it is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple object that contains the default
        /// value for the TSource type if source is empty; otherwise, source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().DefaultIfEmpty();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the type parameter's default
        /// value in a singleton collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return a default value for if it is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple object that contains the default
        /// value for the TSource type if source is empty; otherwise, source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().DefaultIfEmpty();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the type parameter's default
        /// value in a singleton collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return a default value for if it is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple object that contains the default
        /// value for the TSource type if source is empty; otherwise, source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().DefaultIfEmpty();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the type parameter's default
        /// value in a singleton collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return a default value for if it is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple object that contains the default
        /// value for the TSource type if source is empty; otherwise, source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().DefaultIfEmpty();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the type parameter's default
        /// value in a singleton collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return a default value for if it is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple object that contains the default
        /// value for the TSource type if source is empty; otherwise, source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().DefaultIfEmpty();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the type parameter's default
        /// value in a singleton collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return a default value for if it is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple object that contains the default
        /// value for the TSource type if source is empty; otherwise, source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().DefaultIfEmpty();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the type parameter's default
        /// value in a singleton collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return a default value for if it is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple object that contains the default
        /// value for the TSource type if source is empty; otherwise, source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().DefaultIfEmpty();
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton
        /// collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return the specified value for if it is empty. </param>
        ///<param name="defaultValue" >The value to return if the sequence is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains defaultValue if source
        /// is empty; otherwise, source.
        ///</returns>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this System.ValueTuple<TSource> source,  TSource defaultValue)
        {
        	return source.ToEnumerable().DefaultIfEmpty(defaultValue);
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton
        /// collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return the specified value for if it is empty. </param>
        ///<param name="defaultValue" >The value to return if the sequence is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains defaultValue if source
        /// is empty; otherwise, source.
        ///</returns>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource) source,  TSource defaultValue)
        {
        	return source.ToEnumerable().DefaultIfEmpty(defaultValue);
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton
        /// collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return the specified value for if it is empty. </param>
        ///<param name="defaultValue" >The value to return if the sequence is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains defaultValue if source
        /// is empty; otherwise, source.
        ///</returns>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource) source,  TSource defaultValue)
        {
        	return source.ToEnumerable().DefaultIfEmpty(defaultValue);
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton
        /// collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return the specified value for if it is empty. </param>
        ///<param name="defaultValue" >The value to return if the sequence is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains defaultValue if source
        /// is empty; otherwise, source.
        ///</returns>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource) source,  TSource defaultValue)
        {
        	return source.ToEnumerable().DefaultIfEmpty(defaultValue);
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton
        /// collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return the specified value for if it is empty. </param>
        ///<param name="defaultValue" >The value to return if the sequence is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains defaultValue if source
        /// is empty; otherwise, source.
        ///</returns>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  TSource defaultValue)
        {
        	return source.ToEnumerable().DefaultIfEmpty(defaultValue);
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton
        /// collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return the specified value for if it is empty. </param>
        ///<param name="defaultValue" >The value to return if the sequence is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains defaultValue if source
        /// is empty; otherwise, source.
        ///</returns>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource defaultValue)
        {
        	return source.ToEnumerable().DefaultIfEmpty(defaultValue);
        }
        ///<summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton
        /// collection if the sequence is empty.
        ///</summary>
        ///<param name="source" >The sequence to return the specified value for if it is empty. </param>
        ///<param name="defaultValue" >The value to return if the sequence is empty. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains defaultValue if source
        /// is empty; otherwise, source.
        ///</returns>
        public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource defaultValue)
        {
        	return source.ToEnumerable().DefaultIfEmpty(defaultValue);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this System.ValueTuple<TSource> source,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Distinct(comparer);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource) source,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Distinct(comparer);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource) source,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Distinct(comparer);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource) source,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Distinct(comparer);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Distinct(comparer);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Distinct(comparer);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using a specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  IEqualityComparer<TSource> comparer)
        {
        	return source.ToEnumerable().Distinct(comparer);
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Distinct();
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Distinct();
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Distinct();
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Distinct();
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Distinct();
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Distinct();
        }
        ///<summary>
        /// Returns distinct elements from a sequence by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="source" >The sequence to remove duplicate elements from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains distinct elements from
        /// the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Distinct<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Distinct();
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.ArgumentOutOfRangeException" >index is less than 0 or greater than or equal to the number of elements in source. </exception>
        public static TSource ElementAt<TSource>(this System.ValueTuple<TSource> source,  int index)
        {
        	return source.ToEnumerable().ElementAt(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.ArgumentOutOfRangeException" >index is less than 0 or greater than or equal to the number of elements in source. </exception>
        public static TSource ElementAt<TSource>(this (TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAt(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.ArgumentOutOfRangeException" >index is less than 0 or greater than or equal to the number of elements in source. </exception>
        public static TSource ElementAt<TSource>(this (TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAt(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.ArgumentOutOfRangeException" >index is less than 0 or greater than or equal to the number of elements in source. </exception>
        public static TSource ElementAt<TSource>(this (TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAt(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.ArgumentOutOfRangeException" >index is less than 0 or greater than or equal to the number of elements in source. </exception>
        public static TSource ElementAt<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAt(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.ArgumentOutOfRangeException" >index is less than 0 or greater than or equal to the number of elements in source. </exception>
        public static TSource ElementAt<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAt(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.ArgumentOutOfRangeException" >index is less than 0 or greater than or equal to the number of elements in source. </exception>
        public static TSource ElementAt<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAt(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence or a default value if
        /// the index is out of range.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        /// the element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource ElementAtOrDefault<TSource>(this System.ValueTuple<TSource> source,  int index)
        {
        	return source.ToEnumerable().ElementAtOrDefault(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence or a default value if
        /// the index is out of range.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        /// the element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource ElementAtOrDefault<TSource>(this (TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAtOrDefault(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence or a default value if
        /// the index is out of range.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        /// the element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource ElementAtOrDefault<TSource>(this (TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAtOrDefault(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence or a default value if
        /// the index is out of range.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        /// the element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource ElementAtOrDefault<TSource>(this (TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAtOrDefault(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence or a default value if
        /// the index is out of range.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        /// the element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource ElementAtOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAtOrDefault(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence or a default value if
        /// the index is out of range.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        /// the element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource ElementAtOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAtOrDefault(index);
        }
        ///<summary>
        /// Returns the element at a specified index in a sequence or a default value if
        /// the index is out of range.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="index" >The zero-based index of the element to retrieve. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the index is outside the bounds of the source sequence; otherwise,
        /// the element at the specified position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource ElementAtOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  int index)
        {
        	return source.ToEnumerable().ElementAtOrDefault(index);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Except(second);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Except(second);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Except(second);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Except(second);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Except(second);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Except(second);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the default equality comparer
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Except(second);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Except(second, comparer);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Except(second, comparer);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Except(second, comparer);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Except(second, comparer);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Except(second, comparer);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Except(second, comparer);
        }
        ///<summary>
        /// Produces the set difference of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose elements that are not also in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the set difference of the elements of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Except<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Except(second, comparer);
        }
        ///<summary>
        /// Returns the first element of a sequence.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the specified sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource First<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().First();
        }
        ///<summary>
        /// Returns the first element of a sequence.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the specified sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().First();
        }
        ///<summary>
        /// Returns the first element of a sequence.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the specified sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().First();
        }
        ///<summary>
        /// Returns the first element of a sequence.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the specified sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().First();
        }
        ///<summary>
        /// Returns the first element of a sequence.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the specified sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().First();
        }
        ///<summary>
        /// Returns the first element of a sequence.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the specified sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().First();
        }
        ///<summary>
        /// Returns the first element of a sequence.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the specified sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().First();
        }
        ///<summary>
        /// Returns the first element in a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource First<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().First(predicate);
        }
        ///<summary>
        /// Returns the first element in a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().First(predicate);
        }
        ///<summary>
        /// Returns the first element in a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().First(predicate);
        }
        ///<summary>
        /// Returns the first element in a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().First(predicate);
        }
        ///<summary>
        /// Returns the first element in a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().First(predicate);
        }
        ///<summary>
        /// Returns the first element in a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().First(predicate);
        }
        ///<summary>
        /// Returns the first element in a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The first element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource First<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().First(predicate);
        }
        ///<summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty; otherwise, the first element in source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource FirstOrDefault<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().FirstOrDefault();
        }
        ///<summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty; otherwise, the first element in source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().FirstOrDefault();
        }
        ///<summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty; otherwise, the first element in source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().FirstOrDefault();
        }
        ///<summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty; otherwise, the first element in source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().FirstOrDefault();
        }
        ///<summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty; otherwise, the first element in source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().FirstOrDefault();
        }
        ///<summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty; otherwise, the first element in source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().FirstOrDefault();
        }
        ///<summary>
        /// Returns the first element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to return the first element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty; otherwise, the first element in source.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().FirstOrDefault();
        }
        ///<summary>
        /// Returns the first element of the sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty or if no element passes the test specified
        /// by predicate; otherwise, the first element in source that passes the test specified
        /// by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource FirstOrDefault<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().FirstOrDefault(predicate);
        }
        ///<summary>
        /// Returns the first element of the sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty or if no element passes the test specified
        /// by predicate; otherwise, the first element in source that passes the test specified
        /// by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().FirstOrDefault(predicate);
        }
        ///<summary>
        /// Returns the first element of the sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty or if no element passes the test specified
        /// by predicate; otherwise, the first element in source that passes the test specified
        /// by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().FirstOrDefault(predicate);
        }
        ///<summary>
        /// Returns the first element of the sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty or if no element passes the test specified
        /// by predicate; otherwise, the first element in source that passes the test specified
        /// by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().FirstOrDefault(predicate);
        }
        ///<summary>
        /// Returns the first element of the sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty or if no element passes the test specified
        /// by predicate; otherwise, the first element in source that passes the test specified
        /// by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().FirstOrDefault(predicate);
        }
        ///<summary>
        /// Returns the first element of the sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty or if no element passes the test specified
        /// by predicate; otherwise, the first element in source that passes the test specified
        /// by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().FirstOrDefault(predicate);
        }
        ///<summary>
        /// Returns the first element of the sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if source is empty or if no element passes the test specified
        /// by predicate; otherwise, the first element in source that passes the test specified
        /// by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource FirstOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().FirstOrDefault(predicate);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Intersect(second, comparer);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Intersect(second, comparer);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Intersect(second, comparer);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Intersect(second, comparer);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Intersect(second, comparer);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Intersect(second, comparer);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the specified System.Collections.Generic.IEqualityComparer`1
        /// to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Intersect(second, comparer);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the default equality
        /// comparer to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Intersect(second);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the default equality
        /// comparer to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Intersect(second);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the default equality
        /// comparer to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Intersect(second);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the default equality
        /// comparer to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Intersect(second);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the default equality
        /// comparer to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Intersect(second);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the default equality
        /// comparer to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Intersect(second);
        }
        ///<summary>
        /// Produces the set intersection of two sequences by using the default equality
        /// comparer to compare values.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements that also appear in second will be returned. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements that also appear in the first sequence will be returned. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// A sequence that contains the elements that form the set intersection of two sequences.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Intersect<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Intersect(second);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The last element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Last<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Last(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The last element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Last(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The last element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Last(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The last element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Last(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The last element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Last(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The last element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Last(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a specified condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The last element in the sequence that passes the test in the specified predicate
        /// function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Last(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value at the last position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource Last<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Last();
        }
        ///<summary>
        /// Returns the last element of a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value at the last position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Last();
        }
        ///<summary>
        /// Returns the last element of a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value at the last position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Last();
        }
        ///<summary>
        /// Returns the last element of a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value at the last position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Last();
        }
        ///<summary>
        /// Returns the last element of a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value at the last position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Last();
        }
        ///<summary>
        /// Returns the last element of a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value at the last position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Last();
        }
        ///<summary>
        /// Returns the last element of a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value at the last position in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The source sequence is empty. </exception>
        public static TSource Last<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Last();
        }
        ///<summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the source sequence is empty; otherwise, the last element
        /// in the System.ValueTuple.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource LastOrDefault<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().LastOrDefault();
        }
        ///<summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the source sequence is empty; otherwise, the last element
        /// in the System.ValueTuple.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().LastOrDefault();
        }
        ///<summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the source sequence is empty; otherwise, the last element
        /// in the System.ValueTuple.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LastOrDefault();
        }
        ///<summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the source sequence is empty; otherwise, the last element
        /// in the System.ValueTuple.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LastOrDefault();
        }
        ///<summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the source sequence is empty; otherwise, the last element
        /// in the System.ValueTuple.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LastOrDefault();
        }
        ///<summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the source sequence is empty; otherwise, the last element
        /// in the System.ValueTuple.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LastOrDefault();
        }
        ///<summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains
        /// no elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the last element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the source sequence is empty; otherwise, the last element
        /// in the System.ValueTuple.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LastOrDefault();
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the sequence is empty or if no elements pass the test in
        /// the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource LastOrDefault<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LastOrDefault(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the sequence is empty or if no elements pass the test in
        /// the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LastOrDefault(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the sequence is empty or if no elements pass the test in
        /// the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LastOrDefault(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the sequence is empty or if no elements pass the test in
        /// the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LastOrDefault(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the sequence is empty or if no elements pass the test in
        /// the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LastOrDefault(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the sequence is empty or if no elements pass the test in
        /// the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LastOrDefault(predicate);
        }
        ///<summary>
        /// Returns the last element of a sequence that satisfies a condition or a default
        /// value if no such element is found.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return an element from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// default(TSource) if the sequence is empty or if no elements pass the test in
        /// the predicate function; otherwise, the last element that passes the test in the
        /// predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource LastOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LastOrDefault(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents how many elements in a sequence satisfy
        /// a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of matching elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LongCount(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents how many elements in a sequence satisfy
        /// a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of matching elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LongCount(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents how many elements in a sequence satisfy
        /// a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of matching elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LongCount(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents how many elements in a sequence satisfy
        /// a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of matching elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LongCount(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents how many elements in a sequence satisfy
        /// a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of matching elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LongCount(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents how many elements in a sequence satisfy
        /// a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of matching elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LongCount(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents how many elements in a sequence satisfy
        /// a condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A number that represents how many elements in the sequence satisfy the condition
        /// in the predicate function.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.OverflowException" >The number of matching elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().LongCount(predicate);
        }
        ///<summary>
        /// Returns an System.Int64 that represents the total number of elements in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().LongCount();
        }
        ///<summary>
        /// Returns an System.Int64 that represents the total number of elements in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().LongCount();
        }
        ///<summary>
        /// Returns an System.Int64 that represents the total number of elements in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LongCount();
        }
        ///<summary>
        /// Returns an System.Int64 that represents the total number of elements in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LongCount();
        }
        ///<summary>
        /// Returns an System.Int64 that represents the total number of elements in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LongCount();
        }
        ///<summary>
        /// Returns an System.Int64 that represents the total number of elements in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LongCount();
        }
        ///<summary>
        /// Returns an System.Int64 that represents the total number of elements in a sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple that contains the elements to be counted. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The number of elements in the source sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The number of elements exceeds System.Int64.MaxValue. </exception>
        public static long LongCount<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().LongCount();
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max<TSource>(this (TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Max<TSource>(this (TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Max<TSource>(this (TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max<TSource>(this (TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Max<TSource>(this (TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Max<TSource>(this (TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max<TSource>(this (TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Max<TSource>(this (TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max<TSource>(this (TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Max<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Max<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Max<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Max<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max<TSource>(this (TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the maximum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Max(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min<TSource>(this (TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Min<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Min<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Min<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Min<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a generic sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Min<TSource>(this (TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int32 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static int? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min<TSource>(this (TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min<TSource>(this (TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Min<TSource>(this (TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Single value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min<TSource>(this (TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Min<TSource>(this (TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Double value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min<TSource>(this (TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Min<TSource>(this (TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Decimal value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static decimal? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Min<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Min<TSource>(this (TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Min<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Min<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Invokes a transform function on each element of a sequence and returns the minimum
        /// nullable System.Int64 value.
        ///</summary>
        ///<param name="source" >A sequence of values to determine the minimum value of. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static long? Min<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Min(selector);
        }
        ///<summary>
        /// Filters the elements of an System.ValueTuple based on a specified
        /// type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple whose elements to filter. </param>
        ///<typeparam name="TResult" >The type to filter the elements of the sequence on. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence of type TResult.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Prepend<TSource>(this System.ValueTuple<TSource> source,  TSource element)
        {
        	return source.ToEnumerable().Prepend(element);
        }
        ///<summary>
        /// Filters the elements of an System.ValueTuple based on a specified
        /// type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple whose elements to filter. </param>
        ///<typeparam name="TResult" >The type to filter the elements of the sequence on. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence of type TResult.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Prepend<TSource>(this (TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Prepend(element);
        }
        ///<summary>
        /// Filters the elements of an System.ValueTuple based on a specified
        /// type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple whose elements to filter. </param>
        ///<typeparam name="TResult" >The type to filter the elements of the sequence on. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence of type TResult.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Prepend<TSource>(this (TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Prepend(element);
        }
        ///<summary>
        /// Filters the elements of an System.ValueTuple based on a specified
        /// type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple whose elements to filter. </param>
        ///<typeparam name="TResult" >The type to filter the elements of the sequence on. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence of type TResult.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Prepend<TSource>(this (TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Prepend(element);
        }
        ///<summary>
        /// Filters the elements of an System.ValueTuple based on a specified
        /// type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple whose elements to filter. </param>
        ///<typeparam name="TResult" >The type to filter the elements of the sequence on. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence of type TResult.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Prepend<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Prepend(element);
        }
        ///<summary>
        /// Filters the elements of an System.ValueTuple based on a specified
        /// type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple whose elements to filter. </param>
        ///<typeparam name="TResult" >The type to filter the elements of the sequence on. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence of type TResult.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Prepend<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Prepend(element);
        }
        ///<summary>
        /// Filters the elements of an System.ValueTuple based on a specified
        /// type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple whose elements to filter. </param>
        ///<typeparam name="TResult" >The type to filter the elements of the sequence on. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence of type TResult.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Prepend<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  TSource element)
        {
        	return source.ToEnumerable().Prepend(element);
        }
        ///<summary>
        /// Inverts the order of the elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to reverse. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A sequence whose elements correspond to those of the input sequence in reverse
        /// order.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Reverse<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Reverse();
        }
        ///<summary>
        /// Inverts the order of the elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to reverse. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A sequence whose elements correspond to those of the input sequence in reverse
        /// order.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Reverse<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Reverse();
        }
        ///<summary>
        /// Inverts the order of the elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to reverse. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A sequence whose elements correspond to those of the input sequence in reverse
        /// order.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Reverse<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Reverse();
        }
        ///<summary>
        /// Inverts the order of the elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to reverse. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A sequence whose elements correspond to those of the input sequence in reverse
        /// order.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Reverse<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Reverse();
        }
        ///<summary>
        /// Inverts the order of the elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to reverse. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A sequence whose elements correspond to those of the input sequence in reverse
        /// order.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Reverse<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Reverse();
        }
        ///<summary>
        /// Inverts the order of the elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to reverse. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A sequence whose elements correspond to those of the input sequence in reverse
        /// order.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Reverse<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Reverse();
        }
        ///<summary>
        /// Inverts the order of the elements in a sequence.
        ///</summary>
        ///<param name="source" >A sequence of values to reverse. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A sequence whose elements correspond to those of the input sequence in reverse
        /// order.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Reverse<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Reverse();
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing their elements by using
        /// a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to use to compare elements. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements compare equal according to comparer; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().SequenceEqual(second, comparer);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing their elements by using
        /// a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to use to compare elements. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements compare equal according to comparer; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().SequenceEqual(second, comparer);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing their elements by using
        /// a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to use to compare elements. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements compare equal according to comparer; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().SequenceEqual(second, comparer);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing their elements by using
        /// a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to use to compare elements. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements compare equal according to comparer; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().SequenceEqual(second, comparer);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing their elements by using
        /// a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to use to compare elements. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements compare equal according to comparer; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().SequenceEqual(second, comparer);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing their elements by using
        /// a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to use to compare elements. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements compare equal according to comparer; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().SequenceEqual(second, comparer);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing their elements by using
        /// a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<param name="comparer" >An System.Collections.Generic.IEqualityComparer`1 to use to compare elements. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements compare equal according to comparer; otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().SequenceEqual(second, comparer);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing the elements by using
        /// the default equality comparer for their type.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements are equal according to the default equality comparer for their type;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().SequenceEqual(second);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing the elements by using
        /// the default equality comparer for their type.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements are equal according to the default equality comparer for their type;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().SequenceEqual(second);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing the elements by using
        /// the default equality comparer for their type.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements are equal according to the default equality comparer for their type;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().SequenceEqual(second);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing the elements by using
        /// the default equality comparer for their type.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements are equal according to the default equality comparer for their type;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().SequenceEqual(second);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing the elements by using
        /// the default equality comparer for their type.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements are equal according to the default equality comparer for their type;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().SequenceEqual(second);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing the elements by using
        /// the default equality comparer for their type.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements are equal according to the default equality comparer for their type;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().SequenceEqual(second);
        }
        ///<summary>
        /// Determines whether two sequences are equal by comparing the elements by using
        /// the default equality comparer for their type.
        ///</summary>
        ///<param name="first" >An System.ValueTuple to compare to second. </param>
        ///<param name="second" >An System.ValueTuple to compare to the first sequence. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// true if the two source sequences are of equal length and their corresponding
        /// elements are equal according to the default equality comparer for their type;
        /// otherwise, false.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static bool SequenceEqual<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().SequenceEqual(second);
        }
        ///<summary>
        /// Returns the only element of a sequence, and throws an exception if there is not
        /// exactly one element in the sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element.-or-The input sequence is empty. </exception>
        public static TSource Single<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().Single();
        }
        ///<summary>
        /// Returns the only element of a sequence, and throws an exception if there is not
        /// exactly one element in the sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element.-or-The input sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().Single();
        }
        ///<summary>
        /// Returns the only element of a sequence, and throws an exception if there is not
        /// exactly one element in the sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element.-or-The input sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Single();
        }
        ///<summary>
        /// Returns the only element of a sequence, and throws an exception if there is not
        /// exactly one element in the sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element.-or-The input sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Single();
        }
        ///<summary>
        /// Returns the only element of a sequence, and throws an exception if there is not
        /// exactly one element in the sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element.-or-The input sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Single();
        }
        ///<summary>
        /// Returns the only element of a sequence, and throws an exception if there is not
        /// exactly one element in the sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element.-or-The input sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Single();
        }
        ///<summary>
        /// Returns the only element of a sequence, and throws an exception if there is not
        /// exactly one element in the sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element.-or-The input sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().Single();
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies a condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-More than one element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Single<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Single(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies a condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-More than one element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Single(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies a condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-More than one element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Single(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies a condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-More than one element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Single(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies a condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-More than one element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Single(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies a condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-More than one element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Single(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies a condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        ///<exception cref="System.InvalidOperationException" >No element satisfies the condition in predicate.-or-More than one element satisfies the condition in predicate.-or-The source sequence is empty. </exception>
        public static TSource Single<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Single(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence, or default(TSource) if the sequence
        /// contains no elements.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element. </exception>
        public static TSource SingleOrDefault<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().SingleOrDefault();
        }
        ///<summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence, or default(TSource) if the sequence
        /// contains no elements.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().SingleOrDefault();
        }
        ///<summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence, or default(TSource) if the sequence
        /// contains no elements.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().SingleOrDefault();
        }
        ///<summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence, or default(TSource) if the sequence
        /// contains no elements.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().SingleOrDefault();
        }
        ///<summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence, or default(TSource) if the sequence
        /// contains no elements.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().SingleOrDefault();
        }
        ///<summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence, or default(TSource) if the sequence
        /// contains no elements.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().SingleOrDefault();
        }
        ///<summary>
        /// Returns the only element of a sequence, or a default value if the sequence is
        /// empty; this method throws an exception if there is more than one element in the
        /// sequence.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return the single element of. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence, or default(TSource) if the sequence
        /// contains no elements.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >The input sequence contains more than one element. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().SingleOrDefault();
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if
        /// more than one element satisfies the condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies the condition, or default(TSource)
        /// if no such element is found.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource SingleOrDefault<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SingleOrDefault(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if
        /// more than one element satisfies the condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies the condition, or default(TSource)
        /// if no such element is found.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SingleOrDefault(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if
        /// more than one element satisfies the condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies the condition, or default(TSource)
        /// if no such element is found.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SingleOrDefault(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if
        /// more than one element satisfies the condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies the condition, or default(TSource)
        /// if no such element is found.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SingleOrDefault(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if
        /// more than one element satisfies the condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies the condition, or default(TSource)
        /// if no such element is found.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SingleOrDefault(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if
        /// more than one element satisfies the condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies the condition, or default(TSource)
        /// if no such element is found.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SingleOrDefault(predicate);
        }
        ///<summary>
        /// Returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if
        /// more than one element satisfies the condition.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return a single element from. </param>
        ///<param name="predicate" >A function to test an element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The single element of the input sequence that satisfies the condition, or default(TSource)
        /// if no such element is found.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static TSource SingleOrDefault<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SingleOrDefault(predicate);
        }
        ///<summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining
        /// elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="count" >The number of elements to skip before returning the remaining elements. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements that occur
        /// after the specified index in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Skip<TSource>(this System.ValueTuple<TSource> source,  int count)
        {
        	return source.ToEnumerable().Skip(count);
        }
        ///<summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining
        /// elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="count" >The number of elements to skip before returning the remaining elements. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements that occur
        /// after the specified index in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Skip<TSource>(this (TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Skip(count);
        }
        ///<summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining
        /// elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="count" >The number of elements to skip before returning the remaining elements. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements that occur
        /// after the specified index in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Skip<TSource>(this (TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Skip(count);
        }
        ///<summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining
        /// elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="count" >The number of elements to skip before returning the remaining elements. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements that occur
        /// after the specified index in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Skip<TSource>(this (TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Skip(count);
        }
        ///<summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining
        /// elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="count" >The number of elements to skip before returning the remaining elements. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements that occur
        /// after the specified index in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Skip<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Skip(count);
        }
        ///<summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining
        /// elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="count" >The number of elements to skip before returning the remaining elements. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements that occur
        /// after the specified index in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Skip<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Skip(count);
        }
        ///<summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining
        /// elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="count" >The number of elements to skip before returning the remaining elements. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements that occur
        /// after the specified index in the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Skip<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Skip(count);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements. The element's index is used in the logic
        /// of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements. The element's index is used in the logic
        /// of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements. The element's index is used in the logic
        /// of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements. The element's index is used in the logic
        /// of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements. The element's index is used in the logic
        /// of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements. The element's index is used in the logic
        /// of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and
        /// then returns the remaining elements. The element's index is used in the logic
        /// of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence starting at the first element in the linear series that does not
        /// pass the test specified by predicate.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> SkipWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().SkipWhile(predicate);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum<TSource>(this (TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Decimal values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Sum<TSource>(this (TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Double values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Double values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Double values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double Sum<TSource>(this (TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Double values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Double values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Double values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Double values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Double values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static double Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, double> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Sum<TSource>(this (TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Single values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Single values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Single values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float Sum<TSource>(this (TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Single values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Single values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Single values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Single values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Single values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        public static float Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, float> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum<TSource>(this (TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int64 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum<TSource>(this (TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int64 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, long> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum<TSource>(this (TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of nullable System.Int32 values that are obtained
        /// by invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int?> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum<TSource>(this (TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Int32 values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Decimal values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Decimal values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum<TSource>(this (TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Decimal values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Decimal values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Decimal values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Decimal values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Computes the sum of the sequence of System.Decimal values that are obtained by
        /// invoking a transform function on each element of the input sequence.
        ///</summary>
        ///<param name="source" >A sequence of values that are used to calculate a sum. </param>
        ///<param name="selector" >A transform function to apply to each element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// The sum of the projected values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or selector is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, decimal> selector)
        {
        	return source.ToEnumerable().Sum(selector);
        }
        ///<summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="count" >The number of elements to return. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the specified number
        /// of elements from the start of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Take<TSource>(this System.ValueTuple<TSource> source,  int count)
        {
        	return source.ToEnumerable().Take(count);
        }
        ///<summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="count" >The number of elements to return. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the specified number
        /// of elements from the start of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Take<TSource>(this (TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Take(count);
        }
        ///<summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="count" >The number of elements to return. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the specified number
        /// of elements from the start of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Take<TSource>(this (TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Take(count);
        }
        ///<summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="count" >The number of elements to return. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the specified number
        /// of elements from the start of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Take<TSource>(this (TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Take(count);
        }
        ///<summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="count" >The number of elements to return. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the specified number
        /// of elements from the start of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Take<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Take(count);
        }
        ///<summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="count" >The number of elements to return. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the specified number
        /// of elements from the start of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Take<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Take(count);
        }
        ///<summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="count" >The number of elements to return. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the specified number
        /// of elements from the start of the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static IEnumerable<TSource> Take<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  int count)
        {
        	return source.ToEnumerable().Take(count);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        ///</summary>
        ///<param name="source" >A sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        ///</summary>
        ///<param name="source" >A sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        ///</summary>
        ///<param name="source" >A sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        ///</summary>
        ///<param name="source" >A sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        ///</summary>
        ///<param name="source" >A sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        ///</summary>
        ///<param name="source" >A sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        ///</summary>
        ///<param name="source" >A sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from the
        /// input sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true. The
        /// element's index is used in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true. The
        /// element's index is used in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true. The
        /// element's index is used in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true. The
        /// element's index is used in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true. The
        /// element's index is used in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true. The
        /// element's index is used in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Returns elements from a sequence as long as a specified condition is true. The
        /// element's index is used in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >The sequence to return elements from. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that occur before the element at which the test no longer passes.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> TakeWhile<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().TakeWhile(predicate);
        }
        ///<summary>
        /// Creates an array from a System.ValueTuple.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create an array from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An array that contains the elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource[] ToArray<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().ToArray();
        }
        ///<summary>
        /// Creates an array from a System.ValueTuple.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create an array from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An array that contains the elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource[] ToArray<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().ToArray();
        }
        ///<summary>
        /// Creates an array from a System.ValueTuple.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create an array from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An array that contains the elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource[] ToArray<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToArray();
        }
        ///<summary>
        /// Creates an array from a System.ValueTuple.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create an array from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An array that contains the elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource[] ToArray<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToArray();
        }
        ///<summary>
        /// Creates an array from a System.ValueTuple.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create an array from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An array that contains the elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource[] ToArray<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToArray();
        }
        ///<summary>
        /// Creates an array from a System.ValueTuple.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create an array from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An array that contains the elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource[] ToArray<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToArray();
        }
        ///<summary>
        /// Creates an array from a System.ValueTuple.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to create an array from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An array that contains the elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static TSource[] ToArray<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToArray();
        }
        ///<summary>
        /// Creates a System.Collections.Generic.List`1 from an System.ValueTuple.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Collections.Generic.List`1 from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.List`1 that contains elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static List<TSource> ToList<TSource>(this System.ValueTuple<TSource> source)
        {
        	return source.ToEnumerable().ToList();
        }
        ///<summary>
        /// Creates a System.Collections.Generic.List`1 from an System.ValueTuple.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Collections.Generic.List`1 from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.List`1 that contains elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static List<TSource> ToList<TSource>(this (TSource, TSource) source)
        {
        	return source.ToEnumerable().ToList();
        }
        ///<summary>
        /// Creates a System.Collections.Generic.List`1 from an System.ValueTuple.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Collections.Generic.List`1 from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.List`1 that contains elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static List<TSource> ToList<TSource>(this (TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToList();
        }
        ///<summary>
        /// Creates a System.Collections.Generic.List`1 from an System.ValueTuple.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Collections.Generic.List`1 from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.List`1 that contains elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static List<TSource> ToList<TSource>(this (TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToList();
        }
        ///<summary>
        /// Creates a System.Collections.Generic.List`1 from an System.ValueTuple.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Collections.Generic.List`1 from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.List`1 that contains elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static List<TSource> ToList<TSource>(this (TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToList();
        }
        ///<summary>
        /// Creates a System.Collections.Generic.List`1 from an System.ValueTuple.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Collections.Generic.List`1 from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.List`1 that contains elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static List<TSource> ToList<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToList();
        }
        ///<summary>
        /// Creates a System.Collections.Generic.List`1 from an System.ValueTuple.
        ///</summary>
        ///<param name="source" >The System.ValueTuple to create a System.Collections.Generic.List`1 from. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// A System.Collections.Generic.List`1 that contains elements from the input sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static List<TSource> ToList<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source)
        {
        	return source.ToEnumerable().ToList();
        }
        ///<summary>
        /// Produces the set union of two sequences by using the default equality comparer.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Union(second);
        }
        ///<summary>
        /// Produces the set union of two sequences by using the default equality comparer.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Union(second);
        }
        ///<summary>
        /// Produces the set union of two sequences by using the default equality comparer.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Union(second);
        }
        ///<summary>
        /// Produces the set union of two sequences by using the default equality comparer.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Union(second);
        }
        ///<summary>
        /// Produces the set union of two sequences by using the default equality comparer.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Union(second);
        }
        ///<summary>
        /// Produces the set union of two sequences by using the default equality comparer.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Union(second);
        }
        ///<summary>
        /// Produces the set union of two sequences by using the default equality comparer.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second)
        {
        	return first.ToEnumerable().Union(second);
        }
        ///<summary>
        /// Produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<param name="comparer" >The System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this System.ValueTuple<TSource> first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Union(second, comparer);
        }
        ///<summary>
        /// Produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<param name="comparer" >The System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Union(second, comparer);
        }
        ///<summary>
        /// Produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<param name="comparer" >The System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Union(second, comparer);
        }
        ///<summary>
        /// Produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<param name="comparer" >The System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Union(second, comparer);
        }
        ///<summary>
        /// Produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<param name="comparer" >The System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Union(second, comparer);
        }
        ///<summary>
        /// Produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<param name="comparer" >The System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Union(second, comparer);
        }
        ///<summary>
        /// Produces the set union of two sequences by using a specified System.Collections.Generic.IEqualityComparer`1.
        ///</summary>
        ///<param name="first" >An System.ValueTuple whose distinct elements form the first set for the union. </param>
        ///<param name="second" >An System.ValueTuple whose distinct elements form the second set for the union. </param>
        ///<param name="comparer" >The System.Collections.Generic.IEqualityComparer`1 to compare values. </param>
        ///<typeparam name="TSource" >The type of the elements of the input sequences. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains the elements from both
        /// input sequences, excluding duplicates.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >first or second is null. </exception>
        public static IEnumerable<TSource> Union<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) first,  IEnumerable<TSource> second,  IEqualityComparer<TSource> comparer)
        {
        	return first.ToEnumerable().Union(second, comparer);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used
        /// in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used
        /// in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used
        /// in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used
        /// in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used
        /// in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used
        /// in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate. Each element's index is used
        /// in the logic of the predicate function.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each source element for a condition; the second parameter of the function represents the index of the source element. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, int, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this System.ValueTuple<TSource> source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        ///<summary>
        /// Filters a sequence of values based on a predicate.
        ///</summary>
        ///<param name="source" >An System.ValueTuple to filter. </param>
        ///<param name="predicate" >A function to test each element for a condition. </param>
        ///<typeparam name="TSource" >The type of the elements of source. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains elements from the input
        /// sequence that satisfy the condition.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source or predicate is null. </exception>
        public static IEnumerable<TSource> Where<TSource>(this (TSource, TSource, TSource, TSource, TSource, TSource, TSource) source,  Func<TSource, bool> predicate)
        {
        	return source.ToEnumerable().Where(predicate);
        }
        #endregion generated code block
    }
}
