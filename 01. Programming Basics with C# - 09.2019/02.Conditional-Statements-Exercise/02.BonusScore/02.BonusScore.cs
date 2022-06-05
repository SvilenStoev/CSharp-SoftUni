//Дадено е цяло число – начален брой точки.Върху него се начисляват бонус точки по правилата, описани по - долу.
//Да се напише програма, която пресмята бонус точките, които получава числото и общия брой точки(числото + бонуса).
//•	Ако числото е до 100 включително, бонус точките са 5.
//•	Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
//•	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.

//•	Допълнителни бонус точки(начисляват се отделно от предходните):
//o За четно число  +1 т.
//o За число, което завършва на 5  +2 т.

using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int Points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (Points <= 100)
            {
                bonusPoints = 5;
            }
            else if (Points <= 1000)
            {
                bonusPoints = Points * 0.20;
            }
            else
            {
                bonusPoints = Points * 0.10;
            }

            if (Points % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (Points % 10 == 5)
            {
                bonusPoints += 2; //bonusPoints = bonusPoints + 2;
            }

            double result = bonusPoints + Points;

            Console.WriteLine(bonusPoints);
            Console.WriteLine(result);

        }
    }
}
