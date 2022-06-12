using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var currentWord in words)
            {
                var currentWordToLower = currentWord.ToLower();

                if (!counts.ContainsKey(currentWordToLower))
                {
                    counts[currentWordToLower] = 0;
                }

                counts[currentWordToLower]++;
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
