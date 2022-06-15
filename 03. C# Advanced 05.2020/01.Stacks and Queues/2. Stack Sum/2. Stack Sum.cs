using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>(numbers);

            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string currCommand = command.Split()[0];

                switch (currCommand)
                {
                    case "add":
                        myStack.Push(int.Parse(command.Split()[1]));
                        myStack.Push(int.Parse(command.Split()[2]));
                        break;

                    case "remove":
                        int count = int.Parse(command.Split()[1]);

                        if (myStack.Count >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                myStack.Pop();
                            }
                        }
                        break;
                }
            }

            Console.WriteLine($"Sum: {myStack.Sum()}");
        }
    }
}
