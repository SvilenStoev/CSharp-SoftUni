using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string firstNumber = string.Empty;
                string secondNumber = string.Empty;

                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == ' ')
                    {
                        for (int k = j + 1; k < input.Length; k++)
                        {
                            secondNumber += input[k];
                        }
                        break;
                    }

                    firstNumber += input[j];
                }

                BigInteger sumOfFirstNumberDigits = 0;

                BigInteger firstNumberAsInt = BigInteger.Parse(firstNumber);

                for (int t = 0; t < firstNumber.Length; t++)
                {
                    sumOfFirstNumberDigits += firstNumberAsInt % 10;
                    firstNumberAsInt /= 10;
                }

                BigInteger sumOfSecondNumberDigits = 0;

                BigInteger secondNumberAsInt = BigInteger.Parse(secondNumber);

                for (int t = 0; t < secondNumber.Length; t++)
                {
                    sumOfSecondNumberDigits += secondNumberAsInt % 10;
                    secondNumberAsInt /= 10;
                }

                if (sumOfFirstNumberDigits > sumOfSecondNumberDigits)
                {
                    Console.WriteLine(sumOfFirstNumberDigits);
                }
                else
                {
                    Console.WriteLine(sumOfSecondNumberDigits);
                }
            }
        }
    }
}
