using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];

            string[,] matrix = ReadStringMatrix(rows, cols);

            int squaresCount = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        squaresCount++;
                    }
                }
            }

            Console.WriteLine(squaresCount);
        }

        private static string[,] ReadStringMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            return matrix;
        }
    }
}
