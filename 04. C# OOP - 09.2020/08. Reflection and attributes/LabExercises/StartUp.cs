using System;
using System.Reflection;

namespace LabExercises
{
    public class Program
    {
        static void Main()
        {
            //var cat = new Cat("Svilen");

            //var type = cat.GetType();

            //var field = type.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
            //var property = type.GetProperty("Name", BindingFlags.Public | BindingFlags.Instance);

            //field.SetValue(cat, "Pesho"); 
            //property.SetValue(cat, "Asd");

            //var constructors = type.GetConstructors();

            //Console.WriteLine(cat.Name); //Pesho

            var flags = SomeFlags.First | SomeFlags.Second;
            Console.WriteLine(flags);
        }
    }
}
