using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith_02._11._2019___G1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponStrings = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string firstCommand = command.Split()[0];
                string secondCommand = command.Split()[1];

                if (firstCommand == "Move")
                {
                    int index = int.Parse(command.Split()[2]);

                    if (secondCommand == "Left")
                    {
                        if (index > 0 && index < weaponStrings.Count)
                        {
                            string temp = weaponStrings[index];
                            weaponStrings[index] = weaponStrings[index - 1];
                            weaponStrings[index - 1] = temp;

                            //weaponStrings.Insert(index - 1, weaponStrings[index]);
                            //weaponStrings.RemoveAt(index + 1);
                        }
                    }
                    else if (secondCommand == "Right")
                    {
                        if (index >= 0 && index < weaponStrings.Count - 1)
                        {
                            string temp = weaponStrings[index];
                            weaponStrings[index] = weaponStrings[index + 1];
                            weaponStrings[index + 1] = temp;

                            //weaponStrings.Insert(index + 2, weaponStrings[index]);
                            //weaponStrings.RemoveAt(index);
                        }
                    }
                }
                else if (firstCommand == "Check")
                {
                    if (secondCommand == "Even")
                    {
                        for (int i = 0; i < weaponStrings.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write($"{weaponStrings[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (secondCommand == "Odd")
                    {
                        for (int i = 0; i < weaponStrings.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write($"{weaponStrings[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }


            }

            Console.WriteLine($"You crafted {string.Join("", weaponStrings)}!");

        }
    }
}
