using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _2._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentsCount = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int[] santaPosition = new int[] { 0, 0 };

            int niceKids = 0;

            FillTheMatrix(matrix, ref niceKids, santaPosition);

            int niceKidsWithPresents = niceKids;

            string command = Console.ReadLine();

            while (command != "Christmas morning")
            {
                SantaMovements(santaPosition, command);

                int santaRow = santaPosition[0];
                int santaCol = santaPosition[1];

                IsNiceKid(ref presentsCount, matrix, ref niceKids, santaRow, santaCol);

                IsBadKid(ref presentsCount, matrix, santaRow, santaCol);

                IsHouseWithCookies(ref presentsCount, matrix, ref niceKids, santaRow, santaCol);

                command = Console.ReadLine();

                if (presentsCount == 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }
            }

            matrix[santaPosition[0], santaPosition[1]] = 'S';

            PrintTheMatrix(matrix);

            if (niceKids == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKidsWithPresents} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKids} nice kid/s.");
            }
        }

        private static void IsHouseWithCookies(ref int presentsCount, char[,] matrix, ref int niceKids, int santaRow, int santaCol)
        {
            if (matrix[santaRow, santaCol] == 'C')
            {
                if (matrix[santaRow + 1, santaCol] == 'V' || matrix[santaRow + 1, santaCol] == 'X' && presentsCount > 0)
                {
                    IsNiceKid(ref presentsCount, matrix, ref niceKids, santaRow + 1, santaCol);

                    matrix[santaRow + 1, santaCol] = '-';
                }

                if (matrix[santaRow - 1, santaCol] == 'V' || matrix[santaRow - 1, santaCol] == 'X' && presentsCount > 0)
                {
                    IsNiceKid(ref presentsCount, matrix, ref niceKids, santaRow - 1, santaCol);

                    matrix[santaRow - 1, santaCol] = '-';
                }
                
                if (matrix[santaRow, santaCol + 1] == 'V' || matrix[santaRow, santaCol + 1] == 'X' && presentsCount > 0)
                {
                    IsNiceKid(ref presentsCount, matrix, ref niceKids, santaRow, santaCol + 1);

                    matrix[santaRow, santaCol + 1] = '-';
                }
                
                if (matrix[santaRow, santaCol - 1] == 'V' || matrix[santaRow, santaCol - 1] == 'X' && presentsCount > 0)
                {
                    IsNiceKid(ref presentsCount, matrix, ref niceKids, santaRow, santaCol - 1);

                    matrix[santaRow, santaCol - 1] = '-';
                }
            }
        }

        private static void IsNiceKid(ref int presentsCount, char[,] matrix, ref int niceKids, int santaRow, int santaCol)
        {
            if (matrix[santaRow, santaCol] == 'V')
            {
                matrix[santaRow, santaCol] = '-';

                niceKids--;
                presentsCount--;
            }
        }

        private static void IsBadKid(ref int presentsCount, char[,] matrix, int santaRow, int santaCol)
        {
            if (matrix[santaRow, santaCol] == 'X')
            {
                matrix[santaRow, santaCol] = '-';
            }
        }

        private static void SantaMovements(int[] santaPosition, string command)
        {
            if (command == "up")
            {
                santaPosition[0] -= 1;
            }
            else if (command == "down")
            {
                santaPosition[0] += 1;
            }
            else if (command == "left")
            {
                santaPosition[1] -= 1;
            }
            else if (command == "right")
            {
                santaPosition[1] += 1;
            }
        }

        static void PrintTheMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static void FillTheMatrix(char[,] matrix, ref int niceKids, int[] santaPosition)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currRow = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        matrix[row, col] = '-';

                        santaPosition[0] = row;
                        santaPosition[1] = col;
                    }
                    else if (matrix[row, col] == 'V')
                    {
                        niceKids++;
                    }
                }
            }
        }
    }
}
