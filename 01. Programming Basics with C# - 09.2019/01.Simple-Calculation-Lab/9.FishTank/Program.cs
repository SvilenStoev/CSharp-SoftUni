using System;

namespace _9.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procentage = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double totalLiters = volume * 0.001;
            
            Console.WriteLine($"{totalLiters*(1-procentage/100):f3}"); //Може и Console.WriteLine($"{totalLiters - totalLiters*procentage/100:f2}");


        }
    }
}
