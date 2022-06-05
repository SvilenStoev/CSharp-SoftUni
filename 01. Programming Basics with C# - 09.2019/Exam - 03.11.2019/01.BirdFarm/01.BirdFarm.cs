using System;

namespace _01.BirdFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggPrice = int.Parse(Console.ReadLine());
            int chickenCount = int.Parse(Console.ReadLine());
            int chickenBought2Month = int.Parse(Console.ReadLine());
            int chickenBought3Month = int.Parse(Console.ReadLine());

            double totalEggs = chickenCount * 2 * 30 / 3;
            chickenCount += chickenBought2Month;
            totalEggs += chickenCount * 2 * 30 / 3;

            chickenCount += chickenBought3Month;
            totalEggs += chickenCount * 2 * 30 / 3;

            totalEggs *= 0.96;

            double profit = (totalEggs * eggPrice / 100);

            Console.WriteLine($"Profit: {Math.Floor(profit)} Lv.");
        }
    }
}
