using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamsData = Console.ReadLine().Split("-").ToArray();

                string creator = teamsData[0];
                string teamName = teamsData[1];

                Team currTeam = new Team(teamName, creator);
                 
                if (IsTeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (IsCreatorExists(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(currTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] commandData = command.Split("->");

                string member = commandData[0];
                string teamName = commandData[1];

                if (!IsTeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (IsUserExists(teams, member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    teams.Find(x => x.TeamName == teamName).Members.Add(member);
                }
            }

            foreach (Team team in teams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName))
            {
                List<string> sortedMembers = team.Members.OrderBy(member => member).ToList();

                if (team.Members.Count != 0)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.CreatorName}");

                    foreach (string member in sortedMembers)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teams.OrderBy(team => team.TeamName))
            {
                if (team.Members.Count == 0)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }

        private static bool IsUserExists(List<Team> teams, string member)
        {
            foreach (Team team in teams)
            {
                if (team.CreatorName == member || team.Members.Contains(member))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsCreatorExists(List<Team> teams, string creatorName)
        {
            foreach (Team team in teams)
            {
                if (team.CreatorName == creatorName)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsTeamExists(List<Team> teams, string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.TeamName == teamName)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
