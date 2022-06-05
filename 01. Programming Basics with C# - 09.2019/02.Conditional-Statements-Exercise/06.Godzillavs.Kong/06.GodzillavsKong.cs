using System;

namespace _06.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());

            budget *= 0.9;
            double dressPriceTotal = employees * dressPrice;

            if (employees > 150)
            {
                dressPriceTotal *= 0.9;
            }

            budget -= dressPriceTotal;

            if (budget < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:f2} leva left.");
            }
                        
        }
    }
}
