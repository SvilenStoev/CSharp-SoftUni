using System;

namespace _99.Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade > 6)
            {
                grade = 6;
            }
            else if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else if (grade >= 4.50)
            {
                Console.WriteLine("Very good!");
            }
            else if (grade >= 3.50)
            {
                Console.WriteLine("Very good!");
            }
            else if (grade >= 3.00)
            {
                Console.WriteLine("Average");
            }
            else if (grade >= 2.50)
            {
                Console.WriteLine("Poor");
            }


            if (grade == 6)
            {
                Console.WriteLine("Excellent!");

            }


        }
    }
}
