using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                for (; moneyNeeded > savedMoney;)
                {
                    savedMoney = double.Parse(Console.ReadLine()) + savedMoney;
                }
                Console.WriteLine($"Going to {command}!");

                command = Console.ReadLine();
            }
        }
    }
}
