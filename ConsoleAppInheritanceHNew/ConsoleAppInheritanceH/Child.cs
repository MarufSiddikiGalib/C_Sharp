using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceH
{
    internal class Child : Parent
    {
        internal Child() //: base(35)
        {
            Console.WriteLine("Child D");
        }

        internal Child(int y) : this("ABC")
        {
            Console.WriteLine("Child NDC-I " + y);
        }

        internal Child(string k) : this()
        {
            Console.WriteLine("Child NDC-S " + k);
        }

        internal void MethodA()
        {
            Console.WriteLine("Child MethodA");
        }

        internal override sealed void MethodB()
        {
            Console.WriteLine("Child MethodB");
        }

        internal new virtual void MethodC()
        {
            Console.WriteLine("Child MethodC");
        }

        internal override void MethodD()
        {
            Console.WriteLine("Child MethodD");
        }
    }
}
