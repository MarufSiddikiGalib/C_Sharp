using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceH
{
    class Program
    {
        //static int m;
        static void Main(string[] args)
        {
            //Person p = new Person(100, "Bruce", "B+", new AddressFormat(34, 12, 1987, "Khulna"));
            //Person[] pList = new Person[4];
            //pList[0] = new Student("Bruce", "B+", new AddressFormat(34, 12, 1987, "Khulna"), 3.65);
            //pList[1] = new Student("Clerk", "AB+", new AddressFormat(44, 90, 8970, "Sylhet"), 3.41);
            //pList[2] = new Employee("Diana", "O+", new AddressFormat(109, 96, 6143, "Bogura"), 12000);
            //pList[3] = new Employee("Arthur", "A+", new AddressFormat(31, 76, 9988, "Cumilla"), 10000);
            ////P-1-S,P-2-S,P-3-E,P-4-E
            //foreach (Person p in pList)
            //    p.ShowPersonInfo();


            //XYZOrganization q = new XYZOrganization();
            XYZOrganization.AddPerson(new Student("Bruce", "B+", new AddressFormat(34, 12, 1987, "Khulna"), 3.65));
            XYZOrganization.AddPerson(new Student("Clerk", "AB+", new AddressFormat(44, 90, 8970, "Sylhet"), 3.41));
            XYZOrganization.AddPerson(new Employee("Diana", "O+", new AddressFormat(109, 96, 6143, "Bogura"), 12000));
            XYZOrganization.AddPerson(new Employee("Arthur", "A+", new AddressFormat(31, 76, 9988, "Cumilla"), 10000));
            //XYZOrganization.ShowAll();
            //XYZOrganization.Search("P-92-S");
            XYZOrganization.DeletePerson("P-2-S");

            //Parent p1 = new Parent();
            ////Parent p2 = new Parent(90);
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

            //Object o1 = 12;
            //Object o2 = 3.89;
            //Object o3 = "hello";
            //Object o4 = new Parent();
            //Console.WriteLine(o1.GetType());
            //Console.WriteLine(o2.GetType());
            //Console.WriteLine(o3.GetType());
            //Console.WriteLine(o4.GetType());

            //var a = 98;
            //var b = 89.234;
            //var c = "world";
            //var d = new Parent();
            //Console.WriteLine(a.GetType());
            //Console.WriteLine(b.GetType());
            //Console.WriteLine(c.GetType());
            //Console.WriteLine(d.GetType());

            //dynamic p = 90;
            //dynamic q = new Parent();
            ////q.NoMethod();
            //m = 9;
            //MM();

            //Nullable<int> r = null;
            //int? g = null;
            //int k = g ?? 40;
            //GrandChild gc = new GrandChild();
            //Child c1 = new GrandChild();
            //Parent p1 = new GrandChild();

            //Parent p2 = new Parent();
        }

        //static void MM() { }
    }
}
