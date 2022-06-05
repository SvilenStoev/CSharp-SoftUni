using System;

namespace Scholarship
{
    class Program
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double excellenceScholarship = 0;
            bool excellence = false;
            bool social = false;

            if (income < minimalSalary && average > 4.5)
            {
                socialScholarship = minimalSalary * 0.35;
            }
            if (average >= 5.5)
            {
                excellenceScholarship = average * 25;
            }

            if (socialScholarship > 0 || excellenceScholarship > 0)
            {
                if (excellenceScholarship >= socialScholarship)
                {
                    excellence = true;
                }
                else if (excellenceScholarship < socialScholarship)
                {
                    social = true;
                }
                else if (excellenceScholarship == socialScholarship)
                {
                    excellence = true;
                }
                else if (socialScholarship > 0 && excellenceScholarship == 0)
                {
                    social = true;
                }
                else if (socialScholarship == 0 && excellenceScholarship > 0)
                {
                    excellence = true;
                }
            }

            if (excellence)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellenceScholarship)} BGN");
            }
            else if (social)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}