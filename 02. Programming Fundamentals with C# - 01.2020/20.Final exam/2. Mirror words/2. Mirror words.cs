using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _2._Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> pairs = new List<string>();

            var regex = new Regex(@"([@#]{1,})([A-Za-z]{3,})\1{2}([A-Za-z]{3,})\1");

            MatchCollection matches = regex.Matches(text);
            bool noMirrorWordsCheck = true;

            foreach (Match match in matches)
            {
                string firstPair = match.Groups[2].Value;
                string secondPair = match.Groups[3].Value;

                var firstPairReversed = firstPair.Reverse().ToArray();
                string firstPairReversedString = string.Join("", firstPairReversed);

                if (firstPairReversedString == secondPair)
                {
                    noMirrorWordsCheck = false;

                    string currentPair = firstPair + " <=> " + secondPair;

                    pairs.Add(currentPair);
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (noMirrorWordsCheck)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                Console.WriteLine(string.Join(", ", pairs));
            }
        }
    }
}
