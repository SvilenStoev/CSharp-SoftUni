using System;
using System.Text;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double kegVolume = 0.0;
            double biggestKegVolume = double.MinValue;
            string biggestKegModel = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                kegVolume = Math.PI * kegRadius * kegRadius * kegHeight;

                if (kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);

        }
    }
}
