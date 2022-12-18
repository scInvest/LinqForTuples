using System;

namespace LinqForTuples.DotNet6
{
        public static class TupleTwoParamsExtenstions
    {
        public static (T, T) Swipe<T>(this (T, T) tuple)
        {
            return tuple.Swipe(true);
        }
        public static (T, T) Swipe<T>(this (T, T) tuple, Func<T, T, bool> swipeCondition)
        {
            return tuple.Swipe(swipeCondition(tuple.Item1, tuple.Item2));
        }
        public static (T, T) Swipe<T>(this (T, T) tuple, Func<bool> swipeCondition)
        {
            return tuple.Swipe(swipeCondition());
        }
        public static (T, T) Swipe<T>(this (T, T) tuple, bool swipeCondition)
        {
            if (swipeCondition)
                return (tuple.Item2, tuple.Item1);
            return tuple;
        }

        public static T Pick<T>(this (T, T) tuple, bool pickFirst)
        {
            return pickFirst ? tuple.Item1 : tuple.Item2;
        }
        public static T Pick<T>(this (T, T) tuple, Func<T, T, bool> pickFirst)
        {
            return tuple.Pick(pickFirst(tuple.Item1, tuple.Item2));
        }
        public static T PickSecond<T>(this (T, T) tuple, bool pickCondition)
        {
            return !pickCondition ? tuple.Item1 : tuple.Item2;
        }
        public static T PickSecond<T>(this (T, T) tuple, Func<T, T, bool> pickCondition)
        {
            return tuple.Pick(!pickCondition(tuple.Item1, tuple.Item2));
        }
    }
}
