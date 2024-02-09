using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateFormat date1 = new DateFormat(01, 08, 2023);

            SavingsAccount savingsAccount = new SavingsAccount(1, "John Doe", 5000.00, date1 , 5);
            CurrentAccount currentAccount = new CurrentAccount(2, "Jane Smith", 8000.00, date1, "Online Transfer");

            Console.WriteLine("Savings Account Information:");
            savingsAccount.ShowSavingsInfo();
            Console.WriteLine("\nCurrent Account Information:");
            currentAccount.ShowCurrentInfo();
        }
    }
}
