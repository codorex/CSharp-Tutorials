using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAdvanced.Extensions
{
    public delegate int GenericComparer<T>(T a, T b);

    public static class GenericArrayExtensions
    {
        public static void Sort<T>(this T[] array, GenericComparer<T> comparer)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) > -1 ? true : false)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp;

            temp = a;
            a = b;
            b = temp;
        }
    }
}
