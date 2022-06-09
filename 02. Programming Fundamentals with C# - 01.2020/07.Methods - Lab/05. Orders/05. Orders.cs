using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int productCount = int.Parse(Console.ReadLine());

            PriceCalculation(product, productCount);
        }

        static void PriceCalculation(string product, int productCount)
        {
            double totalPrice = 0.0;

            switch (product)
            {
                case "coffee": totalPrice = productCount * 1.5; break;
                case "water": totalPrice = productCount * 1.00; break;
                case "coke": totalPrice = productCount * 1.40; break;
                case "snacks": totalPrice = productCount * 2.00; break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}


