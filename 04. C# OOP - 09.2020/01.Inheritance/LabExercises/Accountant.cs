using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercises
{
    public class Accountant : Employee
    {
        public Accountant(string name, string company)
          : base(name, company)
        {

        }

        public string AccountingProgram { get; set; }


    }
}
