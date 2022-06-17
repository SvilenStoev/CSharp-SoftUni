using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
        }

        public List<Car> Data { get; set; } = new List<Car>();

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count { get => this.Data.Count; }

        public void Add(Car car)
        {
            if (this.Data.Count < this.Capacity)
            {
                this.Data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car currCar = Data.Find(c => c.Model == model && c.Manufacturer == manufacturer);

            if (currCar != null)
            {
                Data.Remove(currCar);
                return true;
            }

            return false;
        }
        
        public Car GetLatestCar()
        {
            if (this.Data.Count == 0)
            {
                return null;
            }

            var cars = this.Data.OrderByDescending(c => c.Year).ToList();

            var latestCar = cars[0];

            return latestCar;
        }

        public Car GetCar(string manufacturer, string model)
        {
            if (this.Data.Count == 0)
            {
                return null;
            }

            Car currCar = Data.Find(c => c.Model == model && c.Manufacturer == manufacturer);

            if (currCar != null)
            {
                return currCar;
            }
            else
            {
                return null;
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"The cars are parked in {this.Type}:")
                .AppendLine($"{string.Join(Environment.NewLine, this.Data)}");


            return sb.ToString().TrimEnd();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"The cars are parked in {this.Type}:")
                .AppendLine($"{string.Join(Environment.NewLine, this.Data)}");


            return sb.ToString().TrimEnd();
        }
    }
}
