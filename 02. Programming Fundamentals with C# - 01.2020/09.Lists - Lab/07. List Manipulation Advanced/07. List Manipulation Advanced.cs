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
            List<int> numbersBeforeEdit = numbers.ToList();

            string command = Console.ReadLine();
            bool printTheList = false;

            while (command != "end")
            {
                string[] commandArray = command.Split();

                if (commandArray[0] == "Add" || commandArray[0] == "Remove" || commandArray[0] == "RemoveAt" || commandArray[0] == "Insert")
                {
                    printTheList = true;
                }

                ListManipulaterBasics(commandArray, numbers);
                ListManipulaterAdvanced(commandArray, numbers);

                command = Console.ReadLine();
            }

            if (printTheList)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static void ListManipulaterBasics(string[] commandArray, List<int> numbers)
        {
            switch (commandArray[0])
            {
                case "Add":
                    numbers.Add(int.Parse(commandArray[1]));
                    break;

                case "Remove":
                    numbers.Remove(int.Parse(commandArray[1]));
                    break;

                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(commandArray[1]));
                    break;

                case "Insert":
                    numbers.Insert(int.Parse(commandArray[2]), int.Parse(commandArray[1]));
                    break;
            }
        }

        static void ListManipulaterAdvanced(string[] commandArray, List<int> numbers)
        {
            switch (commandArray[0])
            {
                case "Contains":
                    if (numbers.Contains(int.Parse(commandArray[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;

                case "PrintEven":

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case "PrintOdd":

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;

                case "Filter":

                    switch (commandArray[1])
                    {
                        case "<":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < int.Parse(commandArray[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;

                        case ">":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > int.Parse(commandArray[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;

                        case ">=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= int.Parse(commandArray[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;

                        case "<=":
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= int.Parse(commandArray[2]))
                                {
                                    Console.Write($"{numbers[i]} ");
                                }
                            }
                            Console.WriteLine();
                            break;
                    }

                    break;
            }
        }
    }
}