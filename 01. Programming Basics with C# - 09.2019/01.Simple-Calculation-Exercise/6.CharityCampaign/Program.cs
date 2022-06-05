using System;

namespace _6.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakesTotal = cookers * cakes;
            double wafflesTotal = cookers * waffles;
            int pankakesTotal = cookers * pancakes;

            double totalSum = (cakesTotal * 45 + wafflesTotal * 5.80 + pankakesTotal * 3.20) * days;

            Console.WriteLine($"{totalSum - totalSum * 1/8:f2}");


        }
    }
}
