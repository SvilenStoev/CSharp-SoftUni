using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Избери напитка: ");
            string bevarage = Console.ReadLine();

            double Price = 0;

            switch (bevarage)
            {
                case "кафе": Price = 0.50; break;
                case "чай": Price = 0.70; break;
            }

            Console.WriteLine($"Вие избрахте {bevarage}. Дължите {Price:f2} лева.");

            Console.Write("Платете: ");
            double payment = double.Parse(Console.ReadLine());

            double change = payment - Price;
            Console.WriteLine();

            if (change < 0)
            {
                Console.WriteLine($"Трябва да доплатите {Math.Abs(payment - Price)} лева");
            }
            else
            {
                Console.WriteLine($"Вашето ресто е {change}.");
            }

            change *= 100;
            int coins2LV = 0;
            int coins1LV = 0;
            int coins50st = 0;
            int coins20st = 0;
            int coins10st = 0;
            int coins5st = 0;
            int coins2st = 0;
            int coins1st = 0;

            while (change > 0)
            {
                if (change >= 200)
                {
                    change -= 200;
                    coins2LV++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    coins1LV++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    coins50st++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    coins20st++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    coins10st++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    coins5st++;
                }
                else if (change >= 2)
                {
                    change -= 2;
                    coins2st++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    coins1st++;
                }
            }

            if (coins2LV > 0)
            {
                Console.WriteLine($"Машината връща {coins2LV} монети по 2 лева.");
            }
            if (coins1LV > 0)
            {
                Console.WriteLine($"Машината връща {coins1LV} монети по 1 лев.");
            }
            if (coins50st > 0)
            {
                Console.WriteLine($"Машината връща {coins50st} монети по 0.50 лева.");
            }
            if (coins20st > 0)
            {
                Console.WriteLine($"Машината връща {coins20st} монети по 0.20 лева.");
            }
            if (coins10st > 0)
            {
                Console.WriteLine($"Машината връща {coins10st} монети по 0.10 лева.");
            }
            if (coins5st > 0)
            {
                Console.WriteLine($"Машината връща {coins5st} монети по 0.05 лева.");
            }
            if (coins2st > 0)
            {
                Console.WriteLine($"Машината връща {coins2st} монети по 0.02 лева.");
            }
            if (coins1st > 0)
            {
                Console.WriteLine($"Машината връща {coins1st} монети по 0.01 лева.");
            }
        }
    }
}
