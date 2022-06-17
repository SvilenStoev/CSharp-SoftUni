using System;
using System.Numerics;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int snakeRow = 0;
            int snakeCol = 0;

            FillTheMatrix(matrix, ref snakeRow, ref snakeCol);

            int foodEaten = 0;
            bool gameOver = false;

            while (foodEaten < 10)
            {
                string command = Console.ReadLine();

                SnakeMove(ref snakeRow, ref snakeCol, command);

                if (snakeRow < 0 || snakeCol < 0 || snakeRow >= n || snakeCol >= n)
                {
                    gameOver = true;
                    break;
                }
                else
                {
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodEaten++;
                        matrix[snakeRow, snakeCol] = '.';
                    }
                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (matrix[row, col] == 'B')
                                {
                                    snakeRow = row;
                                    snakeCol = col;
                                    matrix[snakeRow, snakeCol] = '.';
                                }
                            }
                        }
                    }
                    else if (matrix[snakeRow, snakeCol] == '-')
                    {
                        matrix[snakeRow, snakeCol] = '.';
                    }
                }
            }

            if (gameOver)
            {
                Console.WriteLine("Game over!");
            }

            if (foodEaten == 10)
            {
                matrix[snakeRow, snakeCol] = 'S';
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodEaten}");
            PrintTheMatrix(matrix);

        }

        private static void PrintTheMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FillTheMatrix(char[,] matrix, ref int snakeRow, ref int snakeCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                        matrix[row, col] = '.';
                    }
                }
            }
        }

        private static void SnakeMove(ref int snakeRow, ref int snakeCol, string command)
        {
            if (command == "up")
            {
                snakeRow--;
            }
            else if (command == "down")
            {
                snakeRow++;
            }
            else if (command == "left")
            {
                snakeCol--;
            }
            else if (command == "right")
            {
                snakeCol++;
            }
        }
    }
}
