using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            BigInteger snowballValue = 0;
            BigInteger highestsnowballValue = 0;
            BigInteger highestsnowballSnow = 0;
            BigInteger highestssnowballTime = 0;
            BigInteger highestsnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= highestsnowballValue)
                {
                    highestsnowballValue = snowballValue;
                    highestsnowballSnow = snowballSnow;
                    highestssnowballTime = snowballTime;
                    highestsnowballQuality = snowballQuality;
                }

            }

            Console.WriteLine($"{highestsnowballSnow} : {highestssnowballTime} = {highestsnowballValue} ({highestsnowballQuality})");
        }
    }
}
