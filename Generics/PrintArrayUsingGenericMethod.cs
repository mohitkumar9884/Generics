using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArrayUsingGenericMethod
    {
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("\nArray elements");
            foreach (T element in array)
            {
                Console.Write(element+" ");
            }
        }
    }
}
