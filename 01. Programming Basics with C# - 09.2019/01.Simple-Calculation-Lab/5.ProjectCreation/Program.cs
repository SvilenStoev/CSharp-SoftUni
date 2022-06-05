using System;

namespace _5.ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countProjects = int.Parse(Console.ReadLine());
            int area = countProjects * 3;

            Console.WriteLine($"The architect {name} will need {area} hours to complete {countProjects} project/s." );


        }
    }
}
