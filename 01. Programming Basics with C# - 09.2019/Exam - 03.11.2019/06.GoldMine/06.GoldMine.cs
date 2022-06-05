using System;

namespace _06.GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMines = int.Parse(Console.ReadLine());
            double totalMining = 0.0;

            for (int currentMine = 1; currentMine <= totalMines; currentMine++)
            {
                double averageGoldMining = double.Parse(Console.ReadLine());
                int daysForCurrentMine = int.Parse(Console.ReadLine());

                for (int currentDay = 1; currentDay <= daysForCurrentMine; currentDay++)
                {
                    double GoldMiningForTheDay = double.Parse(Console.ReadLine());
                    totalMining += GoldMiningForTheDay;
                }

                double averageGoldCurrent = totalMining / daysForCurrentMine;

                if (averageGoldCurrent >= averageGoldMining)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldCurrent:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {(averageGoldMining - averageGoldCurrent):f2} gold.");
                }
                totalMining = 0;
            }
        }
    }
}
