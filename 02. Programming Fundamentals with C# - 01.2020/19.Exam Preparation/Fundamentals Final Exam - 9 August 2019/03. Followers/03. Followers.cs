using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            var followersLikes = new Dictionary<string, int>();
            var followersComments = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "Log out")
            {
                string[] commands = command.Split(": ").ToArray();
                string firstCommand = commands[0];
                string username = commands[1];

                switch (firstCommand)
                {
                    case "New follower":

                        if (!(followersComments.ContainsKey(username)))
                        {
                            followersLikes[username] = 0;
                            followersComments[username] = 0;
                        }
                        break;

                    case "Like":

                        int likesCount = int.Parse(commands[2]);

                        if (!(followersComments.ContainsKey(username)))
                        {
                            followersLikes[username] = likesCount;
                            followersComments[username] = 0;
                        }
                        else
                        {
                            followersLikes[username] += likesCount;
                        }
                        break;

                    case "Comment":

                        if (!(followersComments.ContainsKey(username)))
                        {
                            followersLikes[username] = 1;
                            followersComments[username] = 0;
                        }
                        else
                        {
                            followersLikes[username] += 1;
                        }
                        break;

                    case "Blocked":

                        if (!(followersComments.ContainsKey(username)))
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }
                        else
                        {
                            followersLikes.Remove(username);
                            followersComments.Remove(username);
                        }
                        break;
                }
            }

            Console.WriteLine($"{followersLikes.Count} followers");

            var sortedFollowers = followersLikes.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in sortedFollowers)
            {
                string username = kvp.Key;

                Console.WriteLine($"{username}: {kvp.Value + followersComments[username]}");
            }
        }
    }
}
