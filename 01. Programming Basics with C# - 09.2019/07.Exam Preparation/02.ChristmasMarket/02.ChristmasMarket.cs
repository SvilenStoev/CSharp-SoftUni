using System;

namespace _02.ChristmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetSum = double.Parse(Console.ReadLine());
            int fantasyBooksPcs = int.Parse(Console.ReadLine());
            int horrorBooksPcs = int.Parse(Console.ReadLine());
            int romanticBooksPcs = int.Parse(Console.ReadLine());

            double totalMoneyFromFantazy = fantasyBooksPcs * 14.90;
            double totalMoneyFromHoror = horrorBooksPcs * 9.80;
            double totalMoneyFromRomantic = romanticBooksPcs * 4.30;

            double totalMoneyAfterTax = (totalMoneyFromFantazy + totalMoneyFromHoror + totalMoneyFromRomantic) * 0.8;

            if (totalMoneyAfterTax >= targetSum)
            {
                double differenceBetweenSums = totalMoneyAfterTax - targetSum;
                double organizatorsBonus = Math.Floor(differenceBetweenSums * 0.1);
                Console.WriteLine($"{(totalMoneyAfterTax - organizatorsBonus):f2} leva donated.");
                Console.WriteLine($"Sellers will receive {organizatorsBonus} leva.");
            }
            else
            {
                Console.WriteLine($"{(targetSum - totalMoneyAfterTax):f2} money needed.");
            }

            //problem 2: условни конструкции >=..


        }
    }
}
