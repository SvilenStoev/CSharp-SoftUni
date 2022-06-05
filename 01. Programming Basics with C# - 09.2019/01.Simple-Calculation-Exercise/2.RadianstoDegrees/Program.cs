using System;

namespace _2.RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(rad * 180 / Math.PI));



        }
    }
}
