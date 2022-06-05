using System;
using System.Threading;

namespace _09.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int left = 1; left < n; left++)
            {
                for (int left2 = 1; left2 < n; left2++)
                {
                    for (int middle1 = 'a'; middle1 < 'a' + l; middle1++)
                    {
                        for (int middle2 = 'a'; middle2 < 'a' + l; middle2++)
                        {
                            for (int right = 2; right <= n; right++)
                            {
                                if (right > left && right > left2)
                                {
                                    Console.Write($"{left}{left2}{(char)middle1}{(char)middle2}{right} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
