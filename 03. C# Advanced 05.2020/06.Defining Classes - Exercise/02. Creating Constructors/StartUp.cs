using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = "Pesho";
            int age = 20;

            Person firstPerson = new Person(name, age);

            Console.WriteLine($"{firstPerson.Name} -> {firstPerson.Age}");

        }
    }
}
