using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DayOfWeek dayOfWeek =today.DayOfWeek;

            Console.WriteLine(WeekDayName((Week)dayOfWeek));
        }
        static string  WeekDayName(Week day) 
        {
            return day.ToString();
        }
        public enum Week
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }
            

    }
}
