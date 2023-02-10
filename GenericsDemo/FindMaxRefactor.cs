using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class FindMaxRefactor<T> where T: IComparable
    {
        public T first,second,third;
        public FindMaxRefactor(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindMaxvalue(T first, T second, T third) 
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

        public void TestMaximum()
        {
            T res=FindMaxvalue(first, second, third);
            Console.WriteLine("Max value:" + res);
        }
    }
}
