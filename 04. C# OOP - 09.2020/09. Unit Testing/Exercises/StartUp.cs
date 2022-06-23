using System;
using System.Linq;

namespace Exercises
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var calculator = new MyCalculator();

            var numbers = new int[]
            {
                10, 20, 30
            };

            double result = calculator.Sum(numbers);

            Console.WriteLine(result);
        }
    }
}
