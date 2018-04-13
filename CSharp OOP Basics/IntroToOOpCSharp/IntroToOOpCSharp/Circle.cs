using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOpCSharp
{
    public class Circle : Shape, ISortable
    {
        private double radius;

        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(this.radius, 2); 

            this.Area = area;

            return area;
        }

        public override double CalculateParameter()
        {
            double parameter = 2 * Math.PI * this.radius; 

            this.Parameter = parameter;

            return parameter;
        }

        public override int SortOrder
        {
            get { return 2; }
        }
    }
}
