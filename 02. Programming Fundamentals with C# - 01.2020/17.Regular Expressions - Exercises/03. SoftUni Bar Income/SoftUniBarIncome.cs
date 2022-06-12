using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"%([A-Z][a-z]+)%.*?<(\w+)>.*\|(\d+)\|.*?(\d+\.*\d*)\$");

            string input;
            double productPrice = 0.0;
            double totalIncome = 0.0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    productPrice = double.Parse(match.Groups[3].ToString()) * double.Parse(match.Groups[4].ToString());

                    Console.WriteLine($"{match.Groups[1].Value}: {match.Groups[2].Value} - {productPrice:f2}");

                    totalIncome += productPrice;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
