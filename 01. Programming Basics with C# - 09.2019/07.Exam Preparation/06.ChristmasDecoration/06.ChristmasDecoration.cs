using System;

namespace _06.ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string decoration = Console.ReadLine();
            int total = 0;

            while (decoration != "Stop")
            {
                int sum = 0;

                for (int i = 0; i < decoration.Length; i++)
                {
                    sum += decoration[i];
                }
                total += sum;

                if (budget >= total)
                {
                    Console.WriteLine($"Item successfully purchased!");
                }
                else if (budget < total)
                {
                    Console.WriteLine($"Not enough money!");
                    return;
                }

                decoration = Console.ReadLine();
            }

            Console.WriteLine($"Money left: {budget - total}");

        }
    }
}
