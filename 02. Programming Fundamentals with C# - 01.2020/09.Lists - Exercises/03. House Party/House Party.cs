using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ProceedMessage(guests);
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }

        }

        private static void ProceedMessage(List<string> guests)
        {
            string[] message = Console.ReadLine().Split().ToArray();
            string guestName = message[0];

            if (message[2] == "going!")
            {
                AddPerson(guests, guestName);
            }
            else
            {
                RemovePerson(guests, guestName);
            }
        }

        private static void AddPerson(List<string> guests, string guestName)
        {
            if (guests.Contains(guestName))
            {
                Console.WriteLine($"{guestName} is already in the list!");
            }
            else
            {
                guests.Add(guestName);
            }
        }

        private static void RemovePerson(List<string> guests, string guestName)
        {
            if (guests.Contains(guestName))
            {
                guests.Remove(guestName);
            }
            else
            {
                Console.WriteLine($"{guestName} is not in the list!");
            }
        }
    }
}
