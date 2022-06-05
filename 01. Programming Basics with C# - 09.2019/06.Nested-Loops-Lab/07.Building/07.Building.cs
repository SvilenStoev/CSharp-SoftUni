using System;

namespace _07.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsCount = int.Parse(Console.ReadLine());

            for (int i = floorsCount; i > 0; i--)
            {
                for (int j = 0; j < roomsCount; j++)
                {
                    if (i == floorsCount)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
