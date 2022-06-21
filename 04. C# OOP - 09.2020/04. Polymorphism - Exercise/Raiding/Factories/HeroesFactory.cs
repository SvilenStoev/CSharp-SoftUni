using Raiding.Contracts;
using Raiding.Exceptions;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Factories
{
    public class HeroesFactory
    {
        public IBaseHero ProduceHero(string heroName, string heroType)
        {
            IBaseHero hero;

            switch (heroType)
            {
                case "Druid":

                    hero = new Druid(heroName);

                    break;

                case "Paladin":

                    hero = new Paladin(heroName);

                    break;

                case "Rogue":

                    hero = new Rogue(heroName);

                    break;

                case "Warrior":

                    hero = new Warrior(heroName);

                    break;

                default:

                    throw new InvalidHeroException();
            }

            return hero;
        }
    }
}
