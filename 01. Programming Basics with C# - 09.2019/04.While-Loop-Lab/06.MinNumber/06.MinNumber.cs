using System;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int minValue = int.MaxValue;

            while (n > counter)
            {
                counter++;
                int number = int.Parse(Console.ReadLine());
                if (number < minValue)
                {
                    minValue = number;
                }
            }

            Console.WriteLine(minValue);
        }
    }
}
