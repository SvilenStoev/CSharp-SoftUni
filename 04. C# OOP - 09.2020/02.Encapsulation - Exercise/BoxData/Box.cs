using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    class Box
    {
        private const int SIDE_MIN_VALUE = 0;
        private const string INVALID_SIDE_MESSAGE = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                this.ValidateSide(value, nameof(this.Length));

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.ValidateSide(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                ValidateSide(value, nameof(this.Height));

                this.height = value;
            }
        }

        public double GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

            return lateralSurfaceArea;
        }

        public double GetSurfaceArea()
        {
            double surfaceArea = (2 * this.Length * this.Width)
                               + (2 * this.Length * this.Height)
                               + (2 * this.Width * this.Height);

            return surfaceArea;
        }

        public double GetVolume()
        {
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Surface Area - {this.GetSurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {this.GetLateralSurfaceArea():f2}")
                .AppendLine($"Volume - {this.GetVolume():f2}");

            return sb.ToString().TrimEnd();
        }

        private void ValidateSide(double value, string sideName)
        {
            if (value <= SIDE_MIN_VALUE)
            {
                throw new ArgumentException(String.Format(INVALID_SIDE_MESSAGE, sideName));
            }
        }
    }
}
