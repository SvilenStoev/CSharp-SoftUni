using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<int, int> add = x => x + 1; 
            Func<int, int> multiply = x => x * 2; 
            Func<int, int> subtract = x => x - 1; 
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            var command = Console.ReadLine();

            while (command != "end")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    switch (command)
                    {
                        case "add":
                            input[i] = add(input[i]);
                            break;

                        case "multiply": 
                            input[i] = multiply(input[i]);
                            break;

                        case "subtract": 
                            input[i] = subtract(input[i]);
                            break;
                    }
                }

                if (command == "print")
                {
                    print(input);
                }

                command = Console.ReadLine();
            }
        }
    }
}
