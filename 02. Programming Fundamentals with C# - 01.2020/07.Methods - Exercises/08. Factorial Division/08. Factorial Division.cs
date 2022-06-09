using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{DivideTwoNumbers(CalculateFactorial(num1), CalculateFactorial(num2)):f2}");
        }

        static double CalculateFactorial(double num)
        {
            double result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }

        static double DivideTwoNumbers(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
