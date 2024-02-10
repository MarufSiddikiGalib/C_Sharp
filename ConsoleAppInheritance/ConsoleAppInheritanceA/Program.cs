using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person(100, "Bruce", "B+", new AddressFormat(23, 55, 1299, "Khulna"));
            Person[] pList = new Person[3];
            pList[0] = new Person(100, "Bruce", "B+", new AddressFormat(23, 55, 1299, "Khulna"));
            pList[1] = new Student(200, "Clerk", "AB+", new AddressFormat(61, 12, 5627, "Sylhet"), 3.41);
            pList[2] = new Employee(300, "Diana", "O+", new AddressFormat(56, 11, 9873, "Bogura"), 12000);

            foreach (Person p in pList)
                p.ShowInfo();


            //Parent p1 = new Parent();
            ////Parent p2 = new Parent(35);
            //Child c1 = new Child();
            ////Child c2 = new Child(100);
            ////Child c3 = new Child("Hello");
            //Parent p = new Child();

            //Console.WriteLine();

            //p1.MethodA();
            //c1.MethodA();
            //p1.MethodB();
            //c1.MethodB();
            //p.MethodA();
            //p.MethodB();
            //p.MethodC();
        }
    }
}
