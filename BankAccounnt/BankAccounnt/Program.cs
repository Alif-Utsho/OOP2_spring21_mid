using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Account alif = new Savings("Alif", "001", 5000.0f);
            Account utsho = new Current("Utsho", "002", 2000f);
            Account rakib = new Fixed("Rakib", "003", 1000f, 2015, 10);
            
            Account ss = new SuperSavings("Shahriar", "004", 100f);
            ss.Withdraw(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Arif", "005", 1000f, 5000);
            overdraft.Transfer(ss, 5000);
            overdraft.ShowInfo();

            Customer customer = new Customer("Alif Uthso");

            //alif.ShowInfo();
            //alif.Deposit(2000f);
            //alif.ShowInfo();
            //alif.Withdraw(3000);
            //alif.ShowInfo();

            //rakib.Deposit(5000);
            //rakib.Withdraw(1000);
            //rakib.ShowInfo();

            //alif.Transfer(utsho, 1000f);
            //utsho.ShowInfo();

            //customer.AddAccount(alif, utsho);
            //customer.AccDetails();
        }
    }
}
