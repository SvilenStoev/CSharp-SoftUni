using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                words[word].Add(synonym);
            }

            foreach (var item in words)
            {
                var word = item.Key;
                var synonym = item.Value;

                Console.WriteLine($"{word} - {string.Join(", ", item.Value)}");

            }



        }
    }
}
