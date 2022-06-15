using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var VIPGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (IsVIPGuest(input))
                {
                    VIPGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();

            }

            while (input != "END")
            {
                if (IsVIPGuest(input) && VIPGuests.Contains(input))
                {
                    VIPGuests.Remove(input);
                }
                else if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(VIPGuests.Count + regularGuests.Count);

            PrintResult(VIPGuests);
            PrintResult(regularGuests);
        }

        private static void PrintResult(HashSet<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }

        private static bool IsVIPGuest(string input)
        {
            return int.TryParse(input[0].ToString(), out int result);
        }
    }
}
