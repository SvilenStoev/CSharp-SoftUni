using System;

namespace _99.Exercises___Lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .WithFirstName("Svilen")
                .WithLastName("Stoev")
                .WithAge(26)
                .Build();

            Console.WriteLine(person.FirstName);
        }
    }
}
 