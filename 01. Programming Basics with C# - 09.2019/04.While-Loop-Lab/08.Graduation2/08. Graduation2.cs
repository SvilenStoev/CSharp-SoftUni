using System;

namespace _08.Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int counter = 1;
            int counterPoorGrades = 0;
            double totalGrades = 0.00;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    totalGrades += grade;
                    counter++;
                }
                else
                {
                    counterPoorGrades++;
                    if (counterPoorGrades == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        return;
                    }
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {(totalGrades / (12)):f2}");

        }
    }
}
