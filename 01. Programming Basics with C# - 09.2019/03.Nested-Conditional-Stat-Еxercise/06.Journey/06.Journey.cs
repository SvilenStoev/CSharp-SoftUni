using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine($"Somewhere in Bulgaria");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {(budget * 0.3):f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {(budget * 0.7):f2}");
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine($"Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {(budget * 0.4):f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {(budget * 0.8):f2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine($"Somewhere in Europe");
                if (season == "summer")
                {
                    Console.WriteLine($"Hotel - {(budget * 0.9):f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {(budget * 0.9):f2}");
                }
            }

        }
    }
}
