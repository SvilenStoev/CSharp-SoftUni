using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split().ToArray();

            var filteredArray = stringArray.Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join("\n", filteredArray));
        }
    }
}
