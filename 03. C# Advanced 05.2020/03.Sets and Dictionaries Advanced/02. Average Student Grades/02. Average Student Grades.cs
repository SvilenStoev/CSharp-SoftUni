using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реших я, но е интересно да се види начин за форматиране на double-ли в string.join!

            int studentsCount = int.Parse(Console.ReadLine());

            var studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentData = Console.ReadLine().Split().ToArray();
                string currStudentName = studentData[0];
                decimal currStudentGrade = decimal.Parse(studentData[1]);

                if (!studentsGrades.ContainsKey(currStudentName))
                {
                    studentsGrades[currStudentName] = new List<decimal>();
                }

                studentsGrades[currStudentName].Add(currStudentGrade);
            }

            //foreach (var kvp in studentsGrades)
            //{
            //    Console.Write($"{kvp.Key} -> ");

            //    foreach (var grade in kvp.Value)
            //    {
            //        Console.Write($"{grade:f2} ");
            //    }

            //    Console.Write($"(avg: {kvp.Value.Average():f2})");
            //    Console.WriteLine();
            //}

            //По-добър начин за форматиране в string.join:

            foreach (var (nameKey, gradeValues) in studentsGrades)
            {
                string allGrades = string.Join(" ", gradeValues.Select(x => x.ToString("F2")));
                decimal averageGrade = gradeValues.Average();

                Console.WriteLine($"{nameKey} -> {allGrades} (avg: {averageGrade:f2})");
            }
        }
    }
}
