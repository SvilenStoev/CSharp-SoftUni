using System;

namespace _04.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int singerHonorar = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int totalGuestsCount = 0;
            int totalSum = 0;

            while (command != "The restaurant is full")
            {
                int people = int.Parse(command);
                if (people >= 5)
                {
                    totalSum += people * 70;
                }
                else
                {
                    totalSum += people * 100;
                }
                totalGuestsCount += people;
                command = Console.ReadLine();
            }

            if (totalSum >= singerHonorar)
            {
                Console.WriteLine($"You have {totalGuestsCount} guests and {totalSum - singerHonorar} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalGuestsCount} guests and {totalSum} leva income, but no singer.");
            }

            //Парсването на стринг към int!

        }
    }
}
