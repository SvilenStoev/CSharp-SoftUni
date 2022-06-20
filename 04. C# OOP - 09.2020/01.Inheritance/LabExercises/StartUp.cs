using System;

namespace LabExercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var person = new Employee("Svilen Stoev", "Vega Medical");

            Console.WriteLine(person.Company);
            Console.WriteLine(person.Name);


            var accountant = new Accountant("Svilen Stoev", "Vega Medical");

     

        }
    }
}
