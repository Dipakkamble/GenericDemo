using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericClassConcept<T>
    {
        public T[] array;
        public GenericClassConcept(T[] array) 
        {
            this.array = array;
        }
        public void ToPrint() 
        {
            Console.WriteLine("\nDisplaying values");
            foreach (T element in array) 
            {
                Console.Write(element + " ");
            }
        }
    }
}
