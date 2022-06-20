using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercises
{
    public class Student : Person
    {
        public Student(string name)
            :base(name)
        {
            this.Address = "Pesho";
        }

        public string University { get; set; }
    }
}
