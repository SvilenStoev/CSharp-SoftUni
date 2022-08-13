namespace DesignPatterns
{

    public abstract class SandwichPrototype
    {
        public string Bread { get; set; }

        public string Meat { get; set; }

        public string Cheese { get; set; }

        public string Veggies { get; set; }

        public abstract SandwichPrototype Clone();
    }
}
