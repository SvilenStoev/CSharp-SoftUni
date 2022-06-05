using System;

namespace _8.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeter = double.Parse(Console.ReadLine());
            double price = squareMeter * 7.61;

            Console.WriteLine($"The final price is: {price - price * 0.18:f2} lv.");
            Console.WriteLine($"The discount is: {price * 0.18:f2} lv.");



        }
    }
}
