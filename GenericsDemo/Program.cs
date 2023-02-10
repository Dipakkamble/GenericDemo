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
            int a = 30, b = 30, c = 30;
            float p = 45.8f,q = 45.8f,r = 45.8f;
            string str1 = "abc", str2 = "pqr", str3 = "xyz";

            Console.WriteLine("Please choose program from below option");
            Console.WriteLine("1:PrintArray\n2:PrintArray using generic method\n3:Generic class concept\n4:FindMaximum");
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
                case 4:
                    Console.WriteLine("\nInteger comparision");
                    FindMaximum.FindMaxvalue(a, b, c);
                    Console.WriteLine("\nFloat comparision:");
                    var res = FindMaximum.FindMaxvalue(p, q, r);
                    if(res!=0)
                    Console.WriteLine("{0} is greater among {1},{2},{3}", res, p, q, r);
                    else
                        Console.WriteLine(" 2 & 3 numbers having same values");
                    Console.WriteLine("\nString comparision:");
                    var res1 = FindMaximum.FindMaxvalue(str1,str2,str3);
                    if (res1 !=null)
                        Console.WriteLine("{0} is greater among {1},{2},{3}", res1, str1, str2, str3 );
                    else
                        Console.WriteLine(" 2 & 3 numbers having same values");
                    break;
            }
             Console.ReadLine(); 
        }
    }
}
