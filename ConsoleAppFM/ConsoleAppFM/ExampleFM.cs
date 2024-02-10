using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class ExampleFM
    {
        public void Summation(params int[] info)
        {
            int sum = 0;
            int index = 0;
            while (index < info.Length)
            {
                sum += info[index];
                index++;
            }

            Console.WriteLine("{0}", sum);
        }

        public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
            Console.WriteLine("After Swap:: a:{0},b:{1}", a, b);
        }

        public void M1(out int r)
        {
            r = 100;
        }

        public void M2(int p, int q = 2, int r = 3)
        {

        }

        public void M3(int d, int e, int f)
        {

        }
    }
}
