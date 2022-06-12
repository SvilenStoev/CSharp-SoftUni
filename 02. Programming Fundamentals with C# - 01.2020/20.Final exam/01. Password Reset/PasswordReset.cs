using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01._Password_Reset
{
    class PasswordReset
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                var splitedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (splitedInput[0])
                {
                    case "TakeOdd":
                        for (int i = 1; i < password.Length; i += 2)
                        {
                            sb.Append(password[i]);
                        }
                        password = sb.ToString();
                        Console.WriteLine(password);
                        break;

                    case "Cut":
                        int index = int.Parse(splitedInput[1]);
                        int length = int.Parse(splitedInput[2]);

                        password = password.Remove(index, length);
                        Console.WriteLine(password);

                        break;

                    case "Substitute":
                        string substring = splitedInput[1];
                        string substitute = splitedInput[2];

                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
