using System;
using System.Linq;
using System.Numerics;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] array = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] currRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                array[row] = currRow;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (array[row].Length == array[row + 1].Length)
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        array[row][col] *= 2;
                        array[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        array[row][col] /= 2;
                    }
                    for (int col = 0; col < array[row + 1].Length; col++)
                    {
                        array[row + 1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstCommand = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (row >= 0 && col >= 0 && row < array.Length && col < array[row].Length)
                {
                    if (firstCommand == "Add")
                    {
                        array[row][col] += value;
                    }
                    else if (firstCommand == "Subtract")
                    {
                        array[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            PrintArray(array);
        }

        private static void PrintArray(double[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
