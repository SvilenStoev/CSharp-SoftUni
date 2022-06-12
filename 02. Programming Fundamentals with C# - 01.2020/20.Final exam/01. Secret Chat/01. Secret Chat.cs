using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commands = command.Split(":|:").ToArray();
                string firstCommand = commands[0];

                switch (firstCommand)
                {
                    case "InsertSpace":
                        int index = int.Parse(commands[1]);

                        input = input.Insert(index, " ");
                        Console.WriteLine(input);
                        break;

                    case "Reverse":
                        string substring = commands[1];
                        string substringMessage = string.Empty;

                        if (input.Contains(substring))
                        {
                            int startIndex = input.IndexOf(substring);

                            substringMessage = input.Substring(startIndex, substring.Length);
                            input = input.Remove(startIndex, substring.Length);

                            var reversed = substringMessage.Reverse().ToArray();

                            input = input + string.Join("", reversed);

                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        
                        break;

                    case "ChangeAll": 
                        string substring1 = commands[1];
                        string replacement = commands[2];

                        input = input.Replace(substring1, replacement);
                        Console.WriteLine(input);
                        break;
                }
            }


            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
