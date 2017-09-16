using System;
using System.Linq;
using Xunit;

namespace HackerRank.Algorithms.Implementation.GradingStudents
{
    public class GradingStudentsTests
    {
		[Fact]
		public void Main()
		{
			var test = new int[] { 73, 67, 38, 33 };
            var expected = new int[] { 75, 67, 40, 33 };

            var result = GradingStudents.RoundGrade(test);

            Assert.True(Enumerable.SequenceEqual(expected, result));
		}
    }
}
