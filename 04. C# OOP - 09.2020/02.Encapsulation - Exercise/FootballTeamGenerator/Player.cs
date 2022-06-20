using FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int STATS_MIN_VALUE = 0;
        private const int STATS_MAX_VALUE = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
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

        internal int Endurance
        {
            get
            {
                return this.endurance;
            }

            private set
            {
                if (value <= STATS_MIN_VALUE || value >= STATS_MAX_VALUE)
                {
                    throw new ArgumentException(string.Format(GlobalConstants.InsufficientStatsExceptionMessage, nameof(this.Endurance)));
                }

                this.endurance = value;
            }
        }

        internal int Sprint
        {
            get
            {
                return this.sprint;
            }

            private set
            {
                if (value <= STATS_MIN_VALUE || value >= STATS_MAX_VALUE)
                {
                    throw new ArgumentException(string.Format(GlobalConstants.InsufficientStatsExceptionMessage, nameof(this.Sprint)));
                }

                this.sprint = value;
            }
        }

        internal int Dribble
        {
            get
            {
                return this.dribble;
            }

            private set
            {
                if (value <= STATS_MIN_VALUE || value >= STATS_MAX_VALUE)
                {
                    throw new ArgumentException(string.Format(GlobalConstants.InsufficientStatsExceptionMessage, nameof(this.Dribble)));
                }

                this.dribble = value;
            }
        }

        internal int Passing
        {
            get
            {
                return this.passing;
            }

            private set
            {
                if (value <= STATS_MIN_VALUE || value >= STATS_MAX_VALUE)
                {
                    throw new ArgumentException(string.Format(GlobalConstants.InsufficientStatsExceptionMessage, nameof(this.Passing)));
                }

                this.passing = value;
            }
        }

        internal int Shooting
        {
            get
            {
                return this.shooting;
            }

            private set
            {
                if (value <= STATS_MIN_VALUE || value >= STATS_MAX_VALUE)
                {
                    throw new ArgumentException(string.Format(GlobalConstants.InsufficientStatsExceptionMessage, nameof(this.Shooting)));
                }

                this.shooting = value;
            }
        }

        public double AverageStats()
        {
            double averageStats = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
            
            return averageStats;
        }


    }
}
