using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;

            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name { get; set; }
        public IReadOnlyList<Person> FirstTeam => this.firstTeam;

        public IReadOnlyList<Person> ReserveTeam => this.reserveTeam;

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.FirstTeam.Add(person);
            }
            else
            {
                this.ReserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"First team has {firstTeam.Count} players.")
                .AppendLine($"Reserve team has {ReserveTeam.Count} players.");

            return sb.ToString().TrimEnd();
        }
    }
}
