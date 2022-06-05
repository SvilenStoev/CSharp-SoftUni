using System;

namespace _07.AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.
            Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle). 
            На първия ред на входа се чете вида на фигурата(square, rectangle, circle или triangle). 
            Ако фигурата е квадрат, на следващия ред се чете едно число -дължина на страната му.Ако фигурата е правоъгълник,
            на следващите два реда четат две числа -дължините на страните му.Ако фигурата е кръг, на следващия ред чете
            едно число - радиусът на кръга. Ако фигурата е триъгълник, на следващите два реда четат две числа -дължината 
            на страната му и дължината на височината към нея.Резултатът да се закръгли до 3 цифри след десетичната точка. */

            Console.Write("Въведи фигура: ");
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                Console.Write("Въведи страна на квадрат: ");
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                Console.Write("Въведи дължина на правоъгълник: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Въведи ширина на правоъгълник: ");
                double side2 = double.Parse(Console.ReadLine());
                area = side1 * side2;
            }
            else if (figure == "circle")
            {
                Console.Write("Въведи радиус на кръг: ");
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
            }
            else if (figure == "triangle")
            {
                Console.Write("Въведи дължина на страна: ");
                double side3 = double.Parse(Console.ReadLine());
                Console.Write("Въведи дължина на дължината към нея: ");
                double side4 = double.Parse(Console.ReadLine());
                area = (side3 * side4) / 2;
            }

            Console.WriteLine($"{area:f3}");

            }
    }
}
