using System;

namespace _02.DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 => 101

            Console.Write("Enter the number to convert: ");
            int number = int.Parse(Console.ReadLine());
            int[] binaryArray = new int[10];
            int i;

            for (i = 0; number > 0; i++)
            {
                binaryArray[i] = number % 2;
                number = number / 2;
            }

            Console.Write("Binary of the given number = ");

            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binaryArray[i]);
            }

            //int n = 5;

            //string binary = Convert.ToString(n, 2);

            //Console.WriteLine(binary);

        }
    }
}
