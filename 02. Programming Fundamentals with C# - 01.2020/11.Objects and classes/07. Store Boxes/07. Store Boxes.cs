using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] boxData = input.Split();

                string serialNumer = boxData[0];
                string itemName = boxData[1];
                int itemQuantity = int.Parse(boxData[2]);
                decimal itemPrice = decimal.Parse(boxData[3]);

                Item currItem = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box currBox = new Box()
                {
                    SerialNumber = serialNumer,
                    Item = currItem,
                    ItemQantity = itemQuantity
                };

                boxes.Add(currBox);
            }

            var sortedBoxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}
