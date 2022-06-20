using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string ID, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = ID;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public string Birthdate { get; set; }

        public int Food { get; private set; } = 0;

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
