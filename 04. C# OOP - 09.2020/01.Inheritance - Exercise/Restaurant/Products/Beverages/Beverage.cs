using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Restaurant.Products.Beverages
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters)
            : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        //public string Name { get; set; }

        //public double Price { get; set; }

        public double Milliliters { get; set; }
    }
}
