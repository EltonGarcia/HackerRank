using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.PlusMinus
{
    public class PlusMinusTests
    {
		[Fact]
		public void Main()
		{
			var test = new int[] { -4, 3, -9, 0, 4, 1 };

            var positiveExpected = 0.500000M;
            var negativesExpected = 0.333333M;
            var zerosExpected = 0.166667M;

            decimal positive, negatives, zeros;
            PlusMinus.CalculateFractions(test, out positive, out negatives, out zeros);

            Assert.Equal(positiveExpected, positive);
            Assert.Equal(negativesExpected, negatives);
            Assert.Equal(zerosExpected, zeros);
		}
    }
}
