using System;
namespace HackerRank.Algorithms.Implementation.Kangaroo
{
    public class Kangaroo
    {
        public static bool CheckCollision(int x1, int v1, int x2, int v2)
        {
            return (v1 > v2 && ((x2 - x1) % (v1 - v2) == 0));
        }
    }
}
