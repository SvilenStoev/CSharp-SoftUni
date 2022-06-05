using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string decoration = Console.ReadLine();
            int total = 0;

            while (decoration != "Stop")
            {
                int sum = 0;

                for (int i = 0; i < decoration.Length; i++)
                {
                    sum += decoration[i];
                }
                total += sum;
                decoration = Console.ReadLine();
            }
            
        }
    }
}
