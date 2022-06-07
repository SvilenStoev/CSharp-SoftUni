using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte tankCapacity = 255;
            int totalLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                totalLiters += liters;

                if (totalLiters > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= liters;
                }
            }

            Console.WriteLine(totalLiters);
        }
    }
}
