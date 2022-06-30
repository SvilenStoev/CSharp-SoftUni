namespace BookShop
{
    using Data;
    using Initializer;
    using System.Linq;
    using System.Text;
    using System;
    using BookShop.Models.Enums;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            using var context = new BookShopContext();
            //DbInitializer.ResetDatabase(context);

            IncreasePrices(context);
        }

        //2. Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            var bookTitles = context
                .Books
                .ToList()
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(b => b.Title)
                .OrderBy(bt => bt)
                .ToList();

            foreach (var titles in bookTitles)
            {
                sb.AppendLine(titles);
            }

            return sb.ToString().TrimEnd();
        }

        //3. Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            var goldenBooks = context
                .Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, goldenBooks);
        }

        //4. Books by Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var books = context
                .Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            foreach (var book in books)
            {
                sb
                    .AppendLine($"{book.Title} - ${book.Price:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        //5. Not Released In
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, books);
        }

        //6. Book Titles by Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> booksTitles = context
                .Books
                .Where(b => b.BookCategories.Any(bc => categories.Contains(bc.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            return string.Join(Environment.NewLine, booksTitles);
        }

        //9. Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            List<string> booksTitles = context
                .Books
                .ToList()
                .Where(b => b.Title.Contains(input, StringComparison.InvariantCultureIgnoreCase))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            return string.Join(Environment.NewLine, booksTitles);
        }

        //12. Total Book Copies
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();

            var authors = context
                .Authors
                .Select(a => new
                {
                    AuthorName = a.FirstName + " " + a.LastName,
                    TotalBooksCopies = a.Books.Sum(b => b.Copies)
                }).ToList()
                .OrderByDescending(a => a.TotalBooksCopies)
                .ToList();

            foreach (var author in authors)
            {
                sb.AppendLine($"{author.AuthorName} - {author.TotalBooksCopies}");
            }

            return sb.ToString().TrimEnd();
        }

        //!!!!!!!!!!!!13. Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categories = context
                .Categories
                .Select(c => new
                {
                    c.Name,
                    TotalProfitPerCategory = c.CategoryBooks
                    .Select(cb => new
                    {
                        BookProfit = cb.Book.Copies * cb.Book.Price
                    })
                    .Sum(b => b.BookProfit)
                })
                .OrderByDescending(c => c.TotalProfitPerCategory)
                .ThenBy(c => c.Name)
                .ToList();

            foreach (var category in categories)
            {
                sb
                    .AppendLine($"{category.Name} ${category.TotalProfitPerCategory:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        //14. Most Recent Books
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var mostRecentBooksCategories = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Books = c.CategoryBooks
                    .OrderByDescending(cb => cb.Book.ReleaseDate)
                    .Take(3)
                    .Select(cb => new
                    {
                        Title = cb.Book.Title,
                        ReleaseYear = cb.Book.ReleaseDate.Value.Year,
                    })
                    .ToList()
                })
                .OrderBy(c => c.CategoryName)
                .ToList();

            foreach (var category in mostRecentBooksCategories)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.ReleaseYear})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        //15. Increase Prices
        public static void IncreasePrices(BookShopContext context)
        {
            var booksForIncreasingPrices = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year < 2010);

            foreach (var book in booksForIncreasingPrices)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }
    }
}
