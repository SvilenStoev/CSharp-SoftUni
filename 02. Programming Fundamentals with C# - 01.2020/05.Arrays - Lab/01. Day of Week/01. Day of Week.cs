using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInput = int.Parse(Console.ReadLine());

            string[] days = new string[] {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            if (daysInput >= 1 && daysInput <= 7)
            {
                Console.WriteLine(days[daysInput - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }


        }
    }
}
