using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesNeeded = (int)Math.Ceiling(persons * 1.0 / elevatorCapacity);


            Console.WriteLine(coursesNeeded);

        }
    }
}
