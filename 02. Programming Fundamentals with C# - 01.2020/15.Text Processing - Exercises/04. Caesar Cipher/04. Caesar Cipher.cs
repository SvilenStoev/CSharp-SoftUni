using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder encryptedVersion = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int newAsciiNumber = input[i] + 3;
                char encryptedChar = (char)newAsciiNumber;

                encryptedVersion.Append(encryptedChar);
            }

            Console.WriteLine(encryptedVersion);
        }
    }
}
