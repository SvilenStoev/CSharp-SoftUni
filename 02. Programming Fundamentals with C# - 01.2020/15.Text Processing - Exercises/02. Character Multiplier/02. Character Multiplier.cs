using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string firstString = input[0];
            string secondString = input[1];

            Console.WriteLine(CharMultiplier(firstString, secondString));
        }

        static int CharMultiplier(string firstString, string secondString)
        {
            int totalSum = 0;

            if (firstString.Length <= secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    int multiplied = firstString[i] * secondString[i];
                    totalSum += multiplied;
                }

                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    totalSum += secondString[i];
                }
            }
            else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    int multiplied = firstString[i] * secondString[i];
                    totalSum += multiplied;
                }

                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    totalSum += firstString[i];
                }
            }

            return totalSum;
        }
    }
}
