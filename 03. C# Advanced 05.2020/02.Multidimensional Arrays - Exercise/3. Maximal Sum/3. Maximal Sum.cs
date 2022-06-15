using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реших я, но може пак! Интересна е!

            int[] dimenstions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimenstions[0];
            int cols = dimenstions[1];

            int[,] matrix = ReadStringMatrix(rows, cols);
            int bestSum = int.MinValue;
            int bestSquareRow = 0; 
            int bestSquareCol = 0; 

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currSum = 0;

                    for (int squareRow = row; squareRow < row + 3; squareRow++)
                    {
                        for (int squareCol = col; squareCol < col + 3; squareCol++)
                        {
                            currSum += matrix[squareRow, squareCol];
                        }
                    }

                    if (currSum > bestSum)
                    {
                        bestSum = currSum;
                        bestSquareRow = row;
                        bestSquareCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");

            for (int row = bestSquareRow; row < bestSquareRow + 3; row++)
            {
                for (int col = bestSquareCol; col < bestSquareCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }


        }
        private static int[,] ReadStringMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            return matrix;
        }
    }
}
