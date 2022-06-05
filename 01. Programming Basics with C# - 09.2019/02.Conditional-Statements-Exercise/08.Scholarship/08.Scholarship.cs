//Учениците могат да кандидатстват за социална стипендия или за стипендия за отличен успех. Изискване за социална стипендия - доход на член 
//от семейството по-малък от минималната работна заплата и успех над 4.5. Размер на социалната стипендия - 35% от минималната работна заплата.
//Изискване за стипендия за отличен успех - успех над 5.5, включително.Размер на стипендията за отличен успех - успехът на ученика, умножен по коефициент 25.
//Напишете програма, която при въведени доход, успех и минимална работна заплата, дава информация дали ученик има право да получава стипендия, и стойността на стипендията, 
//която е по-висока за него.

using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double mark = double.Parse(Console.ReadLine());
            double minIncome = double.Parse(Console.ReadLine());

            double socialScholarship = minIncome * 0.35;
            double excellentScholarship = mark * 25;

            if (mark < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (mark < 5.50 && income > minIncome)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (mark < 5.50 && income < minIncome)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }

            if (mark >= 5.50)
            {
                if (socialScholarship > excellentScholarship && income < minIncome)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
            }


        }
    }
}
