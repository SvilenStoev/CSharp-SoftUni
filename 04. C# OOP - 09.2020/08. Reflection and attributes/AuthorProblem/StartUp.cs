using System;

namespace AuthorProblem
{

    [Author("Svilen")]
    public class StartUp
    {
        [Author("Pesho")]
        static void Main(string[] args)
        {
            var tracker = new Tracker();

            tracker.PrintMethodsByAuthor();
        }
    }
}
