using System;

namespace _3._9.Multiplyby2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {
                number *= 2;
                Console.WriteLine($"Result: {number:f2}");

                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative number!");

        }
    }
}
