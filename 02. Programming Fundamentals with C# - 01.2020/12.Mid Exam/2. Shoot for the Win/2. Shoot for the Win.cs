using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            int shotTargetsCount = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if (index >= 0 && index <= numbers.Count - 1)
                {
                    int shootedTarget = numbers[index];

                    if (!(numbers[index] == -1))
                    {
                        numbers[index] = -1;
                        shotTargetsCount++;
                    }

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == -1)
                        {
                            continue;
                        }

                        if (numbers[i] > shootedTarget)
                        {
                            numbers[i] -= shootedTarget;
                        }
                        else
                        {
                            numbers[i] += shootedTarget;
                        }
                    }

                }
            }

            Console.WriteLine($"Shot targets: {shotTargetsCount} -> {string.Join(" ", numbers)}");
        }
    }
}
