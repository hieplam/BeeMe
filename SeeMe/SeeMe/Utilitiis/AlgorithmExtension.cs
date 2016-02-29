using System;
using System.Collections.Generic;

namespace SeeMe.Utilitiis
{
    public static class AlgorithmExtension
    {
        private static readonly Random Random = new Random();

        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = Random.Next(n + 1);

                list.Swap(k,n);
            }

            return list;
        }

        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}