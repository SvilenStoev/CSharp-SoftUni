using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първата задава за вложени речници. Особена е може да я погледна пак!
            //lidl, juice, 2.30
            //fantastico, apple, 1.20
            //kaufland, banana, 1.10
            //fantastico, grape, 2.20
            //Revision

            var productShops = new SortedDictionary<string, Dictionary<string, double>>();

            string input;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] inputData = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shopName = inputData[0];
                string productName = inputData[1];
                double productPrice = double.Parse(inputData[2]);

                if (!productShops.ContainsKey(shopName))
                {
                    productShops[shopName] = new Dictionary<string, double>();
                }

                if (!productShops[shopName].ContainsKey(productName))
                {
                    productShops[shopName].Add(productName, 0);
                }

                productShops[shopName][productName] = productPrice;
            }

            foreach (var (shopName, products) in productShops)
            {
                Console.WriteLine($"{shopName}->");

                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }

        }
    }
}
