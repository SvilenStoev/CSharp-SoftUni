using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNAlength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] arr = new int[DNAlength];

            int bestSequence = 0;
            int bestSequenceIndex = 0;
            int currArrCount = 0;
            int bestArrCount = 1;
            int[] bestArr = new int[DNAlength];

            while (input != "Clone them!")
            {
                arr = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currArrCount++;

                int currCount = 1;
                int bestCurrIndex = 0;
                int bestCurrCount = 0;

                for (int currIndex = 0; currIndex < arr.Length; currIndex++)
                {
                    int currElement = arr[currIndex];

                    if (currElement == 0)
                    {
                        continue;
                    }

                    for (int index = currIndex + 1; index < arr.Length; index++)
                    {
                        if (arr[index] == 1)
                        {
                            currCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currCount > bestCurrCount)
                    {
                        bestCurrCount = currCount;
                        bestCurrIndex = currIndex;
                    }
                }

                if (bestCurrCount > bestSequence ||
                   (bestCurrCount == bestSequence && bestSequenceIndex > bestCurrIndex) ||
                   (bestCurrCount == bestSequence && bestArr.Sum() < arr.Sum()))
                {
                    bestSequenceIndex = bestCurrIndex;
                    bestSequence = bestCurrCount;
                    bestArr = arr.ToArray();
                    bestArrCount = currArrCount;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestArrCount} with sum: {bestArr.Sum()}.");
            Console.WriteLine(String.Join(" ", bestArr));
        }
    }
}
