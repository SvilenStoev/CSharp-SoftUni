using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> usernamesData = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string command = input.Split("->")[0];
                string username = input.Split("->")[1];

                if (command == "Add")
                {
                    AddUsername(usernamesData, username);
                }
                else if (command == "Send")
                {
                    SendEmail(usernamesData, input, username);
                }
                else if (command == "Delete")
                {
                    DeleteUsername(usernamesData, username);
                }
            }

            Console.WriteLine($"Users count: {usernamesData.Keys.Count}");

            var orderedUsernamesData = usernamesData.OrderByDescending(kvp => kvp.Value.Count).ThenBy(k => k.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in orderedUsernamesData)
            {
                Console.WriteLine(kvp.Key);

                foreach (var email in kvp.Value)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }

        private static void DeleteUsername(Dictionary<string, List<string>> usernamesData, string username)
        {
            if (usernamesData.ContainsKey(username))
            {
                usernamesData.Remove(username);
            }
            else
            {
                Console.WriteLine($"{username} not found!");
            }
        }

        private static void SendEmail(Dictionary<string, List<string>> usernamesData, string input, string username)
        {
            string email = input.Split("->")[2];

            usernamesData[username].Add(email);
        }

        private static void AddUsername(Dictionary<string, List<string>> usernamesData, string username)
        {
            if (!(usernamesData.ContainsKey(username)))
            {
                usernamesData[username] = new List<string>();
            }
            else
            {
                Console.WriteLine($"{username} is already registered");
            }
        }
    }
}
