using System;

namespace _06.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minValue)
                {
                   minValue = number;
                }
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");

        }
    }
}
