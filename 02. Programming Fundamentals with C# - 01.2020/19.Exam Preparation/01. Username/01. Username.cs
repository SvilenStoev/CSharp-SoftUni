using System;
using System.Linq;

namespace _01._Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Sing up")
            {
                string[] commands = command.Split().ToArray();
                string currCommand = commands[0];
                string secondCommand = commands[1];


                switch (currCommand)
                {
                    case "Case":
                        if (secondCommand == "lower")
                        {
                            username = username.ToLower();
                            Console.WriteLine(username);
                        }
                        else if (secondCommand == "upper")
                        {
                            username = username.ToUpper();
                            Console.WriteLine(username);
                        }
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(secondCommand);
                        int endIndex = int.Parse(commands[2]);

                        if (startIndex >= 0 && endIndex <= username.Length)
                        {
                            string substring = username.Substring(startIndex, endIndex);
                            var result = substring.Reverse();

                            Console.WriteLine(string.Join("", result));
                        }
                        break;

                    case "Cut":

                        if (username.Contains(secondCommand))
                        {
                            username = username.Replace(secondCommand, "");
                            Console.WriteLine(username);
                        }
                        break;

                    case "Replace":
                        username = username.Replace(secondCommand, "*");
                        Console.WriteLine(username);
                        break;

                    case "Check":
                        if (username.Contains(secondCommand))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {secondCommand}.");
                        }
                        break;
                }

            }

        }
    }
}
