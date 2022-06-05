using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int validCombinations = 0;

            for (int i = 0; i <= number; i++)
            {
                for (int m = 0; m <= number; m++)
                {
                    for (int j = 0; j <= number; j++)
                    {
                        if (i + m + j == number)
                        {
                            validCombinations++;
                        }
                    }
                }
            }

            Console.WriteLine(validCombinations);

        }
    }
}
