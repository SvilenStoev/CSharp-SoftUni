using System;

namespace _07.LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumLeft += number;
            }
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumRight += number;
            }

            if (sumRight == sumLeft)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }

        }
    }
}
