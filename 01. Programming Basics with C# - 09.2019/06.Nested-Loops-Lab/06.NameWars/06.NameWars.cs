using System;

namespace _06.NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string winnerName = string.Empty;
            int winnerSum = 0;

            while (command != "STOP")
            {
                int sum = 0;

                for (int i = 0; i < command.Length; i++)
                {
                    sum += command[i];
                }

                if (sum > winnerSum)
                {
                    winnerSum = sum;
                    winnerName = command;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winnerName} - {winnerSum}!");

        }
    }
}
