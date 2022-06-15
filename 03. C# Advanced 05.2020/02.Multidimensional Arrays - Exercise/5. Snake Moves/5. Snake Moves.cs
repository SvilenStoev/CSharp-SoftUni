using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            //Не можах да я реша, Не я и разбрах! След малка подсказка я реших..

            int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];

            string snake = Console.ReadLine();
            string[,] matrix = new string[rows, cols];
            int currSnakeIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[currSnakeIndex++].ToString();

                        currSnakeIndex = SetIndexToZero(snake, currSnakeIndex);
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currSnakeIndex++].ToString();

                        currSnakeIndex = SetIndexToZero(snake, currSnakeIndex);
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static int SetIndexToZero(string snake, int currSnakeIndex)
        {
            if (currSnakeIndex == snake.Length)
            {
                currSnakeIndex = 0;
            }

            return currSnakeIndex;
        }

        private static void PrintMatrix(string[,] matrix)
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
    }
}
