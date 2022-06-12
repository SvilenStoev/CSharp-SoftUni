using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(resource))
                {
                    dict[resource] = 0;
                }

                dict[resource] += quantity;
            }

            foreach (var item in dict)
            {
                string currentResource = item.Key;
                int resourceQuantity = item.Value;

                Console.WriteLine($"{currentResource} -> {resourceQuantity}");
            }
        }
    }
}
