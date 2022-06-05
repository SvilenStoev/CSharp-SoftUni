using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0.00;

            switch (symbol)
            {
                case '+': result = number1 + number2; break;
                case '-': result = number1 - number2; break;
                case '*': result = number1 * number2; break;
                case '/': result = number1 / number2; break;
                case '%': result = number1 % number2; break;
            }

            if (symbol == '+' || symbol == '-' || symbol == '*')
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {symbol} {number2} = {result} - odd");
                }
            }
            else if (symbol == '/' && number2 != 0)
            {
                Console.WriteLine($"{number1} / {number2} = {result:f2}");
            }
            else if (symbol == '%' && number2 != 0)
            {
                Console.WriteLine($"{number1} % {number2} = {result}");
            }
            else
            {
                Console.WriteLine($"Cannot divide {number1} by zero");
            }
        }
    }
}
