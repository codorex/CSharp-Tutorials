using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAdvanced.Implementations
{
    public abstract class Shape
    {
        public double Area { get; set; }

        public double Parameter { get; set; }

        public virtual double CalculateArea()
        {
            return this.Area;
        }

        public virtual double CalculateParameter()
        {
            return this.Parameter;
        }
    }
}
