using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реших я но с доста помощ! Да я реша пак!

            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = ReadCharMatrix(n);

            int knightsCounts = 0;

            while (true)
            {
                int maxAttacksCount = 0;
                int killerRow = 0;
                int killerCol = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int currMaxAttacks = 0;

                        if (chessBoard[row,col] == 'K')
                        {
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                //L pattern up and left

                                currMaxAttacks++;
                            }

                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                //L pattern up and right

                                currMaxAttacks++;
                            }

                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                //L pattern right and up

                                currMaxAttacks++;
                            }

                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currMaxAttacks++;
                            }

                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currMaxAttacks++;
                            }

                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currMaxAttacks++;
                            }

                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currMaxAttacks++;
                            }

                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currMaxAttacks++;
                            }
                        }
                        if (currMaxAttacks > maxAttacksCount)
                        {
                            maxAttacksCount = currMaxAttacks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }

                if (maxAttacksCount > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    knightsCounts++;
                }
                else
                {
                    Console.WriteLine(knightsCounts);
                    break;
                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }

        private static char[,] ReadCharMatrix(int n)
        {
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currRow = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            return matrix;
        }
    }
}
