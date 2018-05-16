using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapArray
{
    public delegate int Transformer(int x);

    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3 };

            Transformer transform = Square;

            numbers.Map(transform);
            

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static int Square(int n)
        {
            return n * n;
        }
    }

    public static class ArrayExtensions
    {
        public static int[] Map(this int[] array, Transformer tranform)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tranform(array[i]);
            }

            return array;
        }
    }
}
