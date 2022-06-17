using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, bool> lengthFilter = x => x.Length <= n;
            Action<string> print = x => Console.WriteLine(x);

            names
                .Where(lengthFilter)
                .ToList()
                .ForEach(print);
        }
    }
}
