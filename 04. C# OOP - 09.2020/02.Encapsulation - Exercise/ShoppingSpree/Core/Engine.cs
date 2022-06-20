using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Person> people;
        private List<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            AddPeople();
            AddProducts();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string personName = command.Split()[0];
                string productName = command.Split()[1];

                try
                {
                    Person currPerson = this.people.Find(p => p.Name == personName);
                    Product currProduct = this.products.Find(p => p.Name == productName);

                    if (currPerson.BuyProduct(currProduct))
                    {
                        Console.WriteLine($"{currPerson.Name} bought {currProduct.Name}");
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (Person person in people)
            {
                var listOfProductsNames = new List<string>();

                for (int i = 0; i < person.BagOfProducts.Count; i++)
                {
                    listOfProductsNames.Add(person.BagOfProducts[i].Name);
                }

                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", listOfProductsNames)}");
                }
            }
        }

        private void AddProducts()
        {
            string[] productsDetails = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < productsDetails.Length; i++)
            {
                string currProductName = productsDetails[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
                decimal currProductCost = decimal.Parse(productsDetails[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);

                var currProduct = new Product(currProductName, currProductCost);

                this.products.Add(currProduct);
            }
        }

        private void AddPeople()
        {
            string[] peopleDetails = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < peopleDetails.Length; i++)
            {
                string currPersonName = peopleDetails[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
                decimal currPersonMoney = decimal.Parse(peopleDetails[i].Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);

                var currPerson = new Person(currPersonName, currPersonMoney);

                this.people.Add(currPerson);
            }
        }
    }
}
