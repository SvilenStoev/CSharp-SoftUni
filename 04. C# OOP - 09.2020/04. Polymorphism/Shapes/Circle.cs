using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The radius can't be negative or 0!");
                }

                this.radius = value;
            }
        }

        public override double CalculateArea()
        {
            double result = Math.PI * Math.Pow(this.Radius, 2);

            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = Math.PI * this.Radius * 2;

            return result;
        }

        public override string Draw()
        {
            return base.Draw() + " I am Circle";
        }
    }
}
