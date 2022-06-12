using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine();

            while (secondString.Contains(firstString))
            {
                int startIndex = secondString.IndexOf(firstString);
                secondString = secondString.Remove(startIndex, firstString.Length);
            }

            Console.WriteLine(secondString);
        }
    }
}
