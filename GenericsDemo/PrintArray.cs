using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class PrintArray
    {
        public static void ToPrint(int[] Array) 
        {
            Console.WriteLine("\nDiplaying integer numbers");
            foreach (int element in Array) 
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrint(double[] Array)
        {
            Console.WriteLine("\nDisplaying double values");
            foreach (double element in Array)
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrint(char[] Array)
        {
            Console.WriteLine("\nDisplaying character");
            foreach (char element in Array)
            {
                Console.Write(element + " ");
            }
        }

    }
}
