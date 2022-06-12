using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, long>
            {
                ["motes"] = 0,
                ["shards"] = 0,
                ["fragments"] = 0
            };

            var Junk = new SortedDictionary<string, long>();
            bool obtained = false;

            while (!obtained)
            {
                var list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                long quantity = 0;
                string material = string.Empty;

                for (int i = 0; i < list.Count - 1; i += 2)
                {
                    quantity = long.Parse(list[i]);
                    material = list[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            switch (material)
                            {
                                case "shards": Console.WriteLine("Shadowmourne obtained!"); break;
                                case "fragments": Console.WriteLine("Valanyr obtained!"); break;
                                case "motes": Console.WriteLine("Dragonwrath obtained!"); break;
                            }

                            keyMaterials[material] -= 250;

                            obtained = true;
                            break;
                        }
                    }
                    else
                    {
                        AddJunk(Junk, quantity, material);
                    }
                }
            }

            keyMaterials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var item in Junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static void AddJunk(SortedDictionary<string, long> Junk, long quantity, string material)
        {
            if (!Junk.ContainsKey(material))
            {
                Junk[material] = 0;
            }

            Junk[material] += quantity;
        }
    }
}