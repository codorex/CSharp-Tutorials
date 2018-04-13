using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOpCSharp
{
    public class Square : Shape, ISortable
    {
        private double side;
        public double Side 
        {
            get
            {
                return this.side;
            }
            private set
            {
                this.side = value;
            } 
        }

        public Square() { }

        public Square(double side)
        {
            this.Side = side;
        }

        public override double CalculateArea()
        {
            double area = Math.Pow(this.side, 2);

            this.Area = area;

            return area;
        }

        public double CalculateArea(int rateOfExpansion)
        {
            double area = Math.Pow(this.side, 2) * rateOfExpansion;

            this.Area = area;

            return area;
        }

        public override double CalculateParameter()
        {
            double parameter = this.side * 4;

            this.Parameter = parameter;

            return parameter;
        }

        public override int SortOrder
        {
            get
            {
                return 1;
            }
        }
    }
}
