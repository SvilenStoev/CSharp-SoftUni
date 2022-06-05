using System;

namespace _7.AlchoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerNum = double.Parse(Console.ReadLine());
            double wineNum = double.Parse(Console.ReadLine());
            double rakiaNum = double.Parse(Console.ReadLine());
            double whiskeyNum = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice * 0.60;
            double beerPrice = rakiaPrice * 0.20;
           
            Console.WriteLine($"{whiskeyPrice*whiskeyNum + beerNum*beerPrice + wineNum*winePrice + rakiaNum*rakiaPrice:f2}");

        }
    }
}
