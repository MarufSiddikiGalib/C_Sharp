using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFM
{
    class Sample
    {
        public int a = 10;
        public const int b = 20;
        public readonly int c = 89;

        public Sample()
        {
            c = 6;
            c++;
        }

        public Sample(int h)
        {
            c = 7;
            c--;
        }

        void M1()
        {
            //b = 30;
            a = 4;
            //c = 91;
        }
    }
}
