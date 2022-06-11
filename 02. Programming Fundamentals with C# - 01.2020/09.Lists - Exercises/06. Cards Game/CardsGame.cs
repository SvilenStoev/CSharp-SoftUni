using System;
using System.Linq;
using System.Collections.Generic;


namespace _06._Cards_Game
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (Math.Min(firstHand.Count, secondHand.Count) != 0)
            {
                if (firstHand[0] > secondHand[0])
                {
                    firstHand.Add(firstHand[0]);
                    firstHand.RemoveAt(0);

                    firstHand.Add(secondHand[0]);
                    secondHand.RemoveAt(0);
                }
                else if (firstHand[0] < secondHand[0])
                {
                    secondHand.Add(secondHand[0]);
                    secondHand.RemoveAt(0);

                    secondHand.Add(firstHand[0]);
                    firstHand.RemoveAt(0);
                }
                else
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }

            }

            if (firstHand.Count != 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");

            }
        }
    }
}
