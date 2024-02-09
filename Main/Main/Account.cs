using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Main
{

    struct DateFormat
    {
        private byte day;
        private byte month;
        private int year;

        public DateFormat(byte dd, byte mm, int yy)
        {
            this.day = dd;
            this.month = mm;
            this.year = yy;
        }
    }
    internal class Account
    {
        private int id;
        private string name;
        private double balance;
        private DateFormat date;


        public Account(int id, string name, double balance, DateFormat date)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.date = date;
        }



        internal int Id
        {
            get { return this.id; }
            set { this.id = value; }

        }

        internal String Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }

        /*internal Date
        {
            get { return this.date; }
            set { this.date = value; }
        }*/
        


           public void ShowInfo()
           {
               Console.WriteLine($"Account ID: {id}");
               Console.WriteLine($"Account Holder: {name}");
               Console.WriteLine($"Balance: {balance}");
               Console.WriteLine($"Open Date: {date}");
           }

    }
}

    

