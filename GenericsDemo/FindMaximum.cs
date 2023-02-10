using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class FindMaximum
    {
        public static int FindMaxvalue(int first, int second, int third) 
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
                //Console.WriteLine("{0} is greater", first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
                //Console.WriteLine("{0} is greater", second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
                //Console.WriteLine("{0} is greater", third);
            }
            else 
            {
                return default;
                //Console.WriteLine(" 2 & 3 numbers having same value");
            }
        }
        public static float FindMaxvalue(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
                //Console.WriteLine("{0} is greater", first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
                //Console.WriteLine("{0} is greater", second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
                //Console.WriteLine("{0} is greater", third);
            }
            else
            {
                return default;
                //Console.WriteLine(" 2 & 3 numbers having same value");
            }
        }
        public static string FindMaxvalue(string first, string second, string third)
        {
            // -1 1 0
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
                //Console.WriteLine("{0} is greater", first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
                //Console.WriteLine("{0} is greater", second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
                //Console.WriteLine("{0} is greater", third);
            }
            else
            {
                return default;
                //Console.WriteLine(" 2 & 3 numbers having same value");
            }
        }

    }
}
