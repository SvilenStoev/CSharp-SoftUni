using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security;

namespace Bombs
{
    class Bombs
    {
        static void Main(string[] args)
        {
            int[] bombEffects = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bombCasing = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var effectsQueue = new Queue<int>(bombEffects);
            var casingStack = new Stack<int>(bombCasing);

            var bombsDetails = new Dictionary<int, string>()
            {
                [40] = "Datura Bombs",
                [60] = "Cherry Bombs",
                [120] = "Smoke Decoy Bombs"
            };

            SortedDictionary<string, int> bombsMade = new SortedDictionary<string, int>();

            bool isBombPounchFilled = false;

            while (effectsQueue.Any() && casingStack.Any())
            {
                int sum = effectsQueue.Peek() + casingStack.Peek();

                if (bombsDetails.ContainsKey(sum))
                {
                    if (!bombsMade.ContainsKey(bombsDetails[sum]))
                    {
                        bombsMade.Add(bombsDetails[sum], 0);
                    }

                    bombsMade[bombsDetails[sum]]++;

                    effectsQueue.Dequeue();
                    casingStack.Pop();
                }
                else
                {
                    int newMaterial = casingStack.Pop() - 5;
                    casingStack.Push(newMaterial);
                }

                if (bombsMade.Count >= 3 && bombsMade["Datura Bombs"] >= 3 && bombsMade["Cherry Bombs"] >= 3 && bombsMade["Smoke Decoy Bombs"] >= 3)
                {
                    isBombPounchFilled = true;
                    break;
                }
            }

            if (isBombPounchFilled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");  
            }

            if (effectsQueue.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effectsQueue)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (casingStack.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casingStack)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var bomb in bombsMade)
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
