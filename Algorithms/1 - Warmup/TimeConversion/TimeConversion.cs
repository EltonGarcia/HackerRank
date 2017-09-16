using System;
namespace HackerRank.Algorithms.Warmup.TimeConversion
{
    public class TimeConversion
    {
        public static string Convert(string ampmTime)
        {
            var timeArray = ampmTime.Substring(0, ampmTime.Length - 2).Split(':');
            var hours = timeArray[0];
            var minutes = timeArray[1];
            var seconds = timeArray[2];

            var hour = int.Parse(hours);

            if (ampmTime.EndsWith("PM"))
            {
                if (hour != 12)
                {
                    hour = (hour + 12);
                }
            }
            else if (hour == 12)
            {
                hour = 0;
            }

            hours = hour.ToString().PadLeft(2, '0');

            return string.Join(":", hours, minutes, seconds);
        }
    }
}
