using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class CurrentAccount : Account
    {
        private string accountTransfer;

          internal string AccountTransfer
        {
            get { return this.accountTransfer; }
            set { this.accountTransfer = value; }

        }

        public CurrentAccount(int id, string name, double balance, DateFormat date, string accountTransfer)
                  : base(id, name, balance, date)
        {
            AccountTransfer = accountTransfer;

           
        }

        public void ShowCurrentInfo()
        {
            ShowInfo();
            Console.WriteLine($"Account Transfer : {accountTransfer}");
        }
    }
}
