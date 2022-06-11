using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split().ToArray();
                int index = int.Parse(commands[1]);

                switch (commands[0])
                {
                    case "Shoot":
                        int power = int.Parse(commands[2]);

                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= power;

                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;

                    case "Add":
                        int value = int.Parse(commands[2]);

                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;

                    case "Strike": 
                        int radius = int.Parse(commands[2]);

                        if (index >= 0 && index < targets.Count && ((index + radius) < targets.Count) && ((index - radius) >= 0))
                        {
                            targets.RemoveAt(index);

                            for (int i = 0; i < radius; i++)
                            {
                                targets.RemoveAt(index - i);
                                targets.RemoveAt(index - i - 1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                        break;
                }
            }

            Console.WriteLine($"{string.Join("|", targets)}");
        }
    }
}
