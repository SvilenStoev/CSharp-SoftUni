using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добре дошли! Създайте профил:");
            Console.Write("Профил: ");
            string userName = Console.ReadLine();
            Console.Write("Парола: ");
            string password = Console.ReadLine();
            Console.WriteLine("Профилът е създаден!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Добре дошли отново! Въведете име и парола: ");
            Console.Write("Профил: ");
            string userName1 = Console.ReadLine();
            Console.Write("Парола: ");
            string password2 = Console.ReadLine();

            int counter = 1;

            while (!(userName == userName1 && password == password2))
            {
                Console.WriteLine("Грешно потребителско име или парола!");
                Console.Write("Профил: ");
                userName1 = Console.ReadLine();
                Console.Write("Парола: ");
                password2 = Console.ReadLine();

                if (counter == 3)
                {
                    Console.WriteLine("Сгрешихте повече от 3 пъти");
                    break;
                }
                else if (userName == userName1 && password == password2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Успешен вход!");
                }
                counter++;
            }
            
        }
    }
}
