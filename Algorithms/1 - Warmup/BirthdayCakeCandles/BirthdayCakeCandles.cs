using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup.BirthdayCakeCandles
{
    public class BirthdayCakeCandles
    {
        public static int CheckBirthdayCakeCandles(int[] array)
        {
            int? height = null;
            var count = 0;
            foreach (var item in array)
            {
                if (!height.HasValue || item > height.Value)
                {
                    height = item;
                    count = 1;
                }
                else if (height.Value == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
