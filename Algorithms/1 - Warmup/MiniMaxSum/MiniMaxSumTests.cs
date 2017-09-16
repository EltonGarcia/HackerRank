using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.MiniMaxSum
{
    public class MiniMaxSumTests
    {
		[Fact]
		public void Main()
		{
			var test = new UInt64[] { 1, 2, 3, 4, 5 };

            UInt64 minExpected = 10;
            UInt64 maxExpected = 14;

			UInt64 min, max;
			MiniMaxSum.CalculateMiniMaxSum(test, out min, out max);

            Assert.Equal(minExpected, min);
            Assert.Equal(maxExpected, max);
		}
    }
}
