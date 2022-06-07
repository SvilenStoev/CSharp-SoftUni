using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal metters = decimal.Parse(Console.ReadLine());

            decimal kilometers = metters * 0.001m;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
