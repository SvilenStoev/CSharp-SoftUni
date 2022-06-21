using System;

namespace Shapes
{
   public class StartUp
    {
        static void Main()
        {
            Shape rectangle = new Rectangle(5.5, 4);

            Shape circle = new Circle(2);

            Console.WriteLine($"{rectangle.CalculateArea():f2}");
            Console.WriteLine($"{rectangle.CalculatePerimeter():f2}");

            Console.WriteLine($"{circle.CalculateArea():f2}");
            Console.WriteLine($"{circle.CalculatePerimeter():f2}");
        }
    }
}
