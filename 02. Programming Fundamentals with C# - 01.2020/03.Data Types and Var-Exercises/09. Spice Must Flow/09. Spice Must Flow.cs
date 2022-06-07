using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int currentDayYield = startingYield;
            BigInteger totalYield = 0;
            int daysOperated = 0;

            while (currentDayYield >= 100)
            {
                totalYield += currentDayYield;
                totalYield -= 26;
                currentDayYield -= 10;

                daysOperated++;
            }

            totalYield -= 26;

            if (startingYield < 100)
            {
                totalYield = 0;
            }

            Console.WriteLine(daysOperated);
            Console.WriteLine(totalYield);

        }
    }
}
