using System;
using Xunit;

namespace HackerRank.Algorithms.Implementation.Kangaroo
{
    public class KangarooTests
    {
        [Fact]
        public void Collision()
        {
            int x1 = 0, v1 = 3;
            int x2 = 4, v2 = 2;

            var result = Kangaroo.CheckCollision(x1, v1, x2, v2);

            Assert.True(result);
        }

        [Fact]
        public void NoCollision()
        {
            int x1 = 0, v1 = 2;
            int x2 = 5, v2 = 3;

            var result = Kangaroo.CheckCollision(x1, v1, x2, v2);

            Assert.False(result);
        }
    }
}
