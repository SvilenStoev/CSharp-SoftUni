using System;

namespace _07.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int counter = 1;
            double totalGrades = 0.00;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    totalGrades += grade;
                    counter++;
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {(totalGrades / (12)):f2}");

        }
    }
}
