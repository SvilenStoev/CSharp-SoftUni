using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int diagonalSum = 0;
            int diagonalRow = 0;

            for (int col = 0; col < n; col++)
            {
                diagonalSum += matrix[diagonalRow, col];
                diagonalRow++;
            }


            Console.WriteLine(diagonalSum);
        }
    }
}
