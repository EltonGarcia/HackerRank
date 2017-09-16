using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup.Staircase
{
    public class Staircase
    {
        public static Action<string> Printer;

        public static void PrintStaircase(int size)
        {
            for (int i = 0; i < size; i++)
            {
    			char space = ' ';
    			char symbol = '#';
                int lastIndex = size - 1;

    			var array = new char[size];
                for (int j = lastIndex; j >= 0; j--)
                {
                    array[j] = lastIndex - j <= i ? symbol : space;
                }

                Printer(new string(array));
            }
        }

        //Easy approach with bad memory usage performance
		public static void PrintStaircase_Easy(int size)
		{
			for (int i = 0; i < size; i++)
			{
				char space = ' ';
				char symbol = '#';

                Printer(new string(symbol, i + 1).PadLeft(size, space));
			}
		}
    }
}
