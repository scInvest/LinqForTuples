using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LinqForTuplesExtensionsStandard;

namespace LinqForTuplesExtensionsStandard.GeneratedCode
{
    public static class NumericNonGeneric
    {
        #region generated code block

        ///<summary>
        /// Computes the average of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this System.ValueTuple<int> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (int, int) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (int, int, int) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (int, int, int, int) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (int, int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this System.ValueTuple<long?> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (long?, long?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (long?, long?, long?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (long?, long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average(this System.ValueTuple<float> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average(this (float, float) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average(this (float, float, float) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average(this (float, float, float, float) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average(this (float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average(this (float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Average(this (float, float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Average(this System.ValueTuple<float?> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Average(this (float?, float?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Average(this (float?, float?, float?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Average(this (float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Average(this (float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Average(this (float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Average(this (float?, float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this System.ValueTuple<double> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (double, double) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (double, double, double) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (double, double, double, double) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (double, double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this System.ValueTuple<long> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (long, long) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (long, long, long) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (long, long, long, long) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Average(this (long, long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this System.ValueTuple<int?> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (int?, int?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (int?, int?, int?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Int64.MaxValue. </exception>
        public static double? Average(this (int?, int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Average(this System.ValueTuple<double?> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Average(this (double?, double?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Average(this (double?, double?, double?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Average(this (double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Average(this (double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Average(this (double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Average(this (double?, double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Average(this System.ValueTuple<decimal> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Average(this (decimal, decimal) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Average(this (decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Average(this (decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Average(this (decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Average(this (decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Average(this (decimal, decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average(this System.ValueTuple<decimal?> source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average(this (decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average(this (decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average(this (decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average(this (decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Computes the average of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the average of. </param>
        ///<returns>
        /// The average of the sequence of values, or null if the source sequence is empty
        /// or contains only values that are null.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum of the elements in the sequence is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Average(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Average();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Max(this System.ValueTuple<int?> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Max(this (int?, int?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Max(this (int?, int?, int?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Max(this (int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Max(this (int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Max(this (int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Max(this (int?, int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Max(this System.ValueTuple<long?> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Max(this (long?, long?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Max(this (long?, long?, long?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Max(this (long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Max(this (long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Max(this (long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Max(this (long?, long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max(this System.ValueTuple<long> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max(this (long, long) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max(this (long, long, long) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max(this (long, long, long, long) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max(this (long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max(this (long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Max(this (long, long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max(this System.ValueTuple<int> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max(this (int, int) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max(this (int, int, int) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max(this (int, int, int, int) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max(this (int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max(this (int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Max(this (int, int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max(this System.ValueTuple<double> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max(this (double, double) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max(this (double, double, double) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max(this (double, double, double, double) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max(this (double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max(this (double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Max(this (double, double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Max(this System.ValueTuple<double?> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Max(this (double?, double?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Max(this (double?, double?, double?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Max(this (double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Max(this (double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Max(this (double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Max(this (double?, double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Max(this System.ValueTuple<decimal?> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Max(this (decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Max(this (decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Max(this (decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Max(this (decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Max(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Max(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max(this System.ValueTuple<decimal> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max(this (decimal, decimal) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max(this (decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max(this (decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max(this (decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max(this (decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Max(this (decimal, decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Max(this System.ValueTuple<float?> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Max(this (float?, float?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Max(this (float?, float?, float?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Max(this (float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Max(this (float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Max(this (float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Max(this (float?, float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max(this System.ValueTuple<float> source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max(this (float, float) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max(this (float, float, float) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max(this (float, float, float, float) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max(this (float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max(this (float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the maximum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the maximum value of. </param>
        ///<returns>
        /// The maximum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Max(this (float, float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Max();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Min(this System.ValueTuple<double?> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Min(this (double?, double?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Min(this (double?, double?, double?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Min(this (double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Min(this (double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Min(this (double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Double> in C# or Nullable(Of Double) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Min(this (double?, double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Min(this System.ValueTuple<decimal?> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Min(this (decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Min(this (decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Min(this (decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Min(this (decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Min(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Decimal> in C# or Nullable(Of Decimal) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static decimal? Min(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min(this System.ValueTuple<decimal> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min(this (decimal, decimal) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min(this (decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min(this (decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min(this (decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min(this (decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static decimal Min(this (decimal, decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Min(this System.ValueTuple<float?> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Min(this (float?, float?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Min(this (float?, float?, float?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Min(this (float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Min(this (float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Min(this (float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Single> in C# or Nullable(Of Single) in Visual Basic
        /// that corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Min(this (float?, float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min(this System.ValueTuple<float> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min(this (float, float) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min(this (float, float, float) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min(this (float, float, float, float) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min(this (float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min(this (float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static float Min(this (float, float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Min(this System.ValueTuple<long?> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Min(this (long?, long?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Min(this (long?, long?, long?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Min(this (long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Min(this (long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Min(this (long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int64> in C# or Nullable(Of Int64) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static long? Min(this (long?, long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min(this System.ValueTuple<int> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min(this (int, int) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min(this (int, int, int) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min(this (int, int, int, int) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min(this (int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min(this (int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static int Min(this (int, int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min(this System.ValueTuple<double> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min(this (double, double) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min(this (double, double, double) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min(this (double, double, double, double) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min(this (double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min(this (double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static double Min(this (double, double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min(this System.ValueTuple<long> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min(this (long, long) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min(this (long, long, long) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min(this (long, long, long, long) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min(this (long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min(this (long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to determine the minimum value of. </param>
        ///<returns>
        /// The minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.InvalidOperationException" >source contains no elements. </exception>
        public static long Min(this (long, long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Min(this System.ValueTuple<int?> source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Min(this (int?, int?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Min(this (int?, int?, int?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Min(this (int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Min(this (int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Min(this (int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Returns the minimum value in a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to determine the minimum value of. </param>
        ///<returns>
        /// A value of type Nullable<Int32> in C# or Nullable(Of Int32) in Visual Basic that
        /// corresponds to the minimum value in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static int? Min(this (int?, int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Min();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum(this System.ValueTuple<int> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum(this (int, int) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum(this (int, int, int) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum(this (int, int, int, int) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum(this (int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum(this (int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int Sum(this (int, int, int, int, int, int, int) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum(this System.ValueTuple<long> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum(this (long, long) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum(this (long, long, long) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum(this (long, long, long, long) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum(this (long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum(this (long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long Sum(this (long, long, long, long, long, long, long) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum(this System.ValueTuple<decimal?> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum(this (decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum(this (decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum(this (decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum(this (decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal? Sum(this (decimal?, decimal?, decimal?, decimal?, decimal?, decimal?, decimal?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum(this System.ValueTuple<decimal> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum(this (decimal, decimal) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum(this (decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum(this (decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum(this (decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum(this (decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Decimal values.
        ///</summary>
        ///<param name="source" >A sequence of System.Decimal values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Decimal.MaxValue. </exception>
        public static decimal Sum(this (decimal, decimal, decimal, decimal, decimal, decimal, decimal) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Sum(this System.ValueTuple<double?> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Sum(this (double?, double?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Sum(this (double?, double?, double?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Sum(this (double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Sum(this (double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Sum(this (double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double? Sum(this (double?, double?, double?, double?, double?, double?, double?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double Sum(this System.ValueTuple<double> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double Sum(this (double, double) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double Sum(this (double, double, double) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double Sum(this (double, double, double, double) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double Sum(this (double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double Sum(this (double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Double values.
        ///</summary>
        ///<param name="source" >A sequence of System.Double values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static double Sum(this (double, double, double, double, double, double, double) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Sum(this System.ValueTuple<float?> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Sum(this (float?, float?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Sum(this (float?, float?, float?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Sum(this (float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Sum(this (float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Sum(this (float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float? Sum(this (float?, float?, float?, float?, float?, float?, float?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float Sum(this System.ValueTuple<float> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float Sum(this (float, float) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float Sum(this (float, float, float) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float Sum(this (float, float, float, float) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float Sum(this (float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float Sum(this (float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of System.Single values.
        ///</summary>
        ///<param name="source" >A sequence of System.Single values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        public static float Sum(this (float, float, float, float, float, float, float) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum(this System.ValueTuple<long?> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum(this (long?, long?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum(this (long?, long?, long?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum(this (long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum(this (long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum(this (long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int64 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int64 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int64.MaxValue. </exception>
        public static long? Sum(this (long?, long?, long?, long?, long?, long?, long?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum(this System.ValueTuple<int?> source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum(this (int?, int?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum(this (int?, int?, int?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum(this (int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum(this (int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum(this (int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        ///<summary>
        /// Computes the sum of a sequence of nullable System.Int32 values.
        ///</summary>
        ///<param name="source" >A sequence of nullable System.Int32 values to calculate the sum of. </param>
        ///<returns>
        /// The sum of the values in the sequence.
        ///</returns>
        ///<exception cref="System.ArgumentNullException" >source is null. </exception>
        ///<exception cref="System.OverflowException" >The sum is larger than System.Int32.MaxValue. </exception>
        public static int? Sum(this (int?, int?, int?, int?, int?, int?, int?) source)
        {
        	return source.ToEnumerable().Sum();
        }
        #endregion generated code block
    }
}
