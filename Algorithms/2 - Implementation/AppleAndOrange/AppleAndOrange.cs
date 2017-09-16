using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation.AppleAndOrange
{
    public class AppleAndOrange
    {
        public static void CountItensInArea(int s, int t,
                                            int appleTree, int orangeTree,
                                            int[] apples, int[] oranges,
                                            out int applesCount, out int orangesCount)
        {
            Func<int, bool> inArea = pos => pos >= s && pos <= t;

            applesCount = apples.Select(pos => appleTree + pos).Count(inArea);
            orangesCount = oranges.Select(pos => orangeTree + pos).Count(inArea);
        }
    }
}