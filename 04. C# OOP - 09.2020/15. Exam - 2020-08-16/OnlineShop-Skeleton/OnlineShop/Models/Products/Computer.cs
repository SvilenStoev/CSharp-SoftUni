using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OnlineShop.Models.Products
{
    public abstract class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.Peripherals = (List<IPeripheral>)peripherals;
            this.Components = (List<IComponent>)components;
            this.Components = new List<IComponent>();
            this.Peripherals = new List<IPeripheral>();
        }

        public override double OverallPerformance
        {
            get
            {
                if (!components.Any())
                {
                    return base.OverallPerformance;
                }

                base.OverallPerformance = this.OverallPerformance + (double)this.components.Average(c => c.OverallPerformance);

                return base.OverallPerformance;
            }
        }

        public override decimal Price
        {
            get
            {
                base.Price = base.Price + this.components.Sum(c => c.Price);

                return base.Price;
            }
        }

        public IReadOnlyCollection<IComponent> Components
        {
            get
            {
                return this.components;
            }

            set
            {
                this.components = (List<IComponent>)value;
            }
        }

        public IReadOnlyCollection<IPeripheral> Peripherals
        {
            get
            {
                return this.peripherals;
            }

            set
            {
                this.peripherals = (List<IPeripheral>)value;
            }
        }

        public void AddComponent(IComponent component)
        {
            if (components.Any(c => c.GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, this.Id));
            }

            components.Add(component);
        }
        public void AddPeripheral(IPeripheral peripheral)
        {
            //TODO Peripheral type??
            if (peripherals.Any(c => c.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name, this.Id));
            }

            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (!components.Any() || components.Any(c => c.GetType().Name == componentType))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id));
            }

            var componentForRemoving = (IComponent)components.FirstOrDefault(c => c.GetType().Name == componentType);

            components.Remove(componentForRemoving);

            return componentForRemoving;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (!peripherals.Any() || peripherals.Any(c => c.GetType().Name == peripheralType))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }

            var peripheralForRemoving = (IPeripheral)peripherals.FirstOrDefault(c => c.GetType().Name == peripheralType);

            peripherals.Remove(peripheralForRemoving);

            return peripheralForRemoving;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            string text = string.Join("\n", this.components);
            string text2 = string.Join("\n", this.peripherals);

            sb
              .AppendLine($"Overall Performance: {base.OverallPerformance:f2}. Price: {base.Price:f2} - {base.GetType().Name}: {base.Manufacturer} {base.Model} (Id: {base.Id})")
              .AppendLine($" Components ({Components.Count}):")
              .AppendLine($"{text}")
              .AppendLine($" Peripherals ({this.peripherals.Count}); Average Overall Performance ({base.OverallPerformance}):")
              .AppendLine($"{text2}");

            return sb.ToString().TrimEnd();
        }
    }
}
