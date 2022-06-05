using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int booksCount = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter <= booksCount)
            {
                string book = Console.ReadLine();
                if (counter == booksCount && book != favoriteBook)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                }
                if (book == favoriteBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;

            }

        }
    }
}
