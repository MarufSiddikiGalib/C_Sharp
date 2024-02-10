using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceA
{
    internal class Parent
    {
        internal Parent() //: this("hellow")
        {
            Console.WriteLine("Parent D");
        }

        internal Parent(int z) : this()
        {
            Console.WriteLine("Parent NDC-I " + z);
        }

        internal Parent(string w)
        {
            Console.WriteLine("Parent NDC-S " + w);
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
    }
}
