using System;

namespace _04.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int number = firstNumber; number <= secondNumber; number++)
            {
                int sumOdd = 0;
                int sumEven = 0;
                int currentNumber = number;

                for (int i = 0; i < 6; i++)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;

                    if (i % 2 == 0)
                    {
                        sumEven += currentDigit;
                    }
                    else
                    {
                        sumOdd += currentDigit;
                    }

                }
                if (sumOdd == sumEven)
                {
                    Console.Write($"{number} ");
                }


            }


        }
    }
}
