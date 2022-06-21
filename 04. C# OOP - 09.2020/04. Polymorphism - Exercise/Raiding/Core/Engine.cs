using Raiding.Contracts;
using Raiding.Exceptions;
using Raiding.Factories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private ICollection<IBaseHero> heroes;
        private HeroesFactory heroesFactory;

        public Engine()
        {
            this.heroes = new List<IBaseHero>();
            this.heroesFactory = new HeroesFactory();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            ProceedHeroes(n);

            int bossPower = int.Parse(Console.ReadLine());
            int heroesPowerSum = 0;

            foreach (var heroCast in heroes)
            {
                Console.WriteLine(heroCast.CastAbility());
                heroesPowerSum += heroCast.Power;
            }

            ProceedResult(bossPower, heroesPowerSum);
        }


        private static void ProceedResult(int bossPower, int heroesPowerSum)
        {
            if (heroesPowerSum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private void ProceedHeroes(int n)
        {
            while (this.heroes.Count < n)
            {
                IBaseHero hero = null;

                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                try
                {
                    hero = this.heroesFactory.ProduceHero(heroName, heroType);

                    heroes.Add(hero);
                }
                catch (InvalidHeroException ihx)
                {
                    Console.WriteLine(ihx.Message);
                }
            }
        }
    }
}
