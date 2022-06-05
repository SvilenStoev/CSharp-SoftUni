using System;

namespace _07.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());
            double totalAverage = 0;
            int topicCounter = 0;

            while (true)
            {
                string topic = Console.ReadLine();

                if (topic == "Finish")
                {
                    break;
                }
                topicCounter++;

                double gradeSum = 0;

                for (int i = 1; i <= judgesCount; i++)
                {
                    gradeSum += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{topic} - {(gradeSum / judgesCount):f2}.");
                totalAverage += gradeSum;
            }

            Console.WriteLine($"Student's final assessment is {(totalAverage/(topicCounter*judgesCount)):f2}.");


        }
    }
}
