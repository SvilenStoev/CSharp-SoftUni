using Border_Control.Contract;
using Border_Control.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    public class StartUp
    {
        static void Main()
        {
            string command;

            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while ((command = Console.ReadLine()) != "End")
            {
                var currentObject = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currentObject.Length == 3)
                {
                    string name = currentObject[0];
                    int age = int.Parse(currentObject[1]);
                    string id = currentObject[2];

                    IIdentifiable identifiable = new Citizen(name, age, id);

                    identifiables.Add(identifiable);
                }
                else
                {
                    string model = currentObject[0];
                    string id = currentObject[1];

                    IIdentifiable identifiable = new Robot(model, id);
                    
                    identifiables.Add(identifiable);
                }
            }

            string fakeId = Console.ReadLine();

            List<string> fakeIds = new List<string>();

            foreach (var identifiable in identifiables)
            {
                string currId = identifiable.Id;
                int startIndex = currId.Length - 3;

                string lastDigits = currId.Substring(startIndex, 3);

                if (lastDigits == fakeId)
                {
                    fakeIds.Add(currId);
                }
            }

            foreach (var currFakeId in fakeIds)
            {
                Console.WriteLine(currFakeId);
            }
        }
    }
}
