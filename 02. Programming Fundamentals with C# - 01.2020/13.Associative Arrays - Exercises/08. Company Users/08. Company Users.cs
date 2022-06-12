using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyUsers = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string companyName = input.Split(" -> ")[0];
                string employyeId = input.Split(" -> ")[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers[companyName] = new List<string>();
                }

                if (companyUsers[companyName].Contains(employyeId))
                {
                    continue;
                }


                companyUsers[companyName].Add(employyeId);
            }

            foreach (var kvp in companyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var employee in kvp.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
