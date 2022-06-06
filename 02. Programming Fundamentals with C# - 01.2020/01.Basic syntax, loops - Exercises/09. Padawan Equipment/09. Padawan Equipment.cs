using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyOwned = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalMoneyForLightsabers = (Math.Ceiling(studentsCount * 1.10)) * lightsabersPrice;
            double totalMoneyForRobes = studentsCount * robesPrice;
            double totalMoneyForBelts = (studentsCount * beltsPrice) - ((studentsCount / 6) * beltsPrice);

            double totalMoneyNeeded = totalMoneyForLightsabers + totalMoneyForBelts + totalMoneyForRobes;

            if (moneyOwned >= totalMoneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalMoneyNeeded - moneyOwned):f2}lv more.");
            }
        }
    }
}
