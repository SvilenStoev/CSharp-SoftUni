using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int width = int.Parse(Console.ReadLine()); ;
            int length = int.Parse(Console.ReadLine()); ;
            int height = int.Parse(Console.ReadLine()); ;
            string command = Console.ReadLine();

            //calc
            int capacity = width * length * height;
            int boxes = 0;

            //while compand
            while (command != "Done")
            {
                boxes += int.Parse(command);
                if (boxes > capacity)
                {
                    Console.WriteLine($"No more free space! You need {boxes - capacity} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }

            if (capacity >= boxes)
            {
                Console.WriteLine($"{capacity - boxes} Cubic meters left.");
            }

        }
    }
}
