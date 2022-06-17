using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1._Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var materialsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var magicLevelArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var materialsBoxes = new Stack<int>(materialsArray);
            var magicLevels = new Queue<int>(magicLevelArray);

            var presentsDetails = new Dictionary<int, string>()
            {
                [150] = "Doll",
                [250] = "Wooden train",
                [300] = "Teddy bear",
                [400] = "Bicycle"
            };

            var craftedPresents = new Dictionary<string, int>()
            {
                ["Doll"] = 0,
                ["Wooden train"] = 0,
                ["Teddy bear"] = 0,
                ["Bicycle"] = 0
            };

            while (materialsBoxes.Any() && magicLevels.Any())
            {
                int totalMagic = materialsBoxes.Peek() * magicLevels.Peek();

                if (presentsDetails.ContainsKey(totalMagic))
                {
                    materialsBoxes.Pop();
                    magicLevels.Dequeue();

                    craftedPresents[presentsDetails[totalMagic]]++;
                }
                else if (totalMagic < 0)
                {
                    int materialsToAdd = materialsBoxes.Peek() + magicLevels.Peek();
                    materialsBoxes.Pop();
                    magicLevels.Dequeue();

                    materialsBoxes.Push(materialsToAdd);
                }
                else if (totalMagic > 0)
                {
                    magicLevels.Dequeue();
                    materialsBoxes.Push(materialsBoxes.Pop() + 15);
                }
                else
                {
                    if (materialsBoxes.Peek() == 0)
                    {
                        materialsBoxes.Pop();
                    }

                    if (magicLevels.Peek() == 0)
                    {
                        magicLevels.Dequeue();
                    }
                }
            }

            if ((craftedPresents["Doll"] != 0 && craftedPresents["Wooden train"] != 0) 
                || (craftedPresents["Teddy bear"] != 0 && craftedPresents["Bicycle"] != 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materialsBoxes.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materialsBoxes)}");
            }

            if (magicLevels.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevels)}");
            }

            var orderedCraftedPresents = craftedPresents.Where(p => p.Value != 0).OrderBy(p => p.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in orderedCraftedPresents)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
