using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": AddNumbers(a, b); break;
                case "multiply": MultiplyNumbers(a, b); break;
                case "subtract": SubtractNumbers(a, b); break;
                case "divide": DivideNumbers(a, b); break;
            }
        }

        static void AddNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        static void MultiplyNumbers(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        static void SubtractNumbers(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }

        static void DivideNumbers(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
