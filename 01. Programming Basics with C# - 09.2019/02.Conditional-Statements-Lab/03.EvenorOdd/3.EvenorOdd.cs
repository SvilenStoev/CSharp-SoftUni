using System;

namespace _03.EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0) //Дели на числото и пише колко остатък има         
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
