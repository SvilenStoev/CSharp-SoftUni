using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var valuesCounter = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                double currValue = array[i];

                if (!valuesCounter.ContainsKey(currValue))
                {
                    valuesCounter[currValue] = 0;
                }

                valuesCounter[currValue]++;
            }

            foreach (var (key, value) in valuesCounter)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
