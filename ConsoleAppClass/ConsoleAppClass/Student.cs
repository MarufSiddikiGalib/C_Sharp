using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    struct AddressFormat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        public AddressFormat(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("Student Address");
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}\n", this.district);
        }
    }

    class Student
    {
        private int id;
        private string name;
        private double cgpa;
        private string bloodGroup;
        private AddressFormat address;

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetCgpa()
        {
            return this.cgpa;
        }

        public void SetCgpa(double cgpa)
        {
            if (cgpa <= 4.0 && cgpa >= 0)
                this.cgpa = cgpa;
            else
                this.cgpa = -1;
        }

        public string GetBloodGroup()
        {
            return this.bloodGroup;
        }

        public void SetBloodGroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
        }

        public AddressFormat GetAddress()
        {
            return this.address;
        }

        public void SetAddress(AddressFormat address)
        {
            this.address = address;
        }

        public Student()
        {
            //this.InputMethod();
        }

        public Student(int id, string name, double cgpa, string bloodGroup, AddressFormat address)
        {
            this.SetId(id);//this.id = id;
            this.SetName(name);//this.name = name;
            this.SetCgpa(cgpa);//this.cgpa = cgpa;
            this.SetBloodGroup(bloodGroup);//this.bloodGroup = bloodGroup;
            this.SetAddress(address);
        }

        private void InputMethod()
        {
            this.id = Convert.ToInt32(Console.ReadLine());
            this.name = Console.ReadLine();
            this.SetCgpa(Convert.ToDouble(Console.ReadLine()));//this.cgpa = Convert.ToDouble(Console.ReadLine());
            this.bloodGroup = Console.ReadLine();
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student ID: {0}", this.GetId());//this.id);
            Console.WriteLine("Student Name: {0}", this.GetName());//this.name);
            Console.WriteLine("Student CGPA: {0}", this.GetCgpa());//this.cgpa);
            Console.WriteLine("Student Blood Group: {0}", this.GetBloodGroup());//this.bloodGroup);
            this.GetAddress().PrintAddress();//this.address.PrintAddress();
        }
    }
}
