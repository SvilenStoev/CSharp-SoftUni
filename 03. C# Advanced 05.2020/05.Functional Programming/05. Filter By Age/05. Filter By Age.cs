using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            //доста трудна!

            int totalPeople = int.Parse(Console.ReadLine());

            Dictionary<string, int> peopleData = new Dictionary<string, int>();

            for (int i = 0; i < totalPeople; i++)
            {
                var currPersonData = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string currName = currPersonData[0];
                int currAge = int.Parse(currPersonData[1]); 

                if (!peopleData.ContainsKey(currName))
                {
                    peopleData[currName] = currAge;
                }
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<KeyValuePair<string, int>, bool> filterFunc = kvp => true;

            if (condition == "older")
            {
                filterFunc = kvp => kvp.Value >= age;
            }
            else if (condition == "younger")
            {
                filterFunc = kvp => kvp.Value < age;
            }

            peopleData
                .Where(filterFunc)
                .Select(kvp => format.Replace("name", kvp.Key).Replace(" ", " - ").Replace("age", kvp.Value.ToString()))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
