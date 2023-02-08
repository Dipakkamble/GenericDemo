using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 20, 30, 40, 50 };
            double[] doubleArray = { 23.42, 12.46, 34.21, 67.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Console.WriteLine("Please choose program from below option");
            Console.WriteLine("1:PrintArray\n2:PrintArray using generic method\n3:Generic class concept");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option) 
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    break;
                case 2:
                    GenericPrintArray.ToPrint<int>(intArray);
                    GenericPrintArray.ToPrint<double>(doubleArray);
                    GenericPrintArray.ToPrint<char>(charArray);
                    break;
                case 3:
                    GenericClassConcept<int> intObject= new GenericClassConcept<int>(intArray);
                    intObject.ToPrint();
                    GenericClassConcept<double> doubleObject = new GenericClassConcept<double>(doubleArray);
                    doubleObject.ToPrint();
                    GenericClassConcept<char> charObject = new GenericClassConcept<char>(charArray);
                    charObject.ToPrint();
                    break;
            }
             Console.ReadLine(); 
        }
    }
}
