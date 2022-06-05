using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int filmsCount = int.Parse(Console.ReadLine());

            double lowestRating = double.MaxValue;
            double highestRating = double.MinValue;
            double totalRatingsSum = 0;
            string lowestRatingTitle = string.Empty;
            string highestRatingTitle = string.Empty;
            

            for (int currentFilm = 1; currentFilm <= filmsCount; currentFilm++)
            {
                string filmTitle = Console.ReadLine();
                double filmRating = double.Parse(Console.ReadLine());

                if (filmRating > highestRating)
                {
                    highestRating = filmRating;
                    highestRatingTitle = filmTitle;
                }
                if (filmRating <= lowestRating)
                {
                    lowestRating = filmRating;
                    lowestRatingTitle = filmTitle;
                }

                totalRatingsSum += filmRating;
            }

            Console.WriteLine($"{highestRatingTitle} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowestRatingTitle} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {(totalRatingsSum/filmsCount):f1}");

        }
    }
}
