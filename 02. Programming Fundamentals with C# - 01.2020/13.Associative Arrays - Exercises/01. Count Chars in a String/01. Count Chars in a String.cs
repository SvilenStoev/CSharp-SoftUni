using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();

            var dict = new Dictionary<char, int>();

            foreach (var ch in text)
            {
                if (ch == ' ')
                {
                    continue;
                }

                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 0);
                }

                dict[ch]++;
            }

            foreach (var item in dict)
            {
                char currentChar = item.Key;
                int occurenceCount = item.Value;

                Console.WriteLine($"{currentChar} -> {occurenceCount}");
            }
        }
    }
}
