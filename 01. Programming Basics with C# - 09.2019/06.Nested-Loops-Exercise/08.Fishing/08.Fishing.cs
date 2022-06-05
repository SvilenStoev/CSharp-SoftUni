using System;

namespace _08.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFish = int.Parse(Console.ReadLine());
            string fishName = string.Empty;
            double fishKg = 0.0;
            double sumProfit = 0;
            double totalProfit = 0;
            double sumTaxes = 0;
            double totalTaxes = 0;
            int fishCounter = 0;

            for (int i = 1; i <= totalFish; i++)
            {
                fishName = Console.ReadLine();
                if (fishName == "Stop")
                {
                    break;
                }

                fishKg = double.Parse(Console.ReadLine());
                fishCounter++;

                for (int currentDigit = 0; currentDigit < fishName.Length; currentDigit++)
                {
                    if (i % 3 == 0)
                    {
                        sumProfit += fishName[currentDigit];
                    }
                    else
                    {
                        sumTaxes += fishName[currentDigit];
                    }
                }
                totalProfit += sumProfit / fishKg;
                totalTaxes += sumTaxes / fishKg;
                sumProfit = 0;
                sumTaxes = 0;
            }
            if (totalFish == fishCounter)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }

            if (totalProfit >= totalTaxes)
            {
                Console.WriteLine($"Lyubo's profit from {fishCounter} fishes is {(totalProfit - totalTaxes):f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {(totalTaxes - totalProfit):f2} leva today.");
            }
        }
    }
}
