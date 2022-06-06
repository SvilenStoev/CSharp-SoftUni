using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal groupCount = decimal.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            decimal price = 0.0M;
            decimal totalPrice = 0.0M;
            decimal discountRate = 1.0M;

            if (groupType == "Students")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday": price = 8.45M; break;
                    case "Saturday": price = 9.80M; break;
                    case "Sunday": price = 10.46M; break;
                }

                if (groupCount >= 30)
                {
                    discountRate = 0.85M;
                }
            }
            else if (groupType == "Business")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday": price = 10.90M; break;
                    case "Saturday": price = 15.60M; break;
                    case "Sunday": price = 16.00M; break;
                }

                if (groupCount >= 100)
                {
                    //groupCount -= 10; one of the options, but will lose the real couns of the people
                    discountRate = (groupCount - 10) / (groupCount);
                }
            }
            else if (groupType == "Regular")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday": price = 15.00M; break;
                    case "Saturday": price = 20.00M; break;
                    case "Sunday": price = 22.50M; break;
                }

                if (groupCount >= 10 && groupCount <= 20)
                {
                    discountRate = 0.95M;
                }
            }

            totalPrice = (groupCount * price) * discountRate;
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
