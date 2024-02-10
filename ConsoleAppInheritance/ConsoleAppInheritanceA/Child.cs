using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceA
{
    internal class Child : Parent
    {
        internal Child() //: this(120)//base(25)
        {
            Console.WriteLine("Child D");
        }

        internal Child(int a) : base(a)
        {
            Console.WriteLine("Child NDC-I " + a);
        }

        internal Child(string w) : this()//base(w)
        {
            Console.WriteLine("Child NDC-S " + w);
        }

        internal void MethodA()
        {
            Console.WriteLine("Child MethodA");
        }

        internal override void MethodB()
        {
            Console.WriteLine("Child MethodB");
        }

        internal new void MethodC()
        {
            Console.WriteLine("Child MethodC");
        }
    }
}
