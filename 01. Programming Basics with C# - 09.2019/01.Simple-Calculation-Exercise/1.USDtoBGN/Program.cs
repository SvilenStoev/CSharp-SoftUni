using System;

namespace _1.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Double usd = double.Parse(Console.ReadLine());
            Console.WriteLine($"{usd* 1.79549:f2}");
        }
    }
}
