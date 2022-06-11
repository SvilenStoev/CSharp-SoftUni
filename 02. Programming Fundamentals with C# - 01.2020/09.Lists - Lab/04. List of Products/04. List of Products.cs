using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                productsList.Add(Console.ReadLine());
            }

            productsList.Sort();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}.{productsList[i - 1]}");
            }
        }
    }
}
