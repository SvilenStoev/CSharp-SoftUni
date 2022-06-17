using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    class Player
    {
        private string rank;
        private string description;

        public Player(string name, string classProp)
        {
            this.Name = name;
            this.Class = classProp;
            this.Rank = "Trial";
            this.Description = "n/a";
        }

        public string Name { get; set; }

        public string Class { get; set; }

        public string Rank { get; set; }
        
        public string Description { get; set; }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Player {this.Name}: {this.Class}")
                .AppendLine($"Rank: {this.Rank}")
                .AppendLine($"Description: {this.Description}");

            return sb.ToString().TrimEnd();
        }
    }
}
