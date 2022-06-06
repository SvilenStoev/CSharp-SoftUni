using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            int counter = 0;
            double totalExpneses = 0.0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if (i % 3 == 0 && i % 2 == 0)
                {
                    keyboardCount++;
                    counter++;

                    if (counter % 2 == 0)
                    {
                        displayCount++;
                    }

                }
            }

            totalExpneses = headsetCount * headsetPrice + mouseCount * mousePrice +
                keyboardCount * keyboardPrice + displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpneses:f2} lv.");

        }
    }
}
