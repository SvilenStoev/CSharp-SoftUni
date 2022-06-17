using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = this.people.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldestPerson;
        }

        public List<Person> GetPeopleByAge(int age)
        {
            return this.people
                .Where(p => p.Age > age)
                .OrderBy(p => p.Name)
                .ToList();
        }
    }
}
