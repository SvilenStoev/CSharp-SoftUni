using System;

namespace OtherExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();

            Console.WriteLine(student.Address);


        }


        public class Person
        {
            public string Name { get; set; }
            public string Address { get; protected set; }
        }

        public class Student : Person
        {

            public Student()
            {
                base.Address = "Pesho"; //Мога да достъпвам пропърти на базовия клас и да го сетвам, понеже е Protected, но не мога да го сетвам в main например.
            }

            public string University { get; set; }
        }

    }
}
