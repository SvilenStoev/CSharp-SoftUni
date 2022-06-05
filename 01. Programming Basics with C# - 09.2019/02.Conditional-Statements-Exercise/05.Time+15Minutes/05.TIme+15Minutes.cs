//Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от потребителя и изчислява колко ще е часът след 15 минути.
//Резултатът да се отпечата във формат часове:минути.Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. 
//Часовете се изписват с една или две цифри.Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.

using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");

            //Аз го реших така:
            //if (minutes >= 45 && hours < 23)
            //{
            //    Console.WriteLine($"{hours + 1}:{minutes + 15 - 60:D2}");
            //}
            //else if (minutes >= 45 && hours == 23)
            //{
            //    Console.WriteLine($"{hours + 1 - 24}:{minutes + 15 - 60:D2}");
            //}
            //else
            //{
            //    Console.WriteLine($"{hours}:{minutes + 15:D2}");
            //}
                        
            //на упражнение го решихме така:



        }
    }
}
