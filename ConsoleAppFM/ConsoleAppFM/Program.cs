using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    enum Days : byte
    {
        Saturday = 90,
        Sunday = 70,
        Monday = 86
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Days.Sunday);
            int w = (int)Days.Sunday;
            Console.WriteLine("{0}", w);

            //Sample s = new Sample();
            //int y = Sample.b;
            //int q = s.c;

            //int[] arr = new int[4];
            //arr[0] = 98;
            //int x = 8;

            //int[] a1 = new int[4] { 3, 4, 5, 6 };
            //int[] a2 = new int[5] { 1, 5, 7, 9, 23 };

            //Calculator c = new Calculator();
            //c.Addition(a1);
            //c.Addition(a2);

            //c.Addition(2, 3, 4);
            //c.Addition("abc", 6);
            //c.Addition(3, 4, 5, 6);
            //c.Addition("abc", 2, 5);
            //c.Addition(4, "abc");

            //ExampleFM s1 = new ExampleFM();
            ////s1.Summation(a1);
            //s1.Summation(2, 3, 7, 8);
            //s1.Summation(1, 6, 8, 12, 5, 4, 6, 8);
            //s1.Summation(5, 90, 2);
            //s1.Summation();
            //s1.Summation(4, 5, 7, 8, 9);
            ////s1.Summation(a1);

            //////ref, out, in
            //int j = 10, k = 20, l;
            //s1.Swap(ref j, ref k);
            //Console.WriteLine("After Swap:: j:{0},k:{1}", j, k);
            //s1.M1(out l);
            //s1.M2(5);
            //s1.M3(f: 7, d: 8, e: 9);

        }
    }
}
