using System;
using Xunit;

namespace HackerRank.Algorithms.Implementation.BetweenTwoSets
{
    public class BetweenTwoSetsTests
    {
		[Fact]
		public void Main()
		{
			var A = new int[] { 2, 4 };
			var B = new int[] { 16, 32, 96};

			var expected = 3;
            var result = BetweenTwoSets.CountElementsBetweenSets(A, B);

			Assert.Equal(expected, result);
		}
    }
}
