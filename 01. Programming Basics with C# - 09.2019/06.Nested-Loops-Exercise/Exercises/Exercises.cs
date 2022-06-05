using System;

namespace _02.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 10; cols > rows; cols--)
                {
                    Console.Write($"*");
                    current++;
                }
              
                Console.WriteLine();
            }

        }
    }
}

