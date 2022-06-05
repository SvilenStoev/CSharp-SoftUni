using System;

namespace _08.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationDays = double.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double nights = vacationDays - 1;
            double totalPrice = 0.00;

            if (roomType == "room for one person")
            {
                totalPrice = nights * 18;
            }
            else if (roomType == "apartment")
            {
                if (vacationDays < 10)
                {
                    totalPrice = (nights * 25) * 0.7;
                }
                else if (vacationDays >= 10 && vacationDays <= 15)
                {
                    totalPrice = (nights * 25) * 0.65;
                }
                else if (vacationDays > 15)
                {
                    totalPrice = (nights * 25) * 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                if (vacationDays < 10)
                {
                    totalPrice = (nights * 35) * 0.9;
                }
                else if (vacationDays >= 10 && vacationDays <= 15)
                {
                    totalPrice = (nights * 35) * 0.85;
                }
                else if (vacationDays > 15)
                {
                    totalPrice = (nights * 35) * 0.80;
                }
            }

            if (feedback == "positive")
            {
                totalPrice *= 1.25;
            }
            else if (feedback == "negative")
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine($"{totalPrice:f2}");

        }

    }
}
