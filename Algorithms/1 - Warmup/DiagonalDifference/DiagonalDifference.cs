using System;
namespace HackerRank.Algorithms.Warmup.DiagonalDifference
{
    public class DiagonalDifference
    {
		public static int DiagonalSumDifference(int[][] matrix)
		{
			var primary = 0;
			var secondary = 0;

            var rank = matrix.Length - 1;
            for (int i = 0; i <= rank; i++)
			{
				primary += matrix[i][i];
                secondary += matrix[rank - i][i];
			}

			return Math.Abs(primary - secondary);
		}
    }
}
