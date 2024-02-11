using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceH
{
    internal abstract class Parent
    {
        internal Parent() //: this("world")
        {
            Console.WriteLine("Parent D");
        }

        internal Parent(int h) : this()
        {
            Console.WriteLine("Parent NDC-I " + h);
        }

        internal Parent(string h)
        {
            Console.WriteLine("Parent NDC-S " + h);
        }

        internal void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("Parent MethodB");
        }

        internal virtual void MethodC()
        {
            Console.WriteLine("Parent MethodC");
        }

        internal abstract void MethodD();
    }
}
