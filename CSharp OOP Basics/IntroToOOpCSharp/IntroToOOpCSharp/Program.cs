using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOpCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            double side = 4;

            Shape[] shapes = new Shape[]
            {
                new Rectangle(side, 5),
                new Square(side),
                new Circle(side)
            };

            // to be explained
            ((ISortable[])shapes).Sort();

            foreach (var shape in shapes)
            {
                shape.CalculateArea();
                shape.CalculateParameter();

                if (shape is Square)
                {
                    Console.WriteLine("\n[A cool square comes next]");
                }

                Console.WriteLine(shape.ToString());
            }
        }
    }
}
