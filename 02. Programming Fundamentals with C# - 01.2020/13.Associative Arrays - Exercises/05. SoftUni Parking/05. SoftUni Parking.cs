using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var licensesRegister = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputCommands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputCommands[0] == "register")
                {
                    RegisterNewParkingSpot(licensesRegister, inputCommands);
                }
                else
                {
                    UnregisterParkingSpot(licensesRegister, inputCommands);
                }
            }

            foreach (var kvp in licensesRegister)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

        }

        static void UnregisterParkingSpot(Dictionary<string, string> licensesRegister, List<string> inputCommands)
        {
            string username = inputCommands[1];

            if (licensesRegister.ContainsKey(username))
            {
                licensesRegister.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
        }

        static void RegisterNewParkingSpot(Dictionary<string, string> licensesRegister, List<string> inputCommands)
        {
            string username = inputCommands[1];
            string licensePlateNumber = inputCommands[2];

            if (licensesRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
            else
            {
                licensesRegister[username] = licensePlateNumber;
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        }
    }
}
