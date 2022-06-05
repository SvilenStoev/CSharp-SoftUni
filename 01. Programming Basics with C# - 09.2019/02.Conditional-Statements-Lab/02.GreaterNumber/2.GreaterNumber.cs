using System;

namespace _02.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
        	{
                Console.WriteLine(number2);
            }

        }
    }
}
