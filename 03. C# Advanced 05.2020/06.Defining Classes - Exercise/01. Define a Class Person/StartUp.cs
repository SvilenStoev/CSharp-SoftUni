using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person()
            {
                Name = "Pesho",
                Age = 20
            };

            Console.WriteLine($"{firstPerson.Name} -> {firstPerson.Age}");
        }
    }
}
