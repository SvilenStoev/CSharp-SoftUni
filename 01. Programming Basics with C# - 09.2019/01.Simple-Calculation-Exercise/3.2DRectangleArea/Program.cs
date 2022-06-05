using System;

namespace _3._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y2 - y1); //за да е положително число!

            Console.WriteLine($"{ a * b:f2}");
            Console.WriteLine($"{2 * (a + b):f2}");


        }
    }
}
