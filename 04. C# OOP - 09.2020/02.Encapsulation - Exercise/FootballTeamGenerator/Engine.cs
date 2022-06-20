using FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArg = command.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string teamName = commandArg[1];
                Team currTeam = null;

                try
                {
                    switch (commandArg[0])
                    {
                        case "Team":

                            currTeam = new Team(teamName);
                            teams.Add(currTeam);

                            break;

                        case "Add":

                            currTeam = CheckIfTeamExists(teamName);

                            string playerName = commandArg[2];
                            int playerEndurance = int.Parse(commandArg[3]);
                            int playerSprint = int.Parse(commandArg[4]);
                            int playerDribble = int.Parse(commandArg[5]);
                            int playerPassing = int.Parse(commandArg[6]);
                            int playerShooting = int.Parse(commandArg[7]);

                            Player currPlayer = new Player(playerName, playerEndurance, playerSprint, playerDribble, playerPassing, playerShooting);

                            currTeam.AddPlayer(currPlayer);

                            break;

                        case "Remove":

                            string currPlayerName = commandArg[2];

                            currTeam = CheckIfTeamExists(teamName);
                            currTeam.RemovePlayer(currPlayerName);

                            break;

                        case "Rating":

                            currTeam = CheckIfTeamExists(teamName);

                            Console.WriteLine(currTeam);

                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private Team CheckIfTeamExists(string teamName)
        {
            Team currTeam = teams.Find(t => t.Name == teamName);

            if (currTeam == null)
            {
                throw new ArgumentException(string.Format(GlobalConstants.InvalidTeamExceptionMessage, teamName));
            }

            return currTeam;
        }
    }
}
