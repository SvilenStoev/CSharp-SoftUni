using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsString = Console.ReadLine();

            DateTime dateTime = DateTime.ParseExact(dateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}
