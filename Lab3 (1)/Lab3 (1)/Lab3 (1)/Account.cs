using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__1_
{
    class Account
    {
        string accName, accId;
        int balance;

        public Account(string accName, string accId, int balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
        }

        public void deposit(int amount)
        {
            this.balance += amount;
        }

        public void withdraw(int amount)
        {
            this.balance -= amount;
        }

        public void showInfo()
        {
            Console.WriteLine("Account name: " + accName);
            Console.WriteLine("Account Id: " + accId);
            Console.WriteLine("Available Balance: " + balance);
        }

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        public string AccId
        {
            get { return accId; }
            set { accId = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }


    }
}
