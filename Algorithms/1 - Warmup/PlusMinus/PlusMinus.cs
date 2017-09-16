using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup.PlusMinus
{
    public class PlusMinus
    {
        public static void CalculateFractions(int[] array, out decimal positive, out decimal negatives, out decimal zeros)
        {
            decimal positiveCount = 0;
            decimal negativesCount = 0;
            decimal zerosCount = 0;

            foreach (var item in array)
            {
                if (item == 0)
                {
                    zerosCount++;
                }
                else
                {
                    if (item > 0)
                    {
                        positiveCount++;
                    }
                    else
                    {
                        negativesCount++;
                    }
                }
            }

            positive = Math.Round(positiveCount / array.Length, 6);
            negatives = Math.Round(negativesCount / array.Length, 6);
            zeros = Math.Round(zerosCount / array.Length, 6);
        }
    }
}
