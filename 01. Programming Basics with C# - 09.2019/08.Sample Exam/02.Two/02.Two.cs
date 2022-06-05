using System;

namespace _02.Two
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double spacemenHeight = double.Parse(Console.ReadLine());

            double totalSpace = width * length * height;
            double totalSpaceNeeded = 2.0 * 2.0 * (spacemenHeight + 0.4);

            double totalSpacemen = Math.Floor(totalSpace / totalSpaceNeeded);

            if (totalSpacemen > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else if (totalSpacemen >= 3)
            {
                Console.WriteLine($"The spacecraft holds {totalSpacemen} astronauts.");
            }
            else if (totalSpacemen < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }

           

        }
    }
}
