using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsString = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();

            numbersAsString = numbersAsString.Reverse().ToArray();

            string numbersString = string.Empty;

            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numbersString += numbersAsString[i] + " ";

            }

            List<int> numbers = numbersString.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
