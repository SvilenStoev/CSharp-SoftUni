using System;

namespace _02.BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double profitPerDay = double.Parse(Console.ReadLine());
            double expensesForThePeriod = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalMoney = (pocketMoney + profitPerDay) * 5;

            double totalProfit = totalMoney - expensesForThePeriod;

            if (totalProfit >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalProfit:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {(giftPrice - totalProfit):f2} BGN.");
            }
        }
    }
}
