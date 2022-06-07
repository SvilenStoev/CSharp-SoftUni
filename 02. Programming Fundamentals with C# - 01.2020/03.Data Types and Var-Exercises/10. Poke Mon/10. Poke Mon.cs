using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //N
            int distance = int.Parse(Console.ReadLine()); //M
            int exhaustionFactor = int.Parse(Console.ReadLine()); //Y
            int pokeCount = 0;
            int currentPower = pokePower;

            while (distance <= currentPower)
            {
                currentPower -= distance;

                if (currentPower == pokePower * 0.5 && exhaustionFactor != 0)
                {
                    currentPower /= exhaustionFactor;
                }

                pokeCount++;
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(pokeCount);

        }
    }
}
