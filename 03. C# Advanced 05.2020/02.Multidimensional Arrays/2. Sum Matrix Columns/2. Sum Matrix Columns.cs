using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = SplitInputToArray(' ', ',');
            int rows = dimentions[0];
            int cols = dimentions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbersInCurrRow = SplitInputToArray(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbersInCurrRow[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sumColumn = 0;

                for (int row = 0; row < rows; row++)
                {
                    sumColumn += matrix[row, col];
                }

                Console.WriteLine(sumColumn);
            }
        }

        private static int[] SplitInputToArray(params char[] splitSymbols)
            => Console.ReadLine()
            .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
