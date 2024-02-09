using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class SavingsAccount : Account
    {
        private int accountDuration;


      

        internal int AccountDuration
        {
            get { return this.accountDuration; }
            set { this.accountDuration = value; }

        }
        public SavingsAccount(int id, string name, double balance, DateFormat date, int accountDuration)
        : base(id, name, balance, date)
        {
            AccountDuration = accountDuration;
        }

        public void ShowSavingsInfo()
        {
            ShowInfo();
            Console.WriteLine($"Account Duration:{accountDuration} ");
        }
    }
}
