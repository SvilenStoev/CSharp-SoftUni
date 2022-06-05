using System;

namespace _4.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTables = int.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());

            double squareKare = countTables * (lengthTable / 2) * (lengthTable / 2);
            double squareCover = countTables * (lengthTable + 2 * 0.3) * (widthTable + 2 * 0.3);

            double USD = squareKare * 9 + squareCover * 7;
            
            Console.WriteLine($"{USD:f2} USD");
            Console.WriteLine($"{USD * 1.85:f2} BGN"); //Да я прегледам пак!

        }
    }
}
