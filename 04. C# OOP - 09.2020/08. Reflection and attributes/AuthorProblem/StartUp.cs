using System;

namespace AuthorProblem
{

    [Author("Svilen")]
    public class StartUp
    {
        [Author("Pesho")]
        public static void Main()
        {
            var tracker = new Tracker();

            tracker.PrintMethodsByAuthor();

           
        }

        [Author("Svilen")]
        public static void SomeMethod()
        {
            Console.WriteLine("something!");
        }
    }
}
