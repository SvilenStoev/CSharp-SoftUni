using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateRectangleArea(width, height));
        }

        static int CalculateRectangleArea(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
