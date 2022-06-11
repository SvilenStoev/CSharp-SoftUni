using System;

namespace _01._Biscuits_Factory_02._11._2019___G1
{
    class Program
    {
        static void Main(string[] args)
        {
            double buiscuitsProducedPerWorker = double.Parse(Console.ReadLine());
            double workersCount = double.Parse(Console.ReadLine());
            double competitingFactory = double.Parse(Console.ReadLine());

            double buiscuitsProducedPerDay = Math.Floor(buiscuitsProducedPerWorker * workersCount);
            double buiscuitsProduced3Day = Math.Floor(buiscuitsProducedPerDay * 0.75);
            double totalProduction = 0.0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    totalProduction += buiscuitsProduced3Day;
                }
                else
                {
                    totalProduction += buiscuitsProducedPerDay;
                }
            }

            Console.WriteLine($"You have produced {totalProduction} biscuits for the past month.");

            if (totalProduction > competitingFactory)
            {
                Console.WriteLine($"You produce {(totalProduction - competitingFactory) / competitingFactory * 100:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {(competitingFactory - totalProduction) / competitingFactory * 100:f2} percent less biscuits.");
            }


        }
    }
}
