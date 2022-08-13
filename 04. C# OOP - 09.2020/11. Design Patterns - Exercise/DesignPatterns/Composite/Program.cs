namespace Composite
{
    using System;

    class Program
    {
        public static void Main()
        {
            var phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootBox = new CompositeGift("RootBox");
            var truckToy = new SingleGift("TruckToy", 50);
            var plainToy = new SingleGift("PlainToy", 78);

            rootBox.Add(truckToy);
            rootBox.Add(plainToy);

            var childBox = new CompositeGift("ChildBox");
            var soldierToy = new SingleGift("SoldierToy", 123);
            var legoToy = new SingleGift("LegoToy", 45);

            childBox.Add(legoToy);
            childBox.Add(soldierToy);

            rootBox.Add(childBox);

            Console.WriteLine($"Total price rootBox: {rootBox.CalculateTotalPrice()}");
            Console.WriteLine();

            Console.WriteLine($"Total price childBox: {childBox.CalculateTotalPrice()}");
            Console.WriteLine();

            Console.WriteLine($"Some Gift: {soldierToy.CalculateTotalPrice()}");
        }
    }
}
