using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b([0-9]{2})(\.|-|\/)([A-Z][a-z]{2})\2(\d{4})\b");

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
            }
        }
    }
}
