using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);

            //Much slower:

            //foreach (string word in words)
            //{
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        Console.Write(word);
            //    }
            //}
        }
    }
}
