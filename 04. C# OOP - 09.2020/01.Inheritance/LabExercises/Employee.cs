using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercises
{
    public class Employee : Person
    {
        public Employee(string name, string company) 
            : base(name)
        {
            this.Company = company;
        }

        public string Company { get; set; }


    }
}
