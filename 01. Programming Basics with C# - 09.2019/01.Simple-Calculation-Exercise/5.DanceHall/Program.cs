using System;

namespace _5.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double squareRoom = L * W;
            double chairs = squareRoom / 10;
            double wardrobe = A * A;

            double freeRoom = squareRoom - chairs - wardrobe;
            double numDancers = Math.Floor(freeRoom / (0.004 + 0.7)); //Закръгляме надолу, защото не може да се поберат ако са 5,5 човека..
            
            Console.WriteLine(numDancers);
            // Console.WriteLine("{0}", Math.Floor(freeRoom / (0.004 + 0.7))); И така работи!
                       
        }
    }
}
