using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string currentCommand = command.Split()[0];
                int currentElement = int.Parse(command.Split()[1]);

                switch (currentCommand)
                {
                    case "Delete":
                        while (integers.Contains(currentElement))
                        {
                            integers.Remove(currentElement);
                        }

                        break;

                    case "Insert":
                        int index = int.Parse(command.Split()[2]);

                        integers.Insert(index, currentElement);
                        break;
                }
            }

            Console.Write(string.Join(" ", integers));

        }
    }
}
