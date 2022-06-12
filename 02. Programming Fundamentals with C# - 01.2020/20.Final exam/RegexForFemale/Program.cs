using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexForFemale
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"[A-Z][a-z]+[a] [A-Z][a-z]+[a]");

            var femalesStudentsPlaces = new Dictionary<string, int>();
            var femalesStudentsScores = new Dictionary<string, int>();

            var malesStudentsPlaces = new Dictionary<string, int>();
            var malesStudentsScores = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentData = input.Split("|").ToArray();

                string studentName = studentData[0];
                int place = int.Parse(studentData[1]);
                int scores = int.Parse(studentData[2]);

                if (!(femalesStudentsPlaces.ContainsKey(studentName)) && regex.IsMatch(studentName))
                {
                    femalesStudentsPlaces[studentName] = place;
                    femalesStudentsScores[studentName] = scores;
                }
                else
                {
                    malesStudentsPlaces[studentName] = place;
                    malesStudentsScores[studentName] = scores;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Female count: {femalesStudentsScores.Keys.Count}");
            Console.WriteLine($"Female average score: {femalesStudentsScores.Values.Average()}");

            Console.WriteLine($"Male count: {malesStudentsScores.Keys.Count}");
            Console.WriteLine($"Male average score: {malesStudentsScores.Values.Average()}");

            Console.WriteLine();
            Console.WriteLine("Search by Name and Username: ");
            string search = Console.ReadLine();

            Console.WriteLine($"The scores of {search} are: {malesStudentsScores[search]}");
            Console.WriteLine($"The place of {search} is: {malesStudentsPlaces[search]} out of {malesStudentsPlaces.Keys.Count + femalesStudentsPlaces.Keys.Count}");

            var sortedFemalesStudentsPlaces = femalesStudentsPlaces.OrderBy(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);
            var sortedMalesStudentsPlaces = malesStudentsPlaces.OrderBy(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);

            //    foreach (var kvp in sortedFemalesStudentsPlaces)
            //    {
            //        Console.WriteLine(kvp.Key);
            //        Console.WriteLine($"- Place: {kvp.Value}");
            //        Console.WriteLine($"- Total Scores: {femalesStudentsScores[kvp.Key]}");
            //        Console.WriteLine();
            //    }

            //    foreach (var kvp in sortedMalesStudentsPlaces)
            //    {
            //        Console.WriteLine(kvp.Key);
            //        Console.WriteLine($"- Place: {kvp.Value}");
            //        Console.WriteLine($"- Total Scores: {malesStudentsScores[kvp.Key]}");
            //        Console.WriteLine();
            //    }
        }
    }
}
