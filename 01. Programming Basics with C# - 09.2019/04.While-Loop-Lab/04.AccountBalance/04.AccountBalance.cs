using System;

namespace _04.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int deposits = int.Parse(Console.ReadLine());

            int counter = 0;
            double amount = 0.00;
            double totalSum = 0.00;

            while (counter < deposits)
            {
                counter++;
                amount = double.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {amount:f2}");
                    totalSum += amount;
                }
            }

            Console.WriteLine($"Total: {totalSum:f2}");

        }
    }
}
