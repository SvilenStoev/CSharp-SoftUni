using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Models
{
   public class Cat
    {
        private int age;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public Cat(string name, int age, Owner owner)
            :this(name, age)
        {
            this.Owner = owner;
        }

        public string Name { get;}
        public Owner Owner { get; }

        public string Details()
        {
            return $"{this.Name} - {this.age} - {this.Owner.Name}";
        }
    }
}
