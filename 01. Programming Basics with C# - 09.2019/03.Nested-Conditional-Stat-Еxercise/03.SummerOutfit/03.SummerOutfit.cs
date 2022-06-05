using System;

namespace _03.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string Outfit = string.Empty;
            string Shoes = string.Empty;

            if (degrees >= 10 && degrees <= 18)
            {
                switch (timeOfDay)
                {
                    case "Morning": Outfit = "Sweatshirt"; Shoes = "Sneakers"; break;
                    case "Afternoon": Outfit = "Shirt"; Shoes = "Moccasins"; break;
                    case "Evening": Outfit = "Shirt"; Shoes = "Moccasins"; break;
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                switch (timeOfDay)
                {
                    case "Morning": Outfit = "Shirt"; Shoes = "Moccasins"; break;
                    case "Afternoon": Outfit = "T-Shirt"; Shoes = "Sandals"; break;
                    case "Evening": Outfit = "Shirt"; Shoes = "Moccasins"; break;
                }
            }
            else if (degrees >= 25)
            {
                switch (timeOfDay)
                {
                    case "Morning": Outfit = "T-Shirt"; Shoes = "Sandals"; break;
                    case "Afternoon": Outfit = "Swim Suit"; Shoes = "Barefoot"; break;
                    case "Evening": Outfit = "Shirt"; Shoes = "Moccasins"; break;
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");

        }

    }
}

