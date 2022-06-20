using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private const int PERSON_MIN_AGE = 0;

        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            protected set
            {
                if (value < PERSON_MIN_AGE)
                {
                    throw new Exception("You are stupid!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Name: {this.Name}, Age: {this.Age}");

            return sb.ToString();
        }
    }
}
