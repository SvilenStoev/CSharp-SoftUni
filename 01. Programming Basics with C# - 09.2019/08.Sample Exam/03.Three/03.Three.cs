using System;

namespace _03.Three
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restourantName = Console.ReadLine();
            int sushiCount = int.Parse(Console.ReadLine());
            char purchase = char.Parse(Console.ReadLine());
            bool invalidRestourant = false;

            double totalMoney = 0;

            if (restourantName == "Sushi Zone")
            {
                switch (sushiType)
                {
                    case "sashimi": totalMoney = sushiCount * 4.99; break;
                    case "maki": totalMoney = sushiCount * 5.29; break;
                    case "uramaki": totalMoney = sushiCount * 5.99; break;
                    case "temaki": totalMoney = sushiCount * 4.29; break;
                }
            }
            else if (restourantName == "Sushi Time")
            {
                switch (sushiType)
                {
                    case "sashimi": totalMoney = sushiCount * 5.49; break;
                    case "maki": totalMoney = sushiCount * 4.69; break;
                    case "uramaki": totalMoney = sushiCount * 4.49; break;
                    case "temaki": totalMoney = sushiCount * 5.19; break;
                }
            }
            else if (restourantName == "Sushi Bar")
            {
                switch (sushiType)
                {
                    case "sashimi": totalMoney = sushiCount * 5.25; break;
                    case "maki": totalMoney = sushiCount * 5.55; break;
                    case "uramaki": totalMoney = sushiCount * 6.25; break;
                    case "temaki": totalMoney = sushiCount * 4.75; break;
                }
            }
            else if (restourantName == "Asian Pub")
            {
                switch (sushiType)
                {
                    case "sashimi": totalMoney = sushiCount * 4.50; break;
                    case "maki": totalMoney = sushiCount * 4.80; break;
                    case "uramaki": totalMoney = sushiCount * 5.50; break;
                    case "temaki": totalMoney = sushiCount * 5.50; break;
                }
            }
            else
            {
                Console.WriteLine($"{restourantName} is invalid restaurant!");
                invalidRestourant = true;
            }

            if (purchase == 'Y')
            {
                totalMoney *= 1.2;
            }

            if (!invalidRestourant)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(totalMoney)} lv.");
            }

        }
    }
}
