using System;

namespace _04.Four
{
    class Program
    {
        static void Main(string[] args)
        {
            int singerSalary = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int totalMoney = 0;
            int totalGuests = 0;

            while (command != "The restaurant is full")
            {
                int guestsCount = int.Parse(command);
                totalGuests += guestsCount;

                if (guestsCount >= 5)
                {
                    totalMoney += guestsCount * 70;
                }
                else
                {
                    totalMoney += guestsCount * 100;
                }

                command = Console.ReadLine();
            }

            if (totalMoney >= singerSalary)
            {
                Console.WriteLine($"You have {totalGuests} guests and {totalMoney - singerSalary} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalGuests} guests and {totalMoney} leva income, but no singer.");
            }
        }
    }
}
