using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> banWords = Console.ReadLine().Split(", ").ToList();
            string text = Console.ReadLine();

            for (int i = 0; i < banWords.Count; i++)
            {
                text = text.Replace(banWords[i], new string('*', banWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
