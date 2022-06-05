using System;

namespace _01.One
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFoodPerDay = double.Parse(Console.ReadLine());
            double moneyForSouveniersPerDay = double.Parse(Console.ReadLine());
            double moneyForHotelPerDay = double.Parse(Console.ReadLine());

            double moneyForFuel = 420.00 / 100.00 * 7 * 1.85;

            double moneyAllDays = moneyForFoodPerDay * 3 + moneyForSouveniersPerDay * 3;
            double moneyForHotel1 = moneyForHotelPerDay * 0.9;
            double moneyForHotel2 = moneyForHotelPerDay * 0.85;
            double moneyForHotel3 = moneyForHotelPerDay * 0.8;

            double totalMoney = moneyForFuel + moneyAllDays + moneyForHotel1 + moneyForHotel2 + moneyForHotel3;

            Console.WriteLine($"Money needed: {totalMoney:f2}");
            
        }
    }
}
