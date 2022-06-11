using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string currentCommand = command.Split()[0];
                int firstNumber = int.Parse(command.Split()[1]);

                switch (currentCommand)
                {
                    case "Add":
                        numbers.Add(firstNumber);
                        break;

                    case "Remove":
                        numbers.Remove(firstNumber);
                        break;

                    case "RemoveAt":
                        numbers.RemoveAt(firstNumber);
                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(command.Split()[2]), firstNumber);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
