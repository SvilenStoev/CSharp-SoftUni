using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articleData = Console.ReadLine().Split(", ").ToList();

            Article article = new Article(articleData[0], articleData[1], articleData[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                string currcommand = command[0];
                string newData = command[1];

                switch (currcommand)
                {
                    case "Edit":
                        article.Edit(newData);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(newData);
                        break;

                    case "Rename":
                        article.Rename(newData);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
