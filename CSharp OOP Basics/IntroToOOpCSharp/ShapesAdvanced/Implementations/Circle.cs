using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAdvanced.Implementations
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
            this.Area = CalculateArea();
        }

        public override double CalculateArea()
        {
            double result = (this.Radius * this.Radius) * Math.PI;
            this.Area = result;

            return result;
        }

        public override double CalculateParameter()
        {
            double result = 2 * Math.PI * this.Radius;
            this.Parameter = result;

            return result;
        }
    }

}
