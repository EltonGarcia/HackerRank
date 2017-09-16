using System;
using Xunit;

namespace HackerRank.Algorithms.Warmup.Staircase
{
    public class StaircaseTests
    {
        [Fact]
        public void Main()
        {
            var results = new string[] 
            {
                "   #",
                "  ##",
                " ###",
                "####"
            };

            var callsCount = 0;
            Staircase.Printer = (obj) => 
            {
                Assert.Equal(results[callsCount], obj);
                callsCount++;
            };

            var size = 4;
            Staircase.PrintStaircase(size);
            Assert.Equal(size, callsCount);
        }

		[Fact]
		public void EasyApproach()
		{
			var results = new string[]
			{
				"   #",
				"  ##",
				" ###",
				"####"
			};

			var callsCount = 0;
			Staircase.Printer = (obj) =>
			{
				Assert.Equal(results[callsCount], obj);
				callsCount++;
			};

			var size = 4;
			Staircase.PrintStaircase_Easy(size);
			Assert.Equal(size, callsCount);
		}
    }
}
