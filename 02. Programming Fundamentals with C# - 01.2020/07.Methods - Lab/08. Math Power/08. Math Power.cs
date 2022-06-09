using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Pow(number, powerNumber));
        }

        static double Pow(double x, double y)
        {
            double result = x;

            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            return result;
        }


    }

}
