using System;
using System.Collections.Generic;

namespace SeeMe.Utilitiis
{
    public static class ListExtension
    {
        private static readonly Random Random = new Random();

        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            var count = list.Count;
            while (count > 1)
            {
                count--;
                var randomIndex = Random.Next(count + 1);

                list.SwapIndex(randomIndex, count);
            }

            return list;
        }

        public static void SwapIndex<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}