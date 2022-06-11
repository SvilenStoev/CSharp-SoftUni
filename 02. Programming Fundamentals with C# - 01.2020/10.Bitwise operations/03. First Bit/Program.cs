using System;

namespace _03._First_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int shiftedNumber = number >> 1;

            //Console.WriteLine(shiftedNumber);

            int bitAtPosition1 = shiftedNumber & 1;

            Console.WriteLine(bitAtPosition1);

        }
    }
}
