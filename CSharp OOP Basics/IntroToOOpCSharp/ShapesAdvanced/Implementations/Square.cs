using ShapesAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAdvanced.Implementations
{
    public class Square : Shape, IPolygon
    {
        public double Side { get; set; }

        public Square(double side)
        {
            this.Side = side;
            this.Area = CalculateArea();
        }

        public override double CalculateArea()
        {
            double result = this.Side * this.Side;
            this.Area = result;

            return result;
        }

        public override double CalculateParameter()
        {
            double result = this.Side * 4;
            this.Parameter = result;

            return result;
        }

        public int GetNumberOfEdges()
        {
            return 4;
        }
    }
}
