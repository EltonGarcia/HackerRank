using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.DiagonalDifference
{
    public class DiagonalDifferenceTests
    {
        [Fact]
        public void Main()
        {
            var test = new int[3][];
            test[0] = new int[] { 11, 2, 4 };
            test[1] = new int[] { 4, 5, 6 };
            test[2] = new int[] { 10, 8, -12 };

            var expected = 15;
            var result = DiagonalDifference.DiagonalSumDifference(test);

            Assert.Equal(expected, result);
        }
    }
}
