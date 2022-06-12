using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades[studentName] = new List<double>();
                }

                studentsGrades[studentName].Add(studentGrade);
            }

            studentsGrades = studentsGrades.OrderByDescending(x => x.Value.Average()).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in studentsGrades)
            {
                double studentAverageGrade = kvp.Value.Average();

                if (studentAverageGrade >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {studentAverageGrade:f2}");
                }
            }
        }
    }
}
