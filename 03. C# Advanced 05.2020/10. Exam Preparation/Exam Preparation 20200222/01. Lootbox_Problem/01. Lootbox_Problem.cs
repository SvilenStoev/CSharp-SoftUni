using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstBoxDetails = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondBoxDetails = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var claimedItems = new List<int>();

            var firstBox = new Queue(firstBoxDetails);
            var secondBox = new Stack(secondBoxDetails);

            while (firstBox.Count != 0 && secondBox.Count != 0)
            {
                int firstBoxNumber = (int)firstBox.Peek();
                int secondBoxNumber = (int)secondBox.Peek();

                int numbersSum = firstBoxNumber + secondBoxNumber;

                if (numbersSum % 2 == 0)
                {
                    claimedItems.Add(numbersSum);
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int claimedItemsSum = claimedItems.Sum();

            if (claimedItemsSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItemsSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItemsSum}");
            }
        }
    }
}
