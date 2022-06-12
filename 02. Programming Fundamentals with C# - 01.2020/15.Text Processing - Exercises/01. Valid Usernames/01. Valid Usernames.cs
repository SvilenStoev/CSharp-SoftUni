using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();

            foreach (string username in usernames)
            {
                bool isValidUsername = true;

                for (int i = 0; i < username.Length; i++)
                {
                    if (!((username.Length <= 16 && username.Length >= 3) && (char.IsLetterOrDigit(username[i]) || username[i] == '-' || username[i] == '_')))
                    {
                        isValidUsername = false;
                        break;
                    }
                }

                if (isValidUsername)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
