using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            string passEntry = string.Empty;

            while (pass != passEntry)
            {
                passEntry = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {user}!");

        }
    }
}
