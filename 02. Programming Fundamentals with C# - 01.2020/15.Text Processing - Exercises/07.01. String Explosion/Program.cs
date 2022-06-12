using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._01._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('>').ToList();

            string result = input[0];
            int remainingStrength = 0;

            for (int i = 1; i < input.Count; i++)
            {
                result += ">";

                string currSplittedString = input[i];
                int strength = int.Parse(currSplittedString[0].ToString()) + remainingStrength;

                if (strength > currSplittedString.Length)
                {
                    remainingStrength = strength - currSplittedString.Length;
                }
                else
                {
                    result += currSplittedString.Substring(strength);
                }
            }

            Console.WriteLine(result);

        }
    }
}
