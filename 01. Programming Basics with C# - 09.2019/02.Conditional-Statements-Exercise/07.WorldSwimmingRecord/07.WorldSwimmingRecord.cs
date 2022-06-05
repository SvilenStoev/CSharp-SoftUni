//Иван решава да подобри Световния рекорд по плуване на дълги разстояния.На конзолата се въвежда рекордът в секунди, 
//който Иван трябва да подобри,  разстоянието в метри, което трябва да преплува и времето в секунди, за което плува разстояние от 1 м.
//Да се напише програма, която изчислява дали се е справил със задачата, като се има предвид, че: 
//съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди.Когато се изчислява колко пъти Иванчо ще се забави, 
//в резултат на съпротивлението на водата, резултатът трябва да се закръгли надолу до най-близкото цяло число.
//Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд.

using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondFor1Meter = double.Parse(Console.ReadLine());

            double totalSeconds = meters * secondFor1Meter;
            double count = Math.Floor(meters / 15);

            if (meters >= 15)
            {
                totalSeconds += count * 12.50;
            }

            if (totalSeconds < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - totalSeconds):f2} seconds slower.");
            }
            
        }
    }
}
