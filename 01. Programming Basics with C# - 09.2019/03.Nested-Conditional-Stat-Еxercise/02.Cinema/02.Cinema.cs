using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int totalChairs = rows * columns;
            double income = 0.00;

            if (projectionType == "Premiere")
            {
                income = totalChairs * 12.00;
            }
            else if (projectionType == "Normal")
            {
                income = totalChairs * 7.50;
            }
            else if (projectionType == "Discount")
            {
                income = totalChairs * 5.00;
            }

            Console.WriteLine($"{income:f2} leva");

        }
    }
}
