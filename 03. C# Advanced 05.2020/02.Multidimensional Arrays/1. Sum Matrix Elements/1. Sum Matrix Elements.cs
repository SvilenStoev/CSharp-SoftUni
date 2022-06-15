using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string dimentions = Console.ReadLine();
            int rows = int.Parse(dimentions.Split(", ")[0]);
            int cols = int.Parse(dimentions.Split(", ")[1]);
            int[,] matrix = new int[rows, cols];

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] numbersInCurrRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sum += numbersInCurrRow.Sum();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbersInCurrRow[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
