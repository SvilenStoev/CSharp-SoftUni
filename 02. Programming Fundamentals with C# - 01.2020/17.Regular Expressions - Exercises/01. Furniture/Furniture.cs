using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)");

            string input;
            int counter = 0;
            decimal totalMoneySpend = 0.0m;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                if (regex.IsMatch(input) && counter == 0)
                {
                    Console.WriteLine("Bought furniture:");
                    counter++;
                }

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    Console.WriteLine(match.Groups[1].Value);

                    totalMoneySpend += (decimal.Parse(match.Groups[2].Value) * decimal.Parse(match.Groups[3].Value));
                }
            }

            if (!(totalMoneySpend == 0.00m))
            {
                Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
            }
            else
            {
            }

        }
    }
}
