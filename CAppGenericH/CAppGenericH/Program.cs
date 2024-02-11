using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAppGenericH
{//Indexer
    class Program
    {
        static void Main(string[] args)
        {
            SampleIndexer s = new SampleIndexer();
            s.Ax = 90;
            s.Bx[0] = 87;

            s[0] = 43;//s.cx[0] = 43;
            s[1] = 22;//s.cx[1] = 22;

            s[0, -8] = 90;
            s[1, -8] = 66;
        }
    }
}
