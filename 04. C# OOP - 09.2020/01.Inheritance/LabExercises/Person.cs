using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercises
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public string Address { get; protected set; }

    }
}
