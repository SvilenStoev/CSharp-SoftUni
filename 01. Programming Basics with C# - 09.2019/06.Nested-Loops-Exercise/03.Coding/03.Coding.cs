using System;

namespace _03.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();
            int number = int.Parse(numberAsString);

            for (int i = 0; i < numberAsString.Length; i++)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit == 0)
                {
                    Console.Write("ZERO");
                }

                for (int j = 0; j < currentDigit; j++)
                {
                    int digitAfterAddinition = currentDigit + 33;

                    Console.Write($"{(char)digitAfterAddinition}");
                }
                Console.WriteLine();
            }

        }
    }
}
