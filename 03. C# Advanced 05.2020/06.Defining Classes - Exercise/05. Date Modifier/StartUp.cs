using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier date = new DateModifier();
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            date.CalculateDateDifference(firstDate, secondDate);
        }
    }
}
