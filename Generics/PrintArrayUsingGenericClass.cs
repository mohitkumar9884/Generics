using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArrayUsingGenericClass<T>
    {
        public T[] arr;

        public PrintArrayUsingGenericClass(T[] arr)
        {
            this.arr = arr;
        }
        
        public  void ToPrint()
        {
            Console.WriteLine("\n Array elements");
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}
