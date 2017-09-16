using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.BirthdayCakeCandles
{
    public class BirthdayCakeCandlesTests
    {
		[Fact]
		public void Main()
		{
			var test = new int[] { 3, 2, 1, 3 };
			var expected = 2;

            var result = BirthdayCakeCandles.CheckBirthdayCakeCandles(test);

            Assert.Equal(expected, result);
		}
    }
}
