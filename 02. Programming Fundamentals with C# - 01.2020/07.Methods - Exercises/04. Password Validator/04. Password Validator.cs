using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!PasswordIsValidLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!PasswordIsLetterOrDigitCheck(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!PasswordHasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (PasswordHasAtLeastTwoDigits(password) && PasswordIsLetterOrDigitCheck(password) && PasswordIsValidLength(password))
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool PasswordIsValidLength(string input)
        {
            return input.Length >= 6 && input.Length <= 10;
        }

        static bool PasswordIsLetterOrDigitCheck(string input)
        {
            input = input.ToLower();

            foreach (char i in input)
            {
                if (!(i >= 48 && i <= 57 || i >= 97 && i <= 122))
                {
                    return false;
                }
            }

            return true;

            //foreach (char i in input)
            //{
            //    if (char.IsLetterOrDigit(i))
            //    {
            //        return true;
            //    }
            //}

            //return false;
        }

        static bool PasswordHasAtLeastTwoDigits(string input)
        {
            int digitCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    digitCounter++;
                }
            }

            if (digitCounter < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
