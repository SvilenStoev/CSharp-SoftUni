using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            uint years = centuries * 100u;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60m;

            Console.WriteLine($"{centuries:f0} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");

        }
    }
}
