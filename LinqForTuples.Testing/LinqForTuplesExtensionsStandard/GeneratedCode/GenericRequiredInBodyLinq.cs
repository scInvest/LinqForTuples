
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqForTuplesExtensionsStandard;

namespace LinqForTuplesExtensionsStandard.GeneratedCode
{
    public static class GenericRequiredInBodyLinqDeclaration
    {
        #region generated code block

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
        public static IEnumerable<TResult> OfType<TResult, T1, T2>(this (T1, T2) source)
        {
        	return source.ToEnumerableAsObject().OfType<TResult>();
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
        public static IEnumerable<TResult> OfType<TResult, T1, T2, T3>(this (T1, T2, T3) source)
        {
        	return source.ToEnumerableAsObject().OfType<TResult>();
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
        public static IEnumerable<TResult> OfType<TResult, T1, T2, T3, T4>(this (T1, T2, T3, T4) source)
        {
        	return source.ToEnumerableAsObject().OfType<TResult>();
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
        public static IEnumerable<TResult> OfType<TResult, T1, T2, T3, T4, T5>(this (T1, T2, T3, T4, T5) source)
        {
        	return source.ToEnumerableAsObject().OfType<TResult>();
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
        public static IEnumerable<TResult> OfType<TResult, T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4, T5, T6) source)
        {
        	return source.ToEnumerableAsObject().OfType<TResult>();
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
        public static IEnumerable<TResult> OfType<TResult, T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6, T7) source)
        {
        	return source.ToEnumerableAsObject().OfType<TResult>();
        }
        ///<summary>
        /// Casts the elements of an System.ValueTuple to the specified type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple that contains the elements to be cast to type TResult. </param>
        ///<typeparam name="TResult" >The type to cast the elements of source to. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains each element of the
        /// source sequence cast to the specified type.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidCastException" >An element in the sequence cannot be cast to type TResult. </exception>
        public static IEnumerable<TResult> Cast<TResult, T1, T2>(this (T1, T2) source)
        {
        	return source.ToEnumerableAsObject().Cast<TResult>();
        }
        ///<summary>
        /// Casts the elements of an System.ValueTuple to the specified type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple that contains the elements to be cast to type TResult. </param>
        ///<typeparam name="TResult" >The type to cast the elements of source to. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains each element of the
        /// source sequence cast to the specified type.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidCastException" >An element in the sequence cannot be cast to type TResult. </exception>
        public static IEnumerable<TResult> Cast<TResult, T1, T2, T3>(this (T1, T2, T3) source)
        {
        	return source.ToEnumerableAsObject().Cast<TResult>();
        }
        ///<summary>
        /// Casts the elements of an System.ValueTuple to the specified type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple that contains the elements to be cast to type TResult. </param>
        ///<typeparam name="TResult" >The type to cast the elements of source to. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains each element of the
        /// source sequence cast to the specified type.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidCastException" >An element in the sequence cannot be cast to type TResult. </exception>
        public static IEnumerable<TResult> Cast<TResult, T1, T2, T3, T4>(this (T1, T2, T3, T4) source)
        {
        	return source.ToEnumerableAsObject().Cast<TResult>();
        }
        ///<summary>
        /// Casts the elements of an System.ValueTuple to the specified type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple that contains the elements to be cast to type TResult. </param>
        ///<typeparam name="TResult" >The type to cast the elements of source to. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains each element of the
        /// source sequence cast to the specified type.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidCastException" >An element in the sequence cannot be cast to type TResult. </exception>
        public static IEnumerable<TResult> Cast<TResult, T1, T2, T3, T4, T5>(this (T1, T2, T3, T4, T5) source)
        {
        	return source.ToEnumerableAsObject().Cast<TResult>();
        }
        ///<summary>
        /// Casts the elements of an System.ValueTuple to the specified type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple that contains the elements to be cast to type TResult. </param>
        ///<typeparam name="TResult" >The type to cast the elements of source to. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains each element of the
        /// source sequence cast to the specified type.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidCastException" >An element in the sequence cannot be cast to type TResult. </exception>
        public static IEnumerable<TResult> Cast<TResult, T1, T2, T3, T4, T5, T6>(this (T1, T2, T3, T4, T5, T6) source)
        {
        	return source.ToEnumerableAsObject().Cast<TResult>();
        }
        ///<summary>
        /// Casts the elements of an System.ValueTuple to the specified type.
        ///</summary>
        ///<param name="source" >The System.ValueTuple that contains the elements to be cast to type TResult. </param>
        ///<typeparam name="TResult" >The type to cast the elements of source to. </typeparam>
        ///<returns>
        /// An System.ValueTuple that contains each element of the
        /// source sequence cast to the specified type.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidCastException" >An element in the sequence cannot be cast to type TResult. </exception>
        public static IEnumerable<TResult> Cast<TResult, T1, T2, T3, T4, T5, T6, T7>(this (T1, T2, T3, T4, T5, T6, T7) source)
        {
        	return source.ToEnumerableAsObject().Cast<TResult>();
        }
        #endregion generated code block
    }
}

