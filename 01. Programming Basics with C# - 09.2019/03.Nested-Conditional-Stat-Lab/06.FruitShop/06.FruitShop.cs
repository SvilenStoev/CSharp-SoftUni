using System;

namespace _06.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitName = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double fruitPrice = 0.00;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruitName)
                    {
                        case "banana": fruitPrice = 2.50; break;
                        case "apple": fruitPrice = 1.20; break;
                        case "orange": fruitPrice = 0.85; break;
                        case "grapefruit": fruitPrice = 1.45; break;
                        case "kiwi": fruitPrice = 2.70; break;
                        case "pineapple": fruitPrice = 5.50; break;
                        case "grapes": fruitPrice = 3.85; break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruitName)
                    {
                        case "banana": fruitPrice = 2.70; break;
                        case "apple": fruitPrice = 1.25; break;
                        case "orange": fruitPrice = 0.90; break;
                        case "grapefruit": fruitPrice = 1.60; break;
                        case "kiwi": fruitPrice = 3.00; break;
                        case "pineapple": fruitPrice = 5.60; break;
                        case "grapes": fruitPrice = 4.20; break;
                    }
                    break;
            }

            if (fruitPrice > 0)
            {
                Console.WriteLine($"{(fruitPrice * quantity):f2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
