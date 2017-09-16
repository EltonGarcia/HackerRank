using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Warmup.MiniMaxSum
{
    public class MiniMaxSum
    {
        public static void CalculateMiniMaxSum(UInt64[] array, out UInt64 min, out UInt64 max)
        {
            var ordered = array.OrderBy(o => o);

            min = Sum(ordered.Take(4));
            max = Sum(ordered.Reverse().Take(4));
        }

        static UInt64 Sum(IEnumerable<UInt64> itens)
        {
            UInt64 result = 0;
            foreach (var item in itens)
            {
                result += item;
            }
            return result;
        }
    }
}
