using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int sum = 0;
                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;

                    sum += currentDigit;
                }
                bool isSpecial = false;

                if (sum == 5 || sum == 7 || sum == 11 )
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
