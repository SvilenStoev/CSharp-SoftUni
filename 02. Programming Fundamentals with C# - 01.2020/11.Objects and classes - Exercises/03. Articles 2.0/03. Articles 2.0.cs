using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> articleData = Console.ReadLine().Split(", ").ToList();

                Article article = new Article(articleData[0], articleData[1], articleData[2]);

                articles.Add(article);
            }
            
            string criteria = Console.ReadLine();
            
            if (criteria == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();

            }
            else if (criteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }


            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
