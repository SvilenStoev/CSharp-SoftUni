using System;

namespace _4.InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            a = a * 2.54;

            Console.WriteLine($"{a:f2}");

       


        }
    }
}
