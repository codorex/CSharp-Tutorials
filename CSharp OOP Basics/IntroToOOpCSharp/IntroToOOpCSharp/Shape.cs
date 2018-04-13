using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOpCSharp
{
    public abstract class Shape : ISortable
    {
        private double area;
        private double parameter;

        public double Area
        {
            get
            {
                return this.area;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.area = value;
            }
        }

        public double Parameter
        {
            get
            {
                return this.parameter;
            }
            protected set
            {
                this.parameter = value;
            }
        }

        public virtual double CalculateArea()
        {
            return this.Area;
        }

        public virtual double CalculateParameter()
        {
            return this.Parameter;
        }

        //TODO: to be explained
        public override string ToString()
        {
            return 
                this.GetType().Name +
                ":\n -- Area = " +
                this.Area.ToString("N2") +
                ",\n -- Parameter = " + 
                this.Parameter.ToString("N2"); 
        }

        //TODO: to be explained
        public virtual int SortOrder
        {
            get { return 0; }
        }
    }
}
