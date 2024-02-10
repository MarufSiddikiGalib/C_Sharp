using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStructQ
{
    struct Point 
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine("({0},{1})", this.x, this.y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 3;
            p1.y = 5;
            //Console.WriteLine("({0},{1})", p1.x, p1.y);
            p1.PrintPoint();

            //Point p2;
            //p2.x = Convert.ToInt32(Console.ReadLine());
            //p2.y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("({0},{1})", p2.x, p2.y);

            Point p3 = p1;
            p3.x++;
            p3.y--;
            p3.PrintPoint();
            p1.PrintPoint();
            //Console.WriteLine("({0},{1})", p3.x, p3.y);
            //Console.WriteLine("({0},{1})", p1.x, p1.y);

            Point p4 = new Point();
            //p4 = p1;
            p4.x = 90;
            p4.y = -34;
            p4.PrintPoint();

            Point p5 = new Point(23, -41);
            p5.PrintPoint();

            //int x = 10, y = 20, z = 30;
            //string a = "hello";
            //Console.WriteLine("x: " + x + ", y: " + y + ", z: " + z);
            //Console.WriteLine("x: {0}, y: {1}, z: {2}", x, y, z);
            //Console.WriteLine($"x: {x}, y: {y}, z: {z}");

            short p = 9;
            int q = p;
            byte r = (byte)q;
        }
    }
}
//printf("x: %d",x);