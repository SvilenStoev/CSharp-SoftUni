using System;

namespace _10.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;

            while (command != "Stop")
            {
                int commandAsNumber = int.Parse(command);
                sum += commandAsNumber;

                Console.WriteLine(sum);

                command = Console.ReadLine();
            }




        }
    }
}
