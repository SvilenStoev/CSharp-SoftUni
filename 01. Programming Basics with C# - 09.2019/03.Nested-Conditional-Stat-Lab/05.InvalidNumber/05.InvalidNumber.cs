//Дадено число е валидно, ако е в диапазона[100…200] или е 0. Да се напише програма, която чете цяло число, въведено от потребителя,
//и печата "invalid" ако въведеното число не е валидно.

using System;

namespace _05.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool valid = (number >= 100 && number <= 200 || number == 0);

            if (!valid)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
