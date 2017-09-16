using System;
using Xunit;

namespace HackerRank.Algorithms.Implementation.AppleAndOrange
{
    public class AppleAndOrangeTests
    {
        [Fact]
        public void Main()
        {
            int s = 7, t = 11;
            int appleTree = 5, orangeTree = 15;

            var apples = new int[] { -2, 2, 1 };
            var oranges = new int[] { 5, -6 };

            var expectedApplesCount = 1;
            var expectedOrangesCount = 1;

            int applesCount, orangesCount;
            AppleAndOrange.CountItensInArea
            (
                s, t,
                appleTree, orangeTree,
                apples, oranges, out applesCount, out orangesCount
            );

            Assert.Equal(expectedApplesCount, applesCount);
            Assert.Equal(expectedOrangesCount, orangesCount);
        }

    }
}
