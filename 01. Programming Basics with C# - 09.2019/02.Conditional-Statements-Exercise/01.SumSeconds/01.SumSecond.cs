using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Трима спортни състезатели финишират за някакъв брой секунди(между 1 и 50). Да се напише програма,
            //която чете времената на състезателите в секунди, въведени от потребителя и пресмята сумарното
            //им време във формат "минути:секунди".Секундите да се изведат с водеща нула(2  "02", 7  "07", 35  "35"). 

            int runner1Sec = int.Parse(Console.ReadLine());
            int runner2Sec = int.Parse(Console.ReadLine());
            int runner3Sec = int.Parse(Console.ReadLine());

            int totalSeconds = runner1Sec + runner2Sec + runner3Sec;

            int totalMinutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
                      
            if (seconds < 10)
            {
                Console.WriteLine($"{totalMinutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{totalMinutes}:{seconds}");
            }

        }
    }
}
