using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankrekening
{
    public partial class BankAccountForm : Form
    {
        private BankAccount bankAccountLeft;
        private BankAccount bankAccountRight;
        public BankAccountForm()
        {
            InitializeComponent();
            bankAccountLeft = new BankAccount("Duck, Dagobert");
            bankAccountRight = new BankAccount("Gans, Gijs", 200);
        }

        private void btnDepositLeft_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbDepositLeft.Text, out int number))
            {
                bankAccountLeft.Deposit(number);
                lblBalanceLeft.Text = bankAccountLeft.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Amount is not a number", "Error");
            }
            txbDepositLeft.Text = "";
        }

        private void btnWithdrawLeft_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbWithdrawLeft.Text, out int number))
            {
                bankAccountLeft.Withdraw(number);
                lblBalanceLeft.Text = bankAccountLeft.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Amount is not a number", "Error");
            }
            txbWithdrawLeft.Text = "";
        }

        private void btnTransferLeft_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbTransferLeft.Text, out int number))
            {
                bankAccountLeft.Transfer(bankAccountRight, number);
                lblBalanceLeft.Text = bankAccountLeft.Balance.ToString("C");
                lblBalanceRight.Text = bankAccountRight.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Amount is not a number", "Error");
            }
            txbTransferLeft.Text = "";
        }

        private void btnDepositRight_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbDepositRight.Text, out int number))
            {
                bankAccountRight.Deposit(number);
                lblBalanceRight.Text = bankAccountRight.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Amount is not a number", "Error");
            }
            txbDepositRight.Text = "";
        }

        private void btnWithdrawRight_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbWithdrawRight.Text, out int number))
            {
                bankAccountRight.Withdraw(number);
                lblBalanceRight.Text = bankAccountRight.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Amount is not a number", "Error");
            }
            txbWithdrawRight.Text = "";
        }

        private void btnTransferRight_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbTransferRight.Text, out int number))
            {
                bankAccountRight.Transfer(bankAccountLeft, number);
                lblBalanceLeft.Text = bankAccountLeft.Balance.ToString("C");
                lblBalanceRight.Text = bankAccountRight.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Amount is not a number", "Error");
            }
            txbTransferRight.Text = "";
        }

        private void BankAccountForm_Load(object sender, EventArgs e)
        {
            lblBalanceLeft.Text = bankAccountLeft.Balance.ToString("C");
            lblBalanceRight.Text = bankAccountRight.Balance.ToString("C");
        }
    }
}
