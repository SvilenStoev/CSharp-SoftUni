using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            double moneyForTickets = 0.0;
            double moneyForTransport = 0.0;
            double totalExpenses = 0.0;

            if (peopleCount < 5)
            {
                moneyForTransport = budget * 0.75;
            }
            else if (peopleCount < 10)
            {
                moneyForTransport = budget * 0.60;
            }
            else if (peopleCount < 25)
            {
                moneyForTransport = budget * 0.50;
            }
            else if (peopleCount < 50)
            {
                moneyForTransport = budget * 0.40;
            }
            else if (peopleCount >= 50)
            {
                moneyForTransport = budget * 0.25;
            }

            if (category == "VIP")
            {
                moneyForTickets = peopleCount * 499.99;
                totalExpenses = moneyForTransport + moneyForTickets;

                if (totalExpenses <= budget)
                {
                    Console.WriteLine($"Yes! You have {(budget - totalExpenses):f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {totalExpenses - budget:f2} leva.");
                }
            }
            else if (category == "Normal")
            {
                moneyForTickets = peopleCount * 249.99;
                totalExpenses = moneyForTransport + moneyForTickets;

                if (totalExpenses <= budget)
                {
                    Console.WriteLine($"Yes! You have {budget - totalExpenses:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {totalExpenses - budget:f2} leva.");
                }
            }

        }
    }
}
