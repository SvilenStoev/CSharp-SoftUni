using System;

using WildFarm.Models.Foods;
using System.Collections.Generic;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double WEIGHT_MULTIPLIER = 1.00;

        public Tiger(string Name, double weight, string livingRegion, string breed)
            : base(Name, weight, livingRegion, breed)
        {

        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods => new List<Type>() { typeof(Meat) };

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
