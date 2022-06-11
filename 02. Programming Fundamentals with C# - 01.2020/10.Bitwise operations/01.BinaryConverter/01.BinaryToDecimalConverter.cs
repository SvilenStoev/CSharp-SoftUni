using System;

namespace _01.BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //101 => 5

            Console.Write("Enter the binary code to convert: ");
            string input = Console.ReadLine();
            int currDigit = 0;
            double number = 0;
            double currPosition = 0;

            for (int i = 0; i < input.Length; i++)
            {
                currDigit = int.Parse(input[i].ToString());
                currPosition = (input.Length - i - 1);

                if (currDigit == 1)
                {
                    number += Math.Pow(2, currPosition);
                }

            }

            Console.Write("The number of the given binary code = ");
            Console.WriteLine(number);

            //int number = 0b101;

            //Console.WriteLine(number); //5

            //int number = 0x10;
            //Console.WriteLine(number); //16

        }
    }
}
