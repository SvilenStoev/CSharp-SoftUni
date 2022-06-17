using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            //не можах сам!

            var guests = Console.ReadLine()
                .Split()
                .ToList();

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                var commands = input.Split().ToArray();

                string cmdType = commands[0];
                string[] predicateArgs = commands.Skip(1).ToArray();

                Predicate<string> predicate = GetPredicate(predicateArgs);

                switch (cmdType)
                {
                    case "Remove":
                        guests.RemoveAll(predicate);
                        break;

                    case "Double":
                        DoubleGuests(guests, predicate);
                        break;
                }

                input = Console.ReadLine();
            }

            if (guests.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static void DoubleGuests(List<string> guests, Predicate<string> predicate)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                string currGuest = guests[i];

                if (predicate(currGuest))
                {
                    guests.Insert(i + 1, currGuest);
                    i++;
                }
            }
        }

        static Predicate<string> GetPredicate(string[] predicateArgs)
        {
            string prType = predicateArgs[0];
            string prArg = predicateArgs[1];

            Predicate<string> predicate = null;

            if (prType == "StartsWith")
            {
                predicate = name => name.StartsWith(prArg);
            }
            else if (prType == "EndsWith")
            {
                predicate = name => name.EndsWith(prArg);
            }
            else if (prType == "Length")
            {
                predicate = name => name.Length == int.Parse(prArg);
            }

            return predicate;
        }
    }
}
