using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class BankAccount
    {
        //Fields
        private int accountNumber;
        private string name;
        private int balance = 0;
        private static int nextFreeAccountNumber = 2001;

        //Constructors
        public BankAccount(string Name)
        {
            name = Name;
            accountNumber = nextFreeAccountNumber;
            nextFreeAccountNumber++;
        }

        public BankAccount(string Name, int Amount)
        {
            name = Name;
            balance = Amount;
            accountNumber = nextFreeAccountNumber;
            nextFreeAccountNumber++;
        }

        //Propertys
        public int Balance
        {
            get { return balance; }
        }

        //Methods
        public void Withdraw(int Amount)
        {
            if (Amount > 0)
            {
                if (balance - Amount >= 0)
                {
                    balance -= Amount;
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

        public void Deposit(int Amount)
        {
            if (Amount > 0)
            {
                balance += Amount;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Can not deposit negative amount", "Error");
            }
        }

        public void Transfer(BankAccount OtherBankAccount, int Amount)
        {

            if (Amount > 0)
            {
                if (balance - Amount >= 0)
                {
                    balance -= Amount;
                    OtherBankAccount.balance = OtherBankAccount.balance + Amount;
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
    }
}
