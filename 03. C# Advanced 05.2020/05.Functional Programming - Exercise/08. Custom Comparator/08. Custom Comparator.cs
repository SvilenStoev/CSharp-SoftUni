using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Създаване на компаратор - да сравнява някакви неща. В ООП ще го правим, но ще ползваме методи! Да запомня как се прави помпаратор - ретърн -1, ако искаме първото да остане първо  и тн..

            Func<int, int, int> comparator = new Func<int, int, int>((a, b) =>
               {
                   if (a % 2 == 0 && b % 2 != 0)
                   {
                       return -1;
                   }
                   else if (a % 2 != 0 && b % 2 == 0)
                   {
                       return 1;
                   }
                   else
                   {
                       return a.CompareTo(b);
                   }
               });

            Comparison<int> comparison = new Comparison<int>(comparator);

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, comparison);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
