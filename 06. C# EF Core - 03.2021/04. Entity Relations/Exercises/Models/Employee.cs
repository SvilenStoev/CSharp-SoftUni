using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Exercises.Models
{
    public class Employee
    {
        public int PrKey { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        public DateTime? StartWorkDate { get; set; }

        public decimal Salary { get; set; }
        
        // optional
        public int DepartmentId { get; set; }

        // required property
        public Department Department { get; set; }

        [ForeignKey("Address")]
        public int? AddressId { get; set; }

        public Address Address { get; set; }


    }
}
