using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var productPrices = new Dictionary<string, double>();
            var productQuantities = new Dictionary<string, int>();

            string order;

            while ((order = Console.ReadLine()) != "buy")
            {
                string name = order.Split()[0];
                double price = double.Parse(order.Split()[1]);
                int quantity = int.Parse(order.Split()[2]);

                if (!productPrices.ContainsKey(name))
                {
                    productPrices[name] = 0;
                    productQuantities[name] = 0;
                }

                productPrices[name] = price;
                productQuantities[name] += quantity;
            }

            PrintOutput(productPrices, productQuantities);
        }

        static void PrintOutput(Dictionary<string, double> productPrices, Dictionary<string, int> productQuantities)
        {
            foreach (var kvp in productPrices)
            {
                string name = kvp.Key;
                double price = kvp.Value;
                int quantity = productQuantities[name];

                double totalPrice = price * quantity;

                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
}
