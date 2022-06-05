using System;

namespace _03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string snookerStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            if (snookerStage == "Quarter final")
            {
                switch (ticketType)
                {
                    case "Standard": totalPrice = 55.50 * ticketsCount; break;
                    case "Premium": totalPrice = 105.20 * ticketsCount; break;
                    case "VIP": totalPrice = 118.90 * ticketsCount; break;
                }
            }
            else if (snookerStage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard": totalPrice = 75.88 * ticketsCount; break;
                    case "Premium": totalPrice = 125.22 * ticketsCount; break;
                    case "VIP": totalPrice = 300.40 * ticketsCount; break;
                }
            }
            else if (snookerStage == "Final")
            {
                switch (ticketType)
                {
                    case "Standard": totalPrice = 110.10 * ticketsCount; break;
                    case "Premium": totalPrice = 160.66 * ticketsCount; break;
                    case "VIP": totalPrice = 400 * ticketsCount; break;
                }
            }


            if (totalPrice > 4000)
            {
                totalPrice *= 0.75;
            }
            else if (totalPrice > 2500)
            {
                totalPrice *= 0.90;
                if (picture == 'Y')
                {
                    totalPrice += 40 * ticketsCount;
                }
            }
            else if (picture == 'Y')
            {
                totalPrice += 40 * ticketsCount;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
