using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            IsNTopNumber(n);
        }

        static void IsNTopNumber(int num)
        {
            for (int currentNumber = 1; currentNumber <= num; currentNumber++)
            {
                bool containsOddNumber = false;
                int sumOfDigits = 0;
                int topNumber = currentNumber;

                for (int j = 0; j < currentNumber.ToString().Length; j++)
                {
                    int currentDigit = topNumber % 10; 
                    sumOfDigits += currentDigit;

                    if (currentDigit % 2 != 0)
                    {
                        containsOddNumber = true;
                    }

                    topNumber /= 10;
                }
                               
                if (sumOfDigits % 8 == 0 && containsOddNumber)
                {
                    topNumber = currentNumber;
                    Console.WriteLine(topNumber);
                }
            }
        }
    }
}
