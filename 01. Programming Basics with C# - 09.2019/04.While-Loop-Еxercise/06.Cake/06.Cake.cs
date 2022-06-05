using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            double cakeVolume = width * length;
            double totalSlices = 0.00;
            string command;

            while (cakeVolume >= totalSlices && ((command = Console.ReadLine()) != "STOP"))
            {
                totalSlices += int.Parse(command);
            }

            if (cakeVolume >= totalSlices)
            {
                Console.WriteLine($"{cakeVolume - totalSlices} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {totalSlices - cakeVolume} pieces more.");
            }


        }
    }
}
