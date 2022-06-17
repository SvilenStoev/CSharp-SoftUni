using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> myDoubleParse = double.Parse;

            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(myDoubleParse)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n * 1.2:f2}"));
        }
    }
}
