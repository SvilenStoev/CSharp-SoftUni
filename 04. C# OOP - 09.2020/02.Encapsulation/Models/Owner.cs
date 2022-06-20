using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Owner
    {
        private List<Cat> cats;

        public Owner(string name)
        {
            this.Name = name;

            this.cats = new List<Cat>();
        }

        public string Name { get; }

        public void AddCat(string name, int age)
        {
            Cat cat = new Cat(name, age, this);

            this.cats.Add(cat);
        }
    }
}
