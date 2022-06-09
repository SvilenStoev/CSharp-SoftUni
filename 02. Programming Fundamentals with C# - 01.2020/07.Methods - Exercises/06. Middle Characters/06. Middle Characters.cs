using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string input)
        {
            int middleDigit = 0;

            if (input.Length % 2 == 0)
            {
                middleDigit = input.Length / 2;
                Console.WriteLine($"{input[middleDigit - 1]}{input[middleDigit]}");
            }
            else
            {
                middleDigit = input[input.Length / 2];
                Console.WriteLine((char)middleDigit);
            }
        }
    }
}
