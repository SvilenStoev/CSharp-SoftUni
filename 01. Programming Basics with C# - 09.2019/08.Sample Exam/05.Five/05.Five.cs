using System;

namespace _05.Five
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengersCountAtStart = int.Parse(Console.ReadLine());
            int stationCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stationCount; i++)
            {
                int passengerOut = int.Parse(Console.ReadLine());
                passengersCountAtStart -= passengerOut;

                int passengerIn = int.Parse(Console.ReadLine());
                passengersCountAtStart += passengerIn;

                if (i % 2 == 0)
                {
                    passengersCountAtStart -= 2;
                }
                else
                {
                    passengersCountAtStart += 2;
                }
            }

            Console.WriteLine($"The final number of passengers is : {passengersCountAtStart}");

        }
    }
}
