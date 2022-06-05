using System;

namespace _04.GroupStage
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            int pointsSum = 0;
            int totalScored = 0;
            int totalReceived = 0;

            for (int currentGame = 1; currentGame <= gamesPlayed; currentGame++)
            {
                int goalsScored = int.Parse(Console.ReadLine());
                int goalsReceived = int.Parse(Console.ReadLine());

                if (goalsScored > goalsReceived)
                {
                    pointsSum += 3;
                }
                else if (goalsReceived == goalsScored)
                {
                    pointsSum += 1;
                }

                totalScored += goalsScored;
                totalReceived += goalsReceived;
            }

            if (totalScored >= totalReceived)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {pointsSum} points.");
                Console.WriteLine($"Goal difference: {totalScored - totalReceived}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalScored - totalReceived}.");
            }

        }
    }
}
