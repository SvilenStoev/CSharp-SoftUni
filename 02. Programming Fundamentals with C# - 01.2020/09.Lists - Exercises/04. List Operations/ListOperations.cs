using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._List_Operations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string currentCommand = command.Split()[0];
                int number;
                int index;

                switch (currentCommand)
                {
                    case "Add":
                        number = AddNumber(numbers, command); break;

                    case "Insert":
                        number = int.Parse(command.Split()[1]);
                        index = int.Parse(command.Split()[2]);

                        if (index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, number);
                        }
                        break;

                    case "Remove":
                        index = int.Parse(command.Split()[1]);

                        if (index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(index);
                        }
                        break;

                    case "Shift":
                        int count = int.Parse(command.Split()[2]);
                        count %= numbers.Count;

                        if (command.Split()[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (command.Split()[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
            }

            Console.Write(string.Join(" ", numbers));
        }

        private static int AddNumber(List<int> integers, string command)
        {
            int number = int.Parse(command.Split()[1]);
            integers.Add(number);
            return number;
        }
    }
}
