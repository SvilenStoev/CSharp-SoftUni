using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double insertedMoney = 0.0;
            double totalMoneyNeeded = 0.0;
            string command = Console.ReadLine();
            bool check = true;

            while (command != "Start")
            {
                if (command == "0.1" || command == "0.2" || command == "0.5" ||
                    command == "1" || command == "2")
                {
                    insertedMoney += double.Parse(command);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double productPrice = 0.0;

                switch (product)
                {
                    case "Nuts": productPrice = 2.0; break;
                    case "Water": productPrice = 0.7; break;
                    case "Crisps": productPrice = 1.5; break;
                    case "Soda": productPrice = 0.8; break;
                    case "Coke": productPrice = 1.0; break;
                    default: Console.WriteLine("Invalid product"); check = false; break;
                }

                totalMoneyNeeded += productPrice;

                if (insertedMoney >= totalMoneyNeeded && check)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (check)
                {
                    Console.WriteLine("Sorry, not enough money");
                    totalMoneyNeeded -= productPrice;
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {insertedMoney - totalMoneyNeeded:f2}");
           
        }
    }
}
