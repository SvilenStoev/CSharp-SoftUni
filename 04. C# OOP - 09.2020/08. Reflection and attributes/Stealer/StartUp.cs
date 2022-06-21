using System;

namespace Stealer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            Hacker hacker = new Hacker();
            Type type = hacker.GetType();

            string result = spy.CollectGettersAndSetters($"{type.Namespace}.{type.Name}");

            Console.WriteLine(result);
        }
    }
}
