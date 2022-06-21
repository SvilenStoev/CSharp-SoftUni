using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height can't be negative or 0!");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width can't be negative or 0!");
                }

                this.width = value;
            }
        }


        public override double CalculateArea()
        {
            double result = this.Height * this.Width;

            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = this.Height * 2 + this.Width * 2;

            return result;
        }

        public override string Draw()
        {
            return base.Draw() + " I am Rectangle";
        }
    }
}
