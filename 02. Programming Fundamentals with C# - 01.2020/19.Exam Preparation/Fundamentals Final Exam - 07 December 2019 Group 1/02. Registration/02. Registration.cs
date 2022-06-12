using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var regex = new Regex(@"U\$([A-Z][a-z]{2,})U\$P@\$([A-Za-z]{5,}.*[0-9])P@\$");
            int successfulRegistrationsCount = 0;

            for (int i = 0; i < n; i++)
            {
                string registrationInput = Console.ReadLine();

                if (regex.IsMatch(registrationInput))
                {
                    Console.WriteLine("Registration was successful");
                    successfulRegistrationsCount++;

                    Match match = regex.Match(registrationInput);

                    string username = match.Groups[1].Value;
                    string password = match.Groups[2].Value;

                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}
