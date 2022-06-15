using System;

namespace _7._1.Pascal_Triangle_v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] pascalTriangle = new double[n][];

            if (n >= 1)
            {
                pascalTriangle[0] = new[] { 1.0 };
            }

            if (n >= 2)
            {
                pascalTriangle[1] = new[] { 1.0, 1.0 };
            }

            for (int row = 2; row < n; row++)
            {
                pascalTriangle[row] = new double[row + 1];
                pascalTriangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }

                pascalTriangle[row][row] = 1;
            }

            int lastRowLength = string.Join(" ", pascalTriangle[n - 1]).Length;

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                string currentRowText = string.Join(" ", pascalTriangle[row]);

                int diff = lastRowLength - currentRowText.Length;
                int halfDiff = diff / 2;

                string whiteSpace = new string(' ', halfDiff);

                Console.WriteLine($"{whiteSpace}{currentRowText}");
            }
        }
    }
}
