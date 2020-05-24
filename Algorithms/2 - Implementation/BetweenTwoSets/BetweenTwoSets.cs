using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation.BetweenTwoSets
{
    public class BetweenTwoSets
    {
        private int GCD(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a >= b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        private int LCM(int a, int b)
        {
            return (a * GCD(a, b)) * b;
        }

        public static int CountElementsBetweenSets(int[] a, int[] b)
        {
            var min = a.Max();
            var max = b.Min();
            var count = 0;

            var i = min;
            while (i <= max)
            {
                var factorOfA = true;
                for (int j = 0; j < a.Length && factorOfA; j++)
                {
                    factorOfA &= i % a[j] == 0;
                }
                if (factorOfA)
                {
                    var factorOfB = true;
                    for (int k = 0; k < b.Length && factorOfB; k++)
                    {
                        factorOfB &= b[k] % i == 0;
                    }
                    if (factorOfB)
                    {
                        count++;
                    }
                }

                i++;
            }

            return count;
        }
    }
}
