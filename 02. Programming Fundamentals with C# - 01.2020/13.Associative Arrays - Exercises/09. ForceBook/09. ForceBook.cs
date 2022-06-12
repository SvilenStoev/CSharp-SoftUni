using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceBook = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string forceSide = input.Split(" | ")[0];
                    string forceUser = input.Split(" | ")[1];

                    AddUserToSide(forceBook, forceSide, forceUser);
                }
                else if (input.Contains(" -> "))
                {
                    string forceSide = input.Split(" -> ")[1];
                    string forceUser = input.Split(" -> ")[0];

                    foreach (var kvp in forceBook)
                    {
                        if (forceBook[kvp.Key].Contains(forceUser))
                        {
                            forceBook[kvp.Key].Remove(forceUser);
                        }
                    }

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook[forceSide] = new List<string>();
                    }

                    forceBook[forceSide].Add(forceUser);

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            var orderedBook = forceBook.OrderByDescending(x => x.Value.Count).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in orderedBook)
            {
                string forceSide = kvp.Key;
                var forceUsers = kvp.Value;

                if (forceUsers.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide}, Members: {forceUsers.Count}");
                }

                foreach (string user in forceUsers.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }

        static void AddUserToSide(Dictionary<string, List<string>> forceBook, string forceSide, string forceUser)
        {
            if (!forceBook.ContainsKey(forceSide))
            {
                forceBook[forceSide] = new List<string>();
            }

            if (!forceBook.Values.Any(l => l.Contains(forceUser)))
            {
                forceBook[forceSide].Add(forceUser);
            }
        }
    }
}
