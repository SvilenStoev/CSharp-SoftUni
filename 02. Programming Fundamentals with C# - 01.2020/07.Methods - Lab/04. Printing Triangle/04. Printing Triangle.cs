using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintingTriangles(n);
        }

        static void PrintingTriangles(int num)
        {
            PrintTopPart(num);
            PrintBottomPart(num);
        }

        static void PrintTopPart(int end)
        {
            for (int start = 1; start <= end; start++)
            {
                for (int i = 1; i <= start; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintBottomPart(int end)
        {
            for (int j = end - 1; j >= 1; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
