using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            CreatorName = creatorName;

            Members = new List<string>();
        }
       
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}
