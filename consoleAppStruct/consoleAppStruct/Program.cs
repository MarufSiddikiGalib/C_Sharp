using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppStruct
{
    struct Point
    {
        public int x;
        public int y;

        public void PrintPoint()
        {
            Console.WriteLine("({0},{1})", x, y);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           // int x = 10, y = 20, z = 30;
          //  string a = "helo";
           // Console.WriteLine("x: " + x + " y: " + y + " Z: " + z);
           // Console.WriteLine("x : {0}, y:{1}, z:{2}",x,z,y); //placeholder
           // Console.WriteLine("x : {0}, y:{1}, z:{2}", x, a, y);
           // Console.WriteLine($"X: {x}, Y: {y}, Z:{z}"); // plaeholder

            Point p1 = new Point();
            p1.x = 22;
            p1.y = 33;

            //Console.WriteLine("({0},{1})",p1.x, p1.y);
            p1.PrintPoint();

            // Point p2 = new Point();
            // p2.x = Convert.ToInt32(Console.ReadLine());
            // p2.y = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("({0},{1})", p2.x, p2.y);

            // Point p3 = p1;

            short p = 9;
            int q = p;
            byte r = (byte)q;

           
           



            


        }
    }
}
