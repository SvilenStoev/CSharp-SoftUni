using System;
using System.Collections.Generic;
using System.Text;

namespace OtherExcercises
{
    public class Person
    {
        private int age;

        public Person(int age)
        {
            this.Age = age;
        }


        public int Age
        {
            get
            {
                return this.age; 
            }
            set 
            {
                this.age = value;
            }
        }


    }
}
