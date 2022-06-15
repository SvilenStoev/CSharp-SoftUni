using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];

            string[,] matrix = ReadStringMatrix(rows, cols);
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "swap" &&
                    commands.Length == 5 &&
                    int.Parse(commands[1]) >= 0 &&
                    int.Parse(commands[1]) < rows &&
                    int.Parse(commands[2]) >= 0 &&
                    int.Parse(commands[2]) < cols &&
                    int.Parse(commands[3]) >= 0 &&
                    int.Parse(commands[3]) < rows &&
                    int.Parse(commands[4]) >= 0 &&
                    int.Parse(commands[4]) < cols)
                {
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);

                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
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
