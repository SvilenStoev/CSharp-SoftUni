using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffects = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bombCasing = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var effectsQueue = new Queue<int>(bombEffects);
            var casingStack = new Stack<int>(bombCasing);

            var bombsDetails = new Dictionary<int, string>()
            {
                [40] = "Datura Bombs",
                [60] = "Cherry Bombs",
                [120] = "Smoke Decoy Bombs"
            };

            var bombsMade = new Dictionary<string, int>()
            {
                ["Datura Bombs"] = 0,
                ["Cherry Bombs"] = 0,
                ["Smoke Decoy Bombs"] = 0
            };

            bool isBombPouchFilled = false;

            while (effectsQueue.Count > 0 && casingStack.Count > 0)
            {
                int sum = effectsQueue.Peek() + casingStack.Peek();

                if (bombsDetails.ContainsKey(sum))
                {
                    bombsMade[bombsDetails[sum]]++;
                    effectsQueue.Dequeue();
                    casingStack.Pop();
                }
                else
                {
                    casingStack.Push(casingStack.Pop() - 5);
                }

                if (bombsMade["Datura Bombs"] >= 3 && bombsMade["Cherry Bombs"] >= 3 && bombsMade["Smoke Decoy Bombs"] >= 3)
                {
                    isBombPouchFilled = true;
                    break;
                }
            }

            if (isBombPouchFilled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effectsQueue.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effectsQueue)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (casingStack.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casingStack)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            var orderedBombs = bombsMade.OrderBy(b => b.Key).ToDictionary(k => k.Key, v => v.Value);

            if (orderedBombs.Count > 0)
            {
                foreach (var kvp in orderedBombs)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
