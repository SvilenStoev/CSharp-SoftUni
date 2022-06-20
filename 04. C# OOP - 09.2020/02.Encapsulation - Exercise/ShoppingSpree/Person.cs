using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ShoppingSpree.Common;
using ShoppingSpree.Models;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyExceptionMessage);
                }

                this.money = value;
            }
        }

        public List<Product> BagOfProducts
        {
            get
            {
                return this.bagOfProducts;
            }

            set
            {
                this.bagOfProducts = value;
            }
        }

        public bool BuyProduct(Product product)
        {
            bool productBought = false;

            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException(String.Format(GlobalConstants.InsufficientMoneyExceptionMessage, this.Name, product.Name));
            }
            else
            {
                this.BagOfProducts.Add(product);

                productBought = true;

                this.Money -= product.Cost;
            }

            return productBought;
        }

    }
}
