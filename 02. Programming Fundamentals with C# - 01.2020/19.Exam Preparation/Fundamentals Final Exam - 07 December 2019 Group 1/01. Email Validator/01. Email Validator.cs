using System;
using System.Linq;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Complete")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currCommand = commands[0];

                if (currCommand == "Make")
                {
                    email = MakeUpper(email, commands);

                    email = MakeLower(email, commands);
                }
                else if (currCommand == "GetDomain")
                {
                    GetDomain(email, commands);
                }
                else if (currCommand == "GetUsername")
                {
                    GetUsername(email);
                }
                else if (currCommand == "Replace")
                {
                    email = ReplateGivenChar(email, commands);
                }
                else if (currCommand == "Encrypt")
                {
                    EncryptEmail(email);
                }
            }
        }

        private static void EncryptEmail(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                int charValue = email[i];

                Console.Write($"{charValue} ");
            }
        }

        private static string ReplateGivenChar(string email, string[] commands)
        {
            string stringToReplace = commands[1].ToString();

            email = email.Replace(stringToReplace, "-");

            Console.WriteLine(email);
            return email;
        }

        private static void GetUsername(string email)
        {
            if (email.Contains("@"))
            {
                int indexOfAt = email.IndexOf('@');
                Console.WriteLine(email.Substring(0, indexOfAt));
            }
            else
            {
                Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
            }
        }

        private static void GetDomain(string email, string[] commands)
        {
            int count = int.Parse(commands[1]);
            int startIndex = email.Length - count;

            Console.WriteLine(email.Substring(startIndex));
        }

        private static string MakeLower(string email, string[] commands)
        {
            if (commands[1] == "Lower")
            {
                email = email.ToLower();
                Console.WriteLine(email);
            }

            return email;
        }

        private static string MakeUpper(string email, string[] commands)
        {
            if (commands[1] == "Upper")
            {
                email = email.ToUpper();
                Console.WriteLine(email);
            }

            return email;
        }
    }
}
