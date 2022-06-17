using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<string> printSir = x => Console.WriteLine($"Sir {x}");

            //Console.ReadLine()
            //    .Split()
            //    .ToList()
            //    .ForEach(printSir);

            Console.ReadLine()
               .Split()
               .ToList()
               .ForEach(x => Console.WriteLine($"Sir {x}"));
        }
    }
}
