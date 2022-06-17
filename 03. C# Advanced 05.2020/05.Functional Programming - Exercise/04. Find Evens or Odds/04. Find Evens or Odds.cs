using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string query = Console.ReadLine();

            Predicate<int> predicate = query == "odd" ? new Predicate<int>(n => n % 2 != 0) : new Predicate<int>(x => x % 2 == 0);

            var result = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
