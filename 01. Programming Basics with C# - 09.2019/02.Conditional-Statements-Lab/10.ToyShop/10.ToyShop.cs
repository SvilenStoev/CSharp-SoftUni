using System;

namespace _10.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            От конзолата се четат 6 реда:
            //            1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //           2.Брой пъзели - цяло число в интервала[0… 1000]
            //           3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //           4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //           5.Брой миньони - цяло число в интервала[0 … 1000]
            //           6.Брой камиончета - цяло число в интервала[0 … 1000]

            double price = double.Parse(Console.ReadLine());
            int numOfPuzzels = int.Parse(Console.ReadLine());
            int numOfDolls = int.Parse(Console.ReadLine());
            int numOfBears = int.Parse(Console.ReadLine());
            int numOfMinions = int.Parse(Console.ReadLine());
            int numOfTrucks = int.Parse(Console.ReadLine());

            double totalRevenue = (numOfPuzzels * 2.60 + numOfDolls * 3 + numOfBears * 4.10 + numOfMinions * 8.20 + numOfTrucks * 2);
            int totalSumToys = (numOfPuzzels + numOfDolls + numOfBears + numOfMinions + numOfTrucks);

            if (totalSumToys >= 50)
            {
                totalRevenue = totalRevenue * 0.75;
            }

            totalRevenue = totalRevenue * 0.90;
                        
            if (totalRevenue >= price)
            {
                Console.WriteLine($"Yes! {totalRevenue - price:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(totalRevenue - price):F2} lv needed.");
            }

        }
    }
}
