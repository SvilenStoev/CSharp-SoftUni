﻿using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = new string[] {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.", 
                "I can’t live without this product."
            };

            string[] events = new string[] {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


            for (int i = 0; i < n; i++)
            {
                Random random = new Random();

                int randomPhrases = random.Next(0, phrases.Length);
                int randomEvents = random.Next(0, events.Length);
                int randomAuthors = random.Next(0, authors.Length);
                int randomCities = random.Next(0, cities.Length);

                Console.WriteLine($"{phrases[randomPhrases]} {events[randomEvents]} {authors[randomAuthors]} – {cities[randomCities]}.");
            }
        }
    }
}
