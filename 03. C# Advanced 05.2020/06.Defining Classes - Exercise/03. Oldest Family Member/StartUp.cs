using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var personDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                var currPersonName = personDetails[0];
                var currPersonAge = int.Parse(personDetails[1]);

                var currPerson = new Person(currPersonName, currPersonAge);

                family.AddMember(currPerson);
            }

            int age = 30;

            foreach (var person in family.GetPeopleByAge(age))
            {
                Console.WriteLine(person);
            }
        }
    }
}
