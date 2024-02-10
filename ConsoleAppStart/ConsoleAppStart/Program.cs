using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStart
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

            Point p2 = p1;
            p2.x++;
            p2.y--;
            p2.PrintPoint();
            p1.PrintPoint();
            //Console.WriteLine("({0},{1})", p2.x, p2.y);
            //Console.WriteLine("({0},{1})", p1.x, p1.y);

            //Point p3;
            //p3.x = Convert.ToInt32(Console.ReadLine());
            //p3.y = Convert.ToInt32(Console.ReadLine());
            //p3.PrintPoint();

            Point p4 = new Point();
            p4.x = -7;
            p4.y = 26;
            //p4.x++;p4.y++;
            p4.PrintPoint();

            Point p5 = new Point(98, -65);
            p5.PrintPoint();

            //Console.WriteLine("Welcome to Fall 2023-24");
            //Console.Write("Welcome to C#\n\n");

            //type_name var_name [=init];
            //int ax = 10;
            ////ax = 10;
            //ax++;

            //string s1 = Console.ReadLine();
            //Console.WriteLine("Output1: " + s1);

            ////string s2 = Console.ReadLine();
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //n1++;
            //Console.WriteLine("Output2: " + n1);

            //int n2 = Int32.Parse(Console.ReadLine());
            //n2--;
            //Console.WriteLine("Output2: " + n2);

            int p;
            short q = 256;
            byte r;
            p = q;
            r = (byte)q;
            Console.WriteLine(r);

            //printf("x: %d", x);
            int x = 10, y = 20, z = 30;
            string s1 = "hello";
            Console.WriteLine("x: " + x + ", y: " + y + ", z: " + z);
            Console.WriteLine("x: {0}, y: {1}, z: {2}", x, s1, z);
            Console.WriteLine($"x: {x}, y: {s1}, z: {z}");

        }
    }
}
