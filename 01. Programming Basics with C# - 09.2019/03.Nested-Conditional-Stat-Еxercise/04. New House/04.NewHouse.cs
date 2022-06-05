using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowersPrice = 0.00;

            switch (flowersType)
            {
                case "Roses":
                    flowersPrice = flowersCount * 5;
                    if (flowersCount > 80)
                    {
                        flowersPrice *= 0.9;
                    }
                    break;

                case "Dahlias":
                    flowersPrice = flowersCount * 3.80;
                    if (flowersCount > 90)
                    {
                        flowersPrice *= 0.85;
                    }
                    break;

                case "Tulips":
                    flowersPrice = flowersCount * 2.80;
                    if (flowersCount > 80)
                    {
                        flowersPrice *= 0.85;
                    }
                    break;

                case "Narcissus":
                    flowersPrice = flowersCount * 3;
                    if (flowersCount < 120)
                    {
                        flowersPrice *= 1.15;
                    }
                    break;

                case "Gladiolus":
                    flowersPrice = flowersCount * 2.50;
                    if (flowersCount < 80)
                    {
                        flowersPrice *= 1.20;
                    }
                    break;
            }

            if (budget >= flowersPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {(budget - flowersPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(flowersPrice - budget):f2} leva more.");
            }

        }
    }
}
