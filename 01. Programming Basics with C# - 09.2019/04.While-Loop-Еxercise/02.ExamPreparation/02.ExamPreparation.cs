using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrade = int.Parse(Console.ReadLine());

            int counter = 0;
            int poorGrades = 0;
            double sumGrades = 0.00;
            string lastProblem = string.Empty;
            int grade = 0;

            while (maxPoorGrade != poorGrades)
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    Console.WriteLine($"Average score: {(sumGrades / counter):f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                lastProblem = taskName;
                grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                counter++;

                if (grade <= 4)
                {
                    poorGrades++;
                }

            }

            if (maxPoorGrade == poorGrades)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }

        }
    }
}
