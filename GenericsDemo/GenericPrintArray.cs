using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericPrintArray
    {
        public static void ToPrint<T>(T[] Array)
        {
            Console.WriteLine("\nDiplaying values");
            foreach (T element in Array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
