using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceH
{
    internal class Student : Person
    {
        private double cgpa;

        internal double Cgpa
        {
            get { return this.cgpa; }
            set 
            {
                if (value >= 0.0 && value <= 4.0)
                    this.cgpa = value;
                else
                    this.cgpa = -1;
            }
        }

        internal override string Id
        {
            set { this.id = "P-" + value + "-S"; }
        }

        public Student(string name, string bloodGroup, AddressFormat address, double cgpa) : base(name, bloodGroup, address)
        {
            this.Cgpa = cgpa;
        }

        internal override void ShowPersonInfo()
        {
            base.ShowPersonInfo();
            Console.WriteLine("CGPA: {0}", this.Cgpa);
            Console.WriteLine();
        }
    }
}
