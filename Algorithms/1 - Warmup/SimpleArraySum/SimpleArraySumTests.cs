using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.SimpleArraySum
{
    public class SimpleArraySumTests
    {
		[Fact]
		public void Main()
		{
            var test = new int[]{1, 2, 3, 4, 10, 11};

            var expected = 31;
            var result = SimpleArraySum.ArraySum(test);

            Assert.Equal(expected, result);
		}
    }
}
