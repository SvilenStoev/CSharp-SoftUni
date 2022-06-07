using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());
            long number3 = long.Parse(Console.ReadLine());
            long number4 = long.Parse(Console.ReadLine());

            long result = ((number1 + number2) / number3) * number4;

            Console.WriteLine(result);

        }
    }
}
