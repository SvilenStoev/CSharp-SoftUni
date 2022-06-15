using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currRow = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            int symbolRowIndex = 0;
            int symbolColIndex = 0;
            bool isSymbolExist = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isSymbolExist = true;
                        symbolRowIndex = row;
                        symbolColIndex = col;
                        break;
                    }
                }
                if (isSymbolExist)
                {
                    break;
                }
            }

            if (isSymbolExist)
            {
                Console.WriteLine($"({symbolRowIndex}, {symbolColIndex})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
