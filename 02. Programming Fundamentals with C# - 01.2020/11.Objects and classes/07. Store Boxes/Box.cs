using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Store_Boxes
{
    class Box
    {
        //Serial Number, Item, Item Quantity and Price for a Box.

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQantity { get; set; }

        public decimal PriceForABox
            => Item.Price * ItemQantity;
    }
}
