using System;
using System.Linq;

namespace _1._Diagonal_Difference
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

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int diagonalCol = 0;
            int diagonalRow = n - 1;

            for (int row = 0; row < n; row++)
            {
                primaryDiagonalSum += matrix[row, diagonalCol];
                secondaryDiagonalSum += matrix[diagonalRow, diagonalCol];

                diagonalRow--;
                diagonalCol++;
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
