using OnlineShop.Common.Constants;
using OnlineShop.Models.Products;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<Computer> computers;

        public Controller()
        {
            this.computers = new List<Computer>();
        }

        string IController.AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            CheckIfComputerExists(computerId);

            Computer computer = computers.Find(c => c.Id == computerId);

            if (computer.Components.Any(c => c.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }
            else if (componentType == "CentralProcessingUnit")
            {
                var component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else if (componentType == "Motherboard")
            {
                var component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);

            }
            else if (componentType == "PowerSupply")
            {
                var component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);

            }
            else if (componentType == "RandomAccessMemory")
            {
                var component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);

            }
            else if (componentType == "SolidStateDrive")
            {
                var component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);

            }
            else if (componentType == "VideoCard")
            {
                var component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                computer.AddComponent(component);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }


            return string.Format(SuccessMessages.AddedComponent, componentType, id, computerId);
        }

        string IController.AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            Laptop laptop = null;
            DesktopComputer desktopComputer = null;

            if (computers.Any(c => c.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
            else if (computerType == "Laptop")
            {
                laptop = new Laptop(id, manufacturer, model, price);
            }
            else if (computerType == "DesktopComputer")
            {
                desktopComputer = new DesktopComputer(id, manufacturer, model, price);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }

            if (laptop != null)
            {
                computers.Add(laptop);
            }
            else
            {
                computers.Add(desktopComputer);
            }

            return string.Format(SuccessMessages.AddedComputer, id);
        }

        string IController.AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            CheckIfComputerExists(computerId);

            Computer computer = computers.Find(c => c.Id == computerId);

            if (computer.Peripherals.Any(c => c.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }
            else if (peripheralType == "Headset")
            {
                var peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else if (peripheralType == "Keyboard")
            {
                var peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else if (peripheralType == "Monitor")
            {
                var peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else if (peripheralType == "Mouse")
            {
                var peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                computer.AddPeripheral(peripheral);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }

            return string.Format(SuccessMessages.AddedPeripheral, peripheralType, id, computerId);
        }

        string IController.BuyBest(decimal budget)
        {
            var currComputer = computers.OrderByDescending(c => c.OverallPerformance).First(c => c.Price <= budget);

            computers.Remove(currComputer);

            if (currComputer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }

            return currComputer.ToString();
        }

        string IController.BuyComputer(int id)
        {
            CheckIfComputerExists(id);

            var computer = computers.Find(c => c.Id == id);

            computers.Remove(computer);

            return computer.ToString();
        }

        string IController.GetComputerData(int id)
        {
            CheckIfComputerExists(id);

            Computer computer = computers.Find(c => c.Id == id);

            return computer.ToString();
        }

        string IController.RemoveComponent(string componentType, int computerId)
        {
            CheckIfComputerExists(computerId);

            Computer computer = computers.Find(c => c.Id == computerId);

            computer.RemoveComponent(componentType);

            //TODO how to remove peripheral?

            return string.Format(SuccessMessages.RemovedPeripheral, componentType);
        }

        string IController.RemovePeripheral(string peripheralType, int computerId)
        {
            CheckIfComputerExists(computerId);

            Computer computer = computers.Find(c => c.Id == computerId);

            computer.RemovePeripheral(peripheralType);

            //TODO how to remove peripheral?

            return string.Format(SuccessMessages.RemovedPeripheral, peripheralType);
        }
        private void CheckIfComputerExists(int id)
        {
            if (computers.Any(c => c.Id == id))
            {
                return;
            }

            throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
        }

    }
}
