using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] studentData = Console.ReadLine().Split().ToArray();

                string firstName = studentData[0];
                string lastName = studentData[1];
                double grade = double.Parse(studentData[2]);

                Student currStudent = new Student(firstName, lastName, grade);

                students.Add(currStudent);
            }

            students.OrderByDescending(x => x.Grade).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
