using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendCounter = 0;

            while (currentMoney < moneyForVacation && spendCounter < 5)
            {
                days++;
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (command == "save")
                {
                    currentMoney += money;
                    spendCounter = 0;
                }
                else if (command == "spend")
                {
                    if (currentMoney < money)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= money;
                    }
                    spendCounter++;
                }

            }

            if (spendCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
            }
            else if (currentMoney >=  moneyForVacation)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }

        }
    }
}
