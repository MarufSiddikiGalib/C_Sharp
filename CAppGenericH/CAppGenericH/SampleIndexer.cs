using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAppGenericH
{
    internal class SampleIndexer
    {
        private int ax;

        private int[] bx = new int[4];

        private int[] cx = new int[5];

        private int[] dx = new int[5];

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

        internal int this[int r]
        {
            get { return this.cx[r]; }
            set { this.cx[r] = value; }
        }

        internal int this[int i, int j]
        {
            get { return this.dx[i]; }
            set { this.dx[i] = value; }
        }
    }
}
