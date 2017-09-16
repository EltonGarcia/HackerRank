using System;

namespace HackerRank.Algorithms.Implementation.GradingStudents
{
    public class GradingStudents
    {
        public static int[] RoundGrade(int[] grades)
        {
    		int factor = 5, acceptDifference = 3;

            for (int i = 0; i < grades.Length; i++)
            {
                var grade = grades[i];

                if (grade >= 38 && grade % factor >= acceptDifference)
				{
                    grades[i] = grade + (factor - (grade % factor));
				}
            }

            return grades;
        }
    }
}
