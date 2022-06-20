using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Pet : IPet, IIdentifiable, IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Birthdate { get; set; }

        public string Name { get; set; }

        public string Id { get; set; }
    }
}
