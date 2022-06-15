using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да я реша пак! Не можех да измисля лесна логика при четенето на квадрата!

            int[] dimentions = SplitInputToArray(' ', ',');
            int rows = dimentions[0];
            int cols = dimentions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbersInCurrRow = SplitInputToArray(' ', ',');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbersInCurrRow[col];
                }
            }

            int bestSum = int.MinValue;
            int bestNumberRow = 0;
            int bestNumberColumn = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currSum > bestSum)
                    {
                        bestSum = currSum;
                        bestNumberRow = row;
                        bestNumberColumn = col;
                    }
                }
            }

            for (int row = bestNumberRow; row < bestNumberRow + 2; row++)
            {
                for (int col = bestNumberColumn; col < bestNumberColumn + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(bestSum);
        }

        private static int[] SplitInputToArray(params char[] splitSymbols)
            => Console.ReadLine()
            .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
