using System;

namespace DesignPatterns
{

    public class Sandwich : SandwichPrototype
    {
        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.Bread = bread;
            this.Meat = meat;
            this.Cheese = cheese;
            this.Veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();

            Console.WriteLine("Cloning sandwich with ingredients: {0}", ingredientList);

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            return $"{this.Bread}, {this.Meat}, {this.Cheese}, {this.Veggies}";
        }
    }
}
