using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
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
    internal class Computer
    {
        public int MemorySize { get; private set; }
        public double CPUClockSpeed { get; private set; }
        public DateFormat PurchaseDate { get; private set; }
        public string CashType { get; private set; }
        public bool IsHDMIPortAvailable { get; private set; }

        
       public Computer()
        {
            
        }

       
        public Computer(int memorySize, double cpuClockSpeed, DateFormat purchaseDate, string cashType, bool isHDMIPortAvailable)
        {
            MemorySize = memorySize;
            CPUClockSpeed = cpuClockSpeed;
            PurchaseDate = purchaseDate;
            CashType = cashType;
            IsHDMIPortAvailable = isHDMIPortAvailable;
        }


        internal int MemoSize
        {
            get { return this.MemorySize; }
            set { this.MemorySize = value; }

        }

       

        internal double CPUClkSpeed
        {
            get { return this.CPUClockSpeed; }
            set { this.CPUClockSpeed = value; }

        }


        internal String CshType
        {
            get { return this.CashType; }
            set { this.CashType = value; }

        }

        internal DateFormat PrchaseDate
       {
           get { return this.PurchaseDate; }
           set { this.PurchaseDate = value; }
       }
        static void Main(string[] args)
        {
            DateFormat date1 = new DateFormat(01, 08, 2023);



            Computer defaultComputer = new Computer();

            
            Computer customComputer = new Computer(8, 2.5, date1 , "Cash", true);

            
            Console.WriteLine("Default Computer Attributes:");
            Console.WriteLine($"Memory Size: {defaultComputer.MemorySize} GB");
            Console.WriteLine($"CPU Clock Speed: {defaultComputer.CPUClockSpeed} GHz");
            Console.WriteLine($"Purchase Date: {defaultComputer.PurchaseDate}");
            Console.WriteLine($"Cash Type: {defaultComputer.CashType}");
            Console.WriteLine($"HDMI Port Available: {defaultComputer.IsHDMIPortAvailable}");

            
            Console.WriteLine("\nCustom Computer Attributes:");
            Console.WriteLine($"Memory Size: {customComputer.MemorySize} GB");
            Console.WriteLine($"CPU Clock Speed: {customComputer.CPUClockSpeed} GHz");
            Console.WriteLine($"Purchase Date: {customComputer.PurchaseDate}");
            Console.WriteLine($"Cash Type: {customComputer.CashType}");
            Console.WriteLine($"HDMI Port Available: {customComputer.IsHDMIPortAvailable}");
        }
    }
}
