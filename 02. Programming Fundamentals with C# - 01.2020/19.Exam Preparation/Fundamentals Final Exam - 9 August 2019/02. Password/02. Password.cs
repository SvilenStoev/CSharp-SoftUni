using System;
using System.Text.RegularExpressions;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var regex = new Regex(@"(.+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<(\1)");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    string group1 = match.Groups[2].Value;
                    string group2 = match.Groups[3].Value;
                    string group3 = match.Groups[4].Value;
                    string group4 = match.Groups[5].Value;

                    string result = group1 + group2 + group3 + group4;


                    Console.WriteLine($"Password: {result}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
