using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.Reverse();

            var n = int.Parse(Console.ReadLine());

            Func<int, bool> filterDivisible = x => x % n != 0;

            numbers = numbers
                .Where(filterDivisible)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
