using System;

namespace _04.SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationCounter = 0;

            for (int n = firstNumber; n <= lastNumber; n++)
            {
                for (int j = firstNumber; j <= lastNumber; j++)
                {
                    combinationCounter++;

                    if (n + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({n} + {j} = {magicNumber})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");

        }
    }
}
