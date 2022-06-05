using System;

namespace _6.CircleAreaandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI; //Math.PI е функцията да изкара числото Пи = 3,141....
           
            Console.WriteLine($"{r*r*pi:f2}");
            Console.WriteLine($"{r*2*pi:f2}");
            

            
        }
    }
}
