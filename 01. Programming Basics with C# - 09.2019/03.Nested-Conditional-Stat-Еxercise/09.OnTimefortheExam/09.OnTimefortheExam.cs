using System;

namespace _09.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTotalMinutes = examHour * 60 + examMinutes;
            int arrivalTotalMinutes = arrivalHour * 60 + arrivalMinutes;

            int difference = examTotalMinutes - arrivalTotalMinutes;

            if (difference < 0)
            {
                Console.WriteLine("Late");
                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else if (difference % 60 == 0 || arrivalMinutes > examMinutes)
                {
                    Console.WriteLine($"{Math.Abs(examHour - arrivalHour)}:{(Math.Abs(examMinutes - arrivalMinutes)):d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(examHour - arrivalHour + 1)}:{(Math.Abs(examMinutes - arrivalMinutes - 60)):d2} hours after the start");
                }
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (difference % 60 == 0 || arrivalMinutes < examMinutes)
                {
                    Console.WriteLine($"{Math.Abs(examHour - arrivalHour)}:{Math.Abs(examMinutes - arrivalMinutes):d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(examHour - arrivalHour - 1)}:{Math.Abs(examMinutes - arrivalMinutes + 60):d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                if (examMinutes != arrivalMinutes)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }

        }
    }
}
