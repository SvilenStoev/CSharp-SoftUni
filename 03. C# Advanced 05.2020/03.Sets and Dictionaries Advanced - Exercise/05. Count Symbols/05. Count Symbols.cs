using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var histogram = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];

                if (!histogram.ContainsKey(currChar))
                {
                    histogram[currChar] = 0;
                }

                histogram[currChar]++;
            }

            foreach (var (key, value) in histogram.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{key}: {value} time/s");
            }

        }
    }
}
