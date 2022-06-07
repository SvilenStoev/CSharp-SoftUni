using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, height, volume = 0;
            Console.WriteLine("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.WriteLine("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            height = double.Parse(Console.ReadLine());
            volume = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
