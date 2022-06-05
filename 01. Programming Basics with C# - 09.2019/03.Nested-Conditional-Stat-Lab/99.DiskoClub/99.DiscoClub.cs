using System;

namespace Exercise
{
    class Exercise
    {
        static void Main(string[] args)
        {
            Console.Write("На колко си години? ");
            int age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine($"Шом сте на {age} може да влезете.");
            }
            else if (age == 18)
            {
                Console.WriteLine("Вие сте точно на 18 години може да влезете");
            }
            else
            {
                Console.WriteLine("Не може да влезете в дискотеката!");
                string answer1 = Console.ReadLine();
                switch (answer1)
                {
                    case "Добре": Console.WriteLine("Чао!"); break;
                    case "Ще направя всичко!":
                        Console.Write("Колко ще ми дадеш? "); int answer2 = int.Parse(Console.ReadLine());
                        if (answer2 >= 50)
                        {
                            Console.WriteLine($"Давай ми {answer2} лева и влизай!");
                        }
                        else
                        {
                            Console.WriteLine($"Не можеш да влезеш с подкуп само за {answer2} лева! Чао!");
                        }
                        break;
                    default:
                        Console.WriteLine("Ти си пиян! Махай се от дискотеката!");
                        break;

                }

            }


        }
    }
}
