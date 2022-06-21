using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int DEFAULT_POWER = 80;

        public Rogue(string name)
            : base(name)
        {

        }

        public override int Power => DEFAULT_POWER;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
