using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
