using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetMultipleOfEvenAndOdds(int num1)
        {
            int result = GetSumOfEvenDigits(num1) * GetSumOfOddDigits(num1);
            return result;
        }

        static int GetSumOfEvenDigits(int num1)
        {
            int sum = 0;
            int currNumber = 0;

            while (num1 > 0)
            {
                currNumber = num1 % 10;

                if (currNumber % 2 == 0)
                {
                    sum += currNumber;
                }

                num1 = num1 / 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int num1)
        {
            int sum = 0;
            int currNumber = 0;

            while (num1 > 0)
            {
                currNumber = num1 % 10;

                if (currNumber % 2 != 0)
                {
                    sum += currNumber;
                }

                num1 = num1 / 10;
            }

            return sum;
        }

    }
}
