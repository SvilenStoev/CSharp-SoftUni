using System;

namespace _03.PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string cookie = Console.ReadLine();
            int cokiesCount = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            if (date <= 15)
            {
                switch (cookie)
                {
                    case "Cake": totalPrice = cokiesCount * 24; break;
                    case "Souffle": totalPrice = cokiesCount * 6.66; break;
                    case "Baklava": totalPrice = cokiesCount * 12.60; break;
                }
            }
            else
            {
                switch (cookie)
                {
                    case "Cake": totalPrice = cokiesCount * 28.70; break;
                    case "Souffle": totalPrice = cokiesCount * 9.80; break;
                    case "Baklava": totalPrice = cokiesCount * 16.98; break;
                }
            }

            if (date <= 22 && totalPrice >= 100 && totalPrice <= 200)
            {
                totalPrice *= 0.85;
            }
            else if (date <= 22 && totalPrice > 200)
            {
                totalPrice *= 0.75;
            }
            if (date <= 15)
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
