using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double totalWater = H * (P1 + P2);

            double P1Procentage = (P1 * H) / totalWater * 100;
            double P2Procentage = (P2 * H) / totalWater * 100;

            double procentagePool = totalWater / V * 100;

            if (totalWater <= V)
            {
                Console.WriteLine($"The pool is {procentagePool:F2}% full. Pipe 1: {P1Procentage:f2}%. Pipe 2: {P2Procentage:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {H:f2} hours the pool overflows with {(totalWater - V):f2} liters.");
            }            

        }
    }
}
