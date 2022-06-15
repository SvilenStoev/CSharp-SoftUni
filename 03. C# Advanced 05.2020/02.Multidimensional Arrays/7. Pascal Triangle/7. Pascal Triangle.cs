using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Рещих я, но с малко помощ от Кената!

            int n = int.Parse(Console.ReadLine());

            double[][] pascalTriangle = new double[n][];

            if (n >= 1)
            {
                pascalTriangle[0] = new[] { 1.0 };
            }

            if (n >= 2)
            {
                pascalTriangle[1] = new[] { 1.0, 1.0 };
            }
            
            for (int row = 2; row < n; row++)
            {
                pascalTriangle[row] = new double[row + 1];
                pascalTriangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }

                pascalTriangle[row][row] = 1;
            }

            foreach (double[] array in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
