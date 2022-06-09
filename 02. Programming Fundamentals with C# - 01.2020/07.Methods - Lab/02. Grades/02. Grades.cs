using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            GradeInWords(grade);
        }

        static void GradeInWords(double num)
        {
            if (num < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (num < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (num < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (num < 5.5)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }

    }
}
