using System;

namespace _05.Bit_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int shiftedNumber = 1 << p;
            int mask = shiftedNumber;

            mask = ~mask;

            int newNumber = number & mask;

            Console.WriteLine(newNumber);
        }
    }
}
