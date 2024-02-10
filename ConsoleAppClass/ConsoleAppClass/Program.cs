using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddressFormat a1 = new AddressFormat(23, 78, 1298, "Sylhet");

            Student s1 = new Student();
            s1.SetId(100);//s1.id = 100;
            s1.SetName("Bruce");//s1.name = "bruce";
            s1.SetCgpa(5.24);//s1.cgpa = 3.24;
            s1.SetBloodGroup("B+");//s1.bloodGroup = "B+";
            s1.SetAddress(new AddressFormat(23, 78, 1298, "Sylhet"));
            s1.PrintStudentInfo();

            Student s2 = new Student(200, "Clerk", -3.19, "AB+", new AddressFormat(37, 29, 7356, "Khulna"));
            s2.PrintStudentInfo();

            //Student s3 = s1;
            //s3.cgpa = 3.11;
            //s1.PrintStudentInfo();

            //Student s3 = new Student();
            //s3.InputMethod();
            //s3.PrintStudentInfo();

            //int[] ax = new int[4] { 34, 98, 7, 100 };

            //for(byte q = 0; q < ax.Length; q++)
            //{
            //    Console.Write("{0} ", ax[q]);
            //}
            //Console.WriteLine();

            //byte k = 0;
            //while(k < ax.Length)
            //{
            //    Console.Write("{0} ", ax[k]);
            //    k++;
            //}
            //Console.WriteLine();

            //k = 0;
            //do
            //{
            //    Console.Write("{0} ", ax[k]);
            //    k++;
            //}
            //while (k < ax.Length);
            //Console.WriteLine();

            //foreach(int p in ax)
            //{
            //    Console.Write("{0} ", p);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //int[,] bx = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            //int r = 0, c;
            //while(r < 4)
            //{
            //    c = 0;
            //    while(c < 3)
            //    {
            //        Console.Write("{0} ", bx[r,c]);
            //        c++;
            //    }
            //    Console.WriteLine();
            //    r++;
            //}
            //Console.WriteLine();

            //foreach (int p in bx)
            //{
            //    Console.Write("{0} ", p);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //int[,,,] ex = new int[3, 4, 3, 7];

            //int[][] jx = new int[4][];
            //jx[0] = new int[3] { 1, 2, 3 };
            //jx[1] = new int[2] { 4, 5 };
            //jx[2] = new int[5] { 6, 7, 8, 9, 10 };
            //jx[3] = new int[1] { 11 };

            //r = 0;
            //while (r < jx.Length)
            //{
            //    c = 0;
            //    while (c < jx[r].Length)
            //    {
            //        Console.Write("{0} ", jx[r][c]);
            //        c++;
            //    }
            //    Console.WriteLine();
            //    r++;
            //}
            //Console.WriteLine();
        }
    }
}
