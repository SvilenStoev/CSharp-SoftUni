using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //2 1 1 2 3 3 2 2 2 1
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currCount = 1;
                int currElement = arr[i];

                for (int currI = i + 1; currI < arr.Length; currI++)
                {
                    if (currElement == arr[currI])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestIndex = i;
                }
            }

            for (int j = 0; j < bestCount; j++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
