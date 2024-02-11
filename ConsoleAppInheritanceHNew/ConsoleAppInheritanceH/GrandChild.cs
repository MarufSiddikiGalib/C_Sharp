using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceH
{
    class GrandChild : Child
    {
        internal GrandChild() //: base(35)
        {
            Console.WriteLine("GrandChild D");
        }

        //internal override void MethodB()
        //{
        //    Console.WriteLine("GrandChild MethodB");
        //}

        internal override void MethodC()
        {
            Console.WriteLine("GrandChild MethodC");
        }
    }
}
