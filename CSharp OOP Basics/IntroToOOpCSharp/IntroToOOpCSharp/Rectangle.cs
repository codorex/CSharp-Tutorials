using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOpCSharp
{
    public class Rectangle : Shape, ISortable
    {
        private double sideA;
        private double sideB;

        public double SideA
        {
            get
            {
                return this.sideA;
            }
            private set
            {
                this.sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return this.sideB;
            }
            private set
            {
                this.sideB = value;
            }
        }

        public Rectangle() { }
        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public override double CalculateArea()
        {
            double area = this.sideA * this.sideB;

            this.Area = area;

            return area;
        }

        public override double CalculateParameter()
        {
            double parameter = 2 * (this.sideA + this.sideB);

            this.Parameter = parameter;

            return parameter;
        }

        public override int SortOrder
        {
            get { return 3; }
        }
    }
}
