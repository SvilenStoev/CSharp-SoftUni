using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double shipPrice = 0.00;

            switch (season)
            {
                case "Spring": shipPrice = 3000; break;
                case "Summer":
                case "Autumn": shipPrice = 4200; break;
                case "Winter": shipPrice = 2600; break;
            }

            if (fishermen <= 6)
            {
                shipPrice *= 0.9;
            }
            else if (fishermen > 6 && fishermen <= 11)
            {
                shipPrice *= 0.85;
            }
            else if (fishermen > 11)
            {
                shipPrice *= 0.75;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                shipPrice *= 0.95;
            }

            if (budget >= shipPrice)
            {
                Console.WriteLine($"Yes! You have {budget - shipPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {shipPrice - budget:f2} leva.");
            }

        }
    }
}
