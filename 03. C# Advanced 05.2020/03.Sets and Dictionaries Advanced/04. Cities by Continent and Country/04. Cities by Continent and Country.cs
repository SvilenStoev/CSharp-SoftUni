using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!cities.ContainsKey(continent))
                {
                    cities[continent] = new Dictionary<string, List<string>>();
                }

                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent][country] = new List<string>();
                }

                cities[continent][country].Add(city);
            }

            foreach (var (continent, dict) in cities)
            {
                Console.WriteLine($"{continent}:");

                foreach (var (country, listCities) in dict)
                {
                    Console.Write($"{country} -> ");

                    Console.Write(string.Join(", ", listCities));
                    Console.WriteLine();
                }
            }

        }
    }
}
