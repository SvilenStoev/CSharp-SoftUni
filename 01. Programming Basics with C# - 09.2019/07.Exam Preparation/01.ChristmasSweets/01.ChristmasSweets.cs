using System;

namespace _01.ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPricePerKg = double.Parse(Console.ReadLine());
            double muffinsPricePerKg = double.Parse(Console.ReadLine());
            double shtolenKg = double.Parse(Console.ReadLine());
            double candiesKg = double.Parse(Console.ReadLine());
            int biscuitsKg = int.Parse(Console.ReadLine());

            double sholenTotalPrice = baklavaPricePerKg * 1.6 * shtolenKg;
            double candiesTotalPrice = muffinsPricePerKg * 1.8 * candiesKg;
            double biscuitsTotalPrice = biscuitsKg * 7.50;

            double totalSum = sholenTotalPrice + candiesTotalPrice + biscuitsTotalPrice;

            Console.WriteLine($"{totalSum:f2}");

            //Problem 1: Типове, сметки, форматиране!!

        }
    }
}
