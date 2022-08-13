namespace DesignPatterns
{
    using System;

    public class Program
    {
        public static void Main()
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            sandwichMenu["Svilen'sSandw"] = new Sandwich("Wheat", "Bacon", "", "Tomato");
            sandwichMenu["BestSandw"] = new Sandwich("White", "", "", "Chocolate, Jelly");
            sandwichMenu["NiceSandw"] = new Sandwich("Rye", "Turkey", "", "Tomato");

            foreach (var kvp in sandwichMenu.sandwiches) 
            { 
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Bread}, {kvp.Value.Cheese}, {kvp.Value.Meat}, {kvp.Value.Meat}");
            }

            //Clone
            sandwichMenu["Cloned-Sandwich"] = sandwichMenu["BestSandw"].Clone() as Sandwich;

            foreach (var kvp in sandwichMenu.sandwiches)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Bread}, {kvp.Value.Cheese}, {kvp.Value.Meat}, {kvp.Value.Meat}");

            }
        }
    }
}
