using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    class Guild
    {
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public List<Player> Players { get; set; } = new List<Player>();

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get => this.Players.Count; }

        public void AddPlayer(Player player)
        {
            if (Players.Count < this.Capacity)
            {
                Players.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player currPlayer = Players.Find(p => p.Name == name);

            if (currPlayer != null)
            {
                Players.Remove(currPlayer);
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player currPlayer = Players.Find(p => p.Name == name);

            if (currPlayer != null)
            {
                currPlayer.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            Player currPlayer = Players
                .Find(p => p.Name == name);

            if (currPlayer != null)
            {
                currPlayer.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string classStr) 
        {
            //Is this filtered the players from the list?
            
            var removedPlayers = Players
                .Where(p => p.Class == classStr)
                .ToArray();

            Players.RemoveAll(p => p.Class == classStr);

            return removedPlayers;
        }

  

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Players in the guild: {this.Name}")
                .AppendLine($"{string.Join(Environment.NewLine, this.Players)}");

            return sb.ToString().TrimEnd();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Players in the guild: {this.Name}")
                .AppendLine($"{string.Join(Environment.NewLine, this.Players)}");

            return sb.ToString().TrimEnd();
        }
    }
}
