using Border_Control.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control.Models
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, int age, string Id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

    }
}
