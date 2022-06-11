using System;

namespace _1._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string command;
            int wins = 0;
            bool endOfTheGame = false;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);

                if (initialEnergy >= distanceToEnemy)
                {
                    wins++;
                    initialEnergy -= distanceToEnemy;

                    if (wins % 3 == 0)
                    {
                        initialEnergy += wins;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {initialEnergy} energy");
                    endOfTheGame = true;
                    break;
                }
            }

            if (!endOfTheGame)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {initialEnergy}");
            }
        }
    }
}
