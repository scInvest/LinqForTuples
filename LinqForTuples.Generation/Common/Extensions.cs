using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public static class Extensions
    {
        public static string FirstToUpper(this string txt)
        {
            var first = txt[0];
            string firstToUpper = new string(new[] { first }).ToUpper();

            return firstToUpper + txt.Substring(1);
        }

        public static string[] SplitAllLines(this string txt)
        {
            return SplitOrKeep(txt, new[] { '\n', '\r' }).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
        }

        public static IEnumerable<string> SplitOrKeep(this string txt, params char[] separators)
        {
            if (txt.Any(x => separators.Contains(x)))
            {
                foreach (var item in txt.Split(separators))
                {
                    yield return item;
                }
            }
            else
            {
                yield return txt;
            }
        }
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> collectionToAdd)
        {
            foreach (var item in collectionToAdd)
            {
                collection.Add(item);
            }
        }

        public static string Slice(this string txt, int startIndex, int endIndex)
        {
            return txt.Substring(startIndex, endIndex - startIndex);
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection?.Any() != true;
        }

    }
}
