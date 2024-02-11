using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAppGenericH
{
    internal class Sample
    {
        private int ax;

        private int[] bx = new int[4];

        private int[] cx = new int[4];

        private int[] dx = new int[3];

        internal int Ax 
        {
            get { return this.ax; }
            set { this.ax = value; }
        }

        internal int[] Bx
        {
            get { return this.bx; }
            set { this.bx = value; }
        }

        internal int this[int p]
        {
            get { return this.cx[p]; }
            set { this.cx[p] = value; }
        }

        internal int this[int m, int n]
        {
            get { return this.dx[m]; }
            set { this.dx[m] = value; }
        }
    }
}
