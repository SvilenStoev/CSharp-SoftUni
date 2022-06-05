using System;

namespace _06.Six
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int thirdDigit = number % 10;
            number /= 10;
            int secondDigit = number % 10;
            number /= 10;
            int firstDigit = number % 10;

            for (int i = 1; i <= thirdDigit; i++)
            {

                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= firstDigit; k++)
                    {
                        if (i == 0 || j == 0 || k == 0)
                        {
                            continue;
                        }

                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");

                    }
                }
            }

        }
    }
}
