using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(number1, @operator, number2));
        }

        static double Calculate(int a, string @operator, int b)
        {
            double result = 0.0;

            switch (@operator)
            {
                case "/": result = a / b; break;
                case "*": result = a * b; break;
                case "+": result = a + b; break;
                case "-": result = a - b; break;
            }

            return result;
        }

    }
}
