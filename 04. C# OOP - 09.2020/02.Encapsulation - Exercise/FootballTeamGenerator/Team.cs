using FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private double rating;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = players.Find(p => p.Name == playerName);

            if (player == null)
            {
                throw new ArgumentException(string.Format(GlobalConstants.InvalidPlayerForRemovingExceptionMessage, playerName, this.Name));
            }

            players.Remove(player);
        }

        public double GetRating()
        {
            this.rating = 0;

            for (int i = 0; i < players.Count; i++)
            {
                this.rating += players[i].AverageStats();
            }

            return this.rating;
        }

        public override string ToString()
        {
            return $"{this.Name} - {Math.Ceiling(this.GetRating())}";
        }
    }
}
