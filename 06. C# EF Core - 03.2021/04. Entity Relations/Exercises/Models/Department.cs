using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
   public class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        // optional (inverse property)
        public ICollection<Employee> Employees { get; set; }
    }
}
