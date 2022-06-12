using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\+[3][5][9](\s{1}|-)[2]\1[0-9]{3}\1[0-9]{4}\b");

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            Console.Write(string.Join(", ", matches));

        }
    }
}
