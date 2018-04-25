using ShapesAdvanced.Implementations;
using ShapesAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesAdvanced.Extensions;

namespace ShapesAdvanced
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] array = new Shape[]
            {
                new Square(6),
                new Circle(15),
                new Square(3)
            };

            array.Sort<Shape>((a, b) => { return a.Area > b.Area ? 1 : -1; });

            foreach (var shape in array)
            {
                Console.WriteLine($"{shape.GetType().Name}: {shape.Area}");
            }
        }

        public static void CalculateSum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
