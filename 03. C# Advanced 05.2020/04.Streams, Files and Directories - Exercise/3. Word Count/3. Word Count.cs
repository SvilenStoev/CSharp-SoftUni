using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("./text.txt").ToLower();
            string[] words = File.ReadAllLines("./words.txt");
            Dictionary<string, int> matchesDict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];
                string regEx = @$"\b{currWord.ToLower()}\b";
                var match = Regex.Matches(text, regEx);

                matchesDict[currWord] = match.Count;
            }

            var sortedResults = matchesDict.OrderByDescending(kvp => kvp.Value);
            List<string> results = new List<string>();


            foreach (KeyValuePair<string, int> kvp in sortedResults)
            {
                results.Add($"{kvp.Key} - {kvp.Value}");
            }

            File.WriteAllLines("../../../actualResults.txt", results);


        }
    }
}
