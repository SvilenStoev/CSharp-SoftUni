using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;

            int currentNumber = 0;
            int totalsum = 0;

            while (number > 0)
            {
                int sum = 1;

                currentNumber = number % 10;

                for (int i = currentNumber; i > 0; i--)
                {
                    sum *= i;
                }
                number /= 10;

                totalsum += sum;
            }

            if (totalsum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
