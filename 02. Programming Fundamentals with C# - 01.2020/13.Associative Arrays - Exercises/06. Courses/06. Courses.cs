using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courseStudentsData = new Dictionary<string, List<string>>();
            string data;

            while ((data = Console.ReadLine()) != "end")
            {
                var dataList = data.Split(" : ").ToList();
                string course = dataList[0];
                string studentName = dataList[1];

                if (!courseStudentsData.ContainsKey(course))
                {
                    courseStudentsData[course] = new List<string>();
                }

                courseStudentsData[course].Add(studentName);
            }

            foreach (var kvp in courseStudentsData.OrderByDescending(x => x.Value.Count))
            {
                var courseName = kvp.Key;
                var registeredStudents = kvp.Value.Count;

                Console.WriteLine($"{courseName}: {registeredStudents}");

                foreach (var name in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }

            }

        }
    }
}
