using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class Calculator
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine("Result: {0}", x + y);
        }

        public void Addition(int x1, int y, int z)
        {
            Console.WriteLine("Result: {0}", x1 + y + z);
        }

        public void Addition(int x, int y, int z, int w)
        {
            Console.WriteLine("Result: {0}", x + y + z + w);
        }

        public void Addition(string x, int y)
        {
            Console.WriteLine("Result: {0}", x + y);
        }

        public void Addition(int x, string y)
        {
            Console.WriteLine("Result: {0}", x + y);
        }

        public void Addition(string x, int y, int z)
        {
            Console.WriteLine("Result: {0}", x + y + z);
        }

        public string Addition(int x, string y, int z)
        {
            Console.WriteLine("Result: {0}", x + y + z);
            return x + y + z;
        }

        public void Addition(string x, string y, int z)
        {
            Console.WriteLine("Result: {0}", x + y + z);
        }

        public int Addition(int y)
        {
            return 10 + 20;
        }

        public void Addition(int[] info)
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
    }
}
//Method Overloading / Constructor
/*3 conditions
 #no of parameters
 #type of parameters
 #sequence of the type of parameters
     
parameter modifiers     
     */
