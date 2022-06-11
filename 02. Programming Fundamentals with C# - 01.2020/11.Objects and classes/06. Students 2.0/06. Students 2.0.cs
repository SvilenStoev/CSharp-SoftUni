using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2._0
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

                string firstName = currStudentData[0];
                string lastName = currStudentData[1];
                int age = int.Parse(currStudentData[2]);
                string hometown = currStudentData[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    foreach (Student student in students)
                    {
                        if (student.FirstName == firstName && student.LastName == lastName)
                        {
                            student.Age = age;
                            student.Hometown = hometown;
                        }
                    }
                }
                else
                {
                    Student currStudent = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    };

                    students.Add(currStudent);
                }
            }

            string town = Console.ReadLine();

            students.Where(x => x.Hometown == town).ToList().ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
