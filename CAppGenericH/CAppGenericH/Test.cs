using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAppGenericH
{
    internal class Test
    {
        private int a;
        private int[] b = new int[4];
        private int[] c = new int[5];
        private int[] d = new int[5];

        internal int A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        internal int[] B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        internal int this[int k]
        {
            get { return this.c[k]; }
            set { this.c[k] = value; }
        }

        internal int this[int k, byte r]
        {
            get { return this.d[k]; }
            set { this.d[k] = value; }
        }
    }
}
