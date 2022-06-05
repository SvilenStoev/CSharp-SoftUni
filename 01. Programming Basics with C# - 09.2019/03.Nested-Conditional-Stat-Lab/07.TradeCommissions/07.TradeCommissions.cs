using System;

namespace _07.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0.00;

            if (sales >= 0 && sales <= 500)
            {
                switch (townName)
                {
                    case "Sofia": commission = sales * 0.05; break;
                    case "Varna": commission = sales * 0.045; break;
                    case "Plovdiv": commission = sales * 0.055; break;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (townName)
                {
                    case "Sofia": commission = sales * 0.07; break;
                    case "Varna": commission = sales * 0.075; break;
                    case "Plovdiv": commission = sales * 0.08; break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (townName)
                {
                    case "Sofia": commission = sales * 0.08; break;
                    case "Varna": commission = sales * 0.10; break;
                    case "Plovdiv": commission = sales * 0.12; break;
                }
            }
            else if (sales > 10000)
            {
                switch (townName)
                {
                    case "Sofia": commission = sales * 0.12; break;
                    case "Varna": commission = sales * 0.13; break;
                    case "Plovdiv": commission = sales * 0.145; break;
                }
            }

            if (commission > 0)
            {
                Console.WriteLine($"{commission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
