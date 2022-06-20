using Restaurant.Products.Beverages.HotBeverages;
using Restaurant.Products.Food;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var coffee = new Coffee("Latte", 52.3);

            System.Console.WriteLine(coffee.Caffeine);
        }
    }
}