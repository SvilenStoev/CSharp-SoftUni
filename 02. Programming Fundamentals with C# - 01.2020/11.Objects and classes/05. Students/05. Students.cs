using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currStudentData = input.Split();

                Student currStudent = new Student();

                currStudent.FirstName = currStudentData[0];
                currStudent.LastName = currStudentData[1];
                currStudent.Age = int.Parse(currStudentData[2]);
                currStudent.Hometown = currStudentData[3];

                students.Add(currStudent);
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

            //Functional programming:
            //students.Where(x => x.Hometown == town).ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
        }
    }
}
