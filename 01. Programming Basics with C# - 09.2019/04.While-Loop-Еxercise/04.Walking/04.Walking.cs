using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;

            int totalStepForTheDay = 0;
            string command = string.Empty;
            int steps = 0;

            while (totalStepForTheDay < stepsGoal)
            {
                command = Console.ReadLine();

                if (command == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalStepForTheDay += steps;
                    break;
                }
                else
                {
                    steps = int.Parse(command);
                }
                totalStepForTheDay += steps;
            }

            if (totalStepForTheDay >= stepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else if (totalStepForTheDay < stepsGoal)
            {
                Console.WriteLine($"{stepsGoal - totalStepForTheDay} more steps to reach goal.");
            }

        }
    }
}
