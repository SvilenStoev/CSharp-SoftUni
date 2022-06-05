using System;

namespace _12.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int counter = 1;
            double money = 10;
            double totalMoney = 0;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney = totalMoney + (10 * counter);
                    totalMoney--;
                    counter++;
                }
                else
                {
                    toys++;
                }
            }

            toyPrice *= toys;
            totalMoney += toyPrice;

            if (totalMoney >= price)
            {
                Console.WriteLine($"Yes! {(totalMoney - price):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(totalMoney - price):f2}");
            }

        }
    }
}
