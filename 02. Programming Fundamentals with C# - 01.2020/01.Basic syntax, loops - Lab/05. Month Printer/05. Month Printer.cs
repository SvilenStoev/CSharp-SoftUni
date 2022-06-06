using System;

namespace _05._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string monthAsText = string.Empty;

            switch (month)
            {
                case 1: monthAsText = "January"; break;
                case 2: monthAsText = "February"; break;
                case 3: monthAsText = "March"; break;
                case 4: monthAsText = "April"; break;
                case 5: monthAsText = "May"; break;
                case 6: monthAsText = "June"; break;
                case 7: monthAsText = "July"; break;
                case 8: monthAsText = "August"; break;
                case 9: monthAsText = "September"; break;
                case 10: monthAsText = "October"; break;
                case 11: monthAsText = "November"; break;
                case 12: monthAsText = "December"; break;
                default: monthAsText = "Error!"; break;
            }

            Console.WriteLine(monthAsText);
        }
    }
}
