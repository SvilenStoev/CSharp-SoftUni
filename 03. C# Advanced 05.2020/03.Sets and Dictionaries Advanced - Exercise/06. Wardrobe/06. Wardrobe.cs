using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currDress = clothes[j];

                    if (!wardrobe[color].ContainsKey(currDress))
                    {
                        wardrobe[color][currDress] = 0;
                    }

                    wardrobe[color][currDress]++;

                }
            }

            string[] finalInput = Console.ReadLine().Split().ToArray();
            string searchedColor = finalInput[0];
            string searchedDress = finalInput[1];

            foreach (var (color, clothesDict) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (dress, count) in clothesDict)
                {
                    if (dress == searchedDress && color == searchedColor)
                    {
                        Console.WriteLine($"* {dress} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress} - {count}");
                    }
                }
            }
        }
    }
}
