using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

            string input = Console.ReadLine();

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }


        }
    }
}
