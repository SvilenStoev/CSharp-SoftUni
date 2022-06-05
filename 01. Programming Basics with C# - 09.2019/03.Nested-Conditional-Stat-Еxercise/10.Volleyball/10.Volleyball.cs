using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - weekends;
            double GamesPlayed = weekendsInSofia * 3 / 4;

            GamesPlayed += weekends + (holidays * 2 / 3);

            if (yearType == "leap")
            {
                GamesPlayed *= 1.15;
            }
            
            Console.WriteLine(Math.Floor(GamesPlayed));

        }
    }
}
