using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace First_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string newPassword = string.Empty;
            string inputCommands = Console.ReadLine();

            while (inputCommands != "Done")
            {
                List<string> inputList = inputCommands.Split().ToList();
                string command = inputList[0];

                if (command == "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPassword += password[i];
                        }
                    }
                    password = newPassword;
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(inputList[1]);
                    int count = int.Parse(inputList[2]);
                    password = password.Remove(startIndex, count);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = inputList[1];
                    string substitute = inputList[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                inputCommands = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}