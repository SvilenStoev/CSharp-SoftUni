using System;

namespace _04._p_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int shiftedNumber = number >> p;

            //Console.WriteLine(shiftedNumber);

            int bitAtPositionP = shiftedNumber & 1;

            Console.WriteLine(bitAtPositionP);
        }
    }
}
