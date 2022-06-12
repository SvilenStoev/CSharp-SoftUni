using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Race
{
    class Race
    {
        static void Main(string[] args)
        {
            var getName = new Regex(@"[A-Za-z]+");
            var getDistance = new Regex(@"[0-9]");

            List<string> listOfParticipants = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> raceParticipants = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "end of race")
            {
                MatchCollection name = getName.Matches(command);
                MatchCollection distance = getDistance.Matches(command);

                string currName = string.Empty;
                int currDistance = 0;

                currName = string.Join("", name);

                foreach (Match digit in distance)
                {
                    currDistance += int.Parse(digit.ToString());
                }

                if (listOfParticipants.Contains(currName)) 
                {
                    if (!raceParticipants.ContainsKey(currName))
                    {
                        raceParticipants[currName] = 0;
                    }

                    raceParticipants[currName] += currDistance;
                }
            }

            int place = 1;

            foreach (var ndp in raceParticipants.OrderByDescending(ndp => ndp.Value))
            {
                if (place == 1)
                {
                    Console.WriteLine($"{place}st place: {ndp.Key}");
                }
                else if (place == 2)
                {
                    Console.WriteLine($"{place}nd place: {ndp.Key}");
                }
                else if (place == 3)
                {
                    Console.WriteLine($"{place}rd place: {ndp.Key}");
                }
                else
                {
                    break;
                }

                place++;
            }
        }
    }
}
