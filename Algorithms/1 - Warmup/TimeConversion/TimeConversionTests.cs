using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.TimeConversion
{
    public class TimeConversionTests
    {
		[Fact]
		public void Main()
		{
            var test = "07:05:45PM";
			var expected = "19:05:45";

            var result = TimeConversion.Convert(test);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Midnight()
		{
			var test = "12:00:00AM";
			var expected = "00:00:00";

			var result = TimeConversion.Convert(test);

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Noon()
		{
			var test = "12:00:00PM";
			var expected = "12:00:00";

			var result = TimeConversion.Convert(test);

			Assert.Equal(expected, result);
		}
    }
}
