using Border_Control.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var buyers = new List<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] currObject = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currObject.Length == 4)
                {
                    string name = currObject[0];
                    int age = int.Parse(currObject[1]);
                    string id = currObject[2];
                    string birthdate = currObject[3];

                    var currCitizen = new Citizen(name, age, id, birthdate);

                    buyers.Add(currCitizen);
                }
                else
                {
                    string name = currObject[0];
                    int age = int.Parse(currObject[1]);
                    string group = currObject[2];

                    var currRebel = new Rebel(name, age, group);

                    buyers.Add(currRebel);
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string name = command;

                if (buyers.Any(buyer => buyer.Name == name))
                {
                    IBuyer currObject = buyers.First(buyer => buyer.Name == name);
                    currObject.BuyFood();
                }
            }

            int totalFood = 0;

            foreach (var currObject in buyers)
            {
                totalFood += currObject.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}




