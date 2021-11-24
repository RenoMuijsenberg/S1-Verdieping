using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class BankAccount
    {
        private int accountNumber;
        private string name;
        private int balance;
        private static int nextFreeAccountNumber = 2001;

        public BankAccount(string name)
        {
            this.name = name;
            balance = 0;
            accountNumber = nextFreeAccountNumber;
            nextFreeAccountNumber++;
        }

        public BankAccount(string name, int amount)
        {
            this.name = name;
            balance = amount;
            accountNumber = nextFreeAccountNumber;
            nextFreeAccountNumber++;
        }

        public void Withdraw(int amount)
        {
            if (amount > 0)
            {
                if (balance - amount >= 0)
                {
                    this.balance -= amount;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Not enough balance", "Error");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Can not withdraw negative amount", "Error");
            }
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Can not deposit negative amount", "Error");
            }
        }

        public void Transfer(BankAccount otherBankAccount, int amount)
        {

            if (amount > 0)
            {
                if (balance - amount >= 0)
                {
                    this.balance -= amount;
                    otherBankAccount.balance = otherBankAccount.balance + amount;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Not enough balance", "Error");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Can not transfer negative amount", "Error");
            }
        }

        public int Balance
        {
            get { return balance; }
        }
    }
}
