using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string explosion = Console.ReadLine();

            int explosionStrength = 0;

            for (int i = 0; i < explosion.Length; i++)
            {
                if (explosion[i] == '>' && i < explosion.Length - 1)
                {
                    explosionStrength += int.Parse(explosion[i + 1].ToString());

                    for (int j = 0; j < explosionStrength; j++)
                    {
                        if (i == explosion.Length - 1)
                        {
                            explosionStrength = 0;
                            break;
                        }

                        if (explosion[i + 1] == '>')
                        {
                            explosionStrength = explosionStrength - j;
                            break;
                        }

                        explosion = explosion.Remove(i + 1, 1);
                        if (j == explosionStrength - 1)
                        {
                            explosionStrength = 0;
                        }

                    }
                }
            }

            Console.WriteLine(explosion);
        }
    }
}
