using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.AVeryBigSum
{
    public class AVeryBigSumTests
    {
		[Fact]
		public void Main()
		{
            var test = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

			var expected = 5000000015;
            var result = AVeryBigSum.BigSum(test);

			Assert.Equal(expected, result);
		}
    }
}
