using OnlineShop.Models.Products.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products
{
    public abstract class Component : Product, IComponent
    {
        private int generation;

        protected Component(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.Generation = generation;
        }

        public int Generation
        {
            get
            {
                return this.generation;
            }

            private set
            {
                this.generation = value;
            }
        }

        public override string ToString()
        {
            return $"  Overall Performance: {base.OverallPerformance:f2}. Price: {base.Price:f2} - {base.GetType().Name}: {base.Manufacturer} {base.Model} (Id: {base.Id}) Generation: {this.Generation}";
        }
    }
}
