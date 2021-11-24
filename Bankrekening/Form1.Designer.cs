
namespace Bankrekening
{
    partial class Bank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDepositLeft = new System.Windows.Forms.Label();
            this.txbDepositLeft = new System.Windows.Forms.TextBox();
            this.btnDepositLeft = new System.Windows.Forms.Button();
            this.btnWithdrawLeft = new System.Windows.Forms.Button();
            this.txbWithdrawLeft = new System.Windows.Forms.TextBox();
            this.lblWithdrawLeft = new System.Windows.Forms.Label();
            this.btnTransferLeft = new System.Windows.Forms.Button();
            this.txbTransferLeft = new System.Windows.Forms.TextBox();
            this.lblTransferLeft = new System.Windows.Forms.Label();
            this.grbLeft = new System.Windows.Forms.GroupBox();
            this.lblBalanceLeft = new System.Windows.Forms.Label();
            this.grbRight = new System.Windows.Forms.GroupBox();
            this.lblBalanceRight = new System.Windows.Forms.Label();
            this.lblDepostRight = new System.Windows.Forms.Label();
            this.btnTransferRight = new System.Windows.Forms.Button();
            this.txbDepositRight = new System.Windows.Forms.TextBox();
            this.txbTransferRight = new System.Windows.Forms.TextBox();
            this.btnDepositRight = new System.Windows.Forms.Button();
            this.lblTransferRight = new System.Windows.Forms.Label();
            this.lblWithdrawRight = new System.Windows.Forms.Label();
            this.btnWithdrawRight = new System.Windows.Forms.Button();
            this.txbWithdrawRight = new System.Windows.Forms.TextBox();
            this.grbLeft.SuspendLayout();
            this.grbRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepositLeft
            // 
            this.lblDepositLeft.AutoSize = true;
            this.lblDepositLeft.Location = new System.Drawing.Point(12, 34);
            this.lblDepositLeft.Name = "lblDepositLeft";
            this.lblDepositLeft.Size = new System.Drawing.Size(60, 17);
            this.lblDepositLeft.TabIndex = 0;
            this.lblDepositLeft.Text = "Deposit:";
            // 
            // txbDepositLeft
            // 
            this.txbDepositLeft.Location = new System.Drawing.Point(15, 54);
            this.txbDepositLeft.Name = "txbDepositLeft";
            this.txbDepositLeft.Size = new System.Drawing.Size(100, 22);
            this.txbDepositLeft.TabIndex = 1;
            // 
            // btnDepositLeft
            // 
            this.btnDepositLeft.Location = new System.Drawing.Point(15, 83);
            this.btnDepositLeft.Name = "btnDepositLeft";
            this.btnDepositLeft.Size = new System.Drawing.Size(100, 23);
            this.btnDepositLeft.TabIndex = 2;
            this.btnDepositLeft.Text = "Deposit";
            this.btnDepositLeft.UseVisualStyleBackColor = true;
            this.btnDepositLeft.Click += new System.EventHandler(this.btnDepositLeft_Click);
            // 
            // btnWithdrawLeft
            // 
            this.btnWithdrawLeft.Location = new System.Drawing.Point(121, 83);
            this.btnWithdrawLeft.Name = "btnWithdrawLeft";
            this.btnWithdrawLeft.Size = new System.Drawing.Size(100, 23);
            this.btnWithdrawLeft.TabIndex = 5;
            this.btnWithdrawLeft.Text = "Withdraw";
            this.btnWithdrawLeft.UseVisualStyleBackColor = true;
            this.btnWithdrawLeft.Click += new System.EventHandler(this.btnWithdrawLeft_Click);
            // 
            // txbWithdrawLeft
            // 
            this.txbWithdrawLeft.Location = new System.Drawing.Point(121, 54);
            this.txbWithdrawLeft.Name = "txbWithdrawLeft";
            this.txbWithdrawLeft.Size = new System.Drawing.Size(100, 22);
            this.txbWithdrawLeft.TabIndex = 4;
            // 
            // lblWithdrawLeft
            // 
            this.lblWithdrawLeft.AutoSize = true;
            this.lblWithdrawLeft.Location = new System.Drawing.Point(118, 34);
            this.lblWithdrawLeft.Name = "lblWithdrawLeft";
            this.lblWithdrawLeft.Size = new System.Drawing.Size(70, 17);
            this.lblWithdrawLeft.TabIndex = 3;
            this.lblWithdrawLeft.Text = "Withdraw:";
            // 
            // btnTransferLeft
            // 
            this.btnTransferLeft.Location = new System.Drawing.Point(227, 83);
            this.btnTransferLeft.Name = "btnTransferLeft";
            this.btnTransferLeft.Size = new System.Drawing.Size(100, 23);
            this.btnTransferLeft.TabIndex = 8;
            this.btnTransferLeft.Text = "Transfer";
            this.btnTransferLeft.UseVisualStyleBackColor = true;
            this.btnTransferLeft.Click += new System.EventHandler(this.btnTransferLeft_Click);
            // 
            // txbTransferLeft
            // 
            this.txbTransferLeft.Location = new System.Drawing.Point(227, 54);
            this.txbTransferLeft.Name = "txbTransferLeft";
            this.txbTransferLeft.Size = new System.Drawing.Size(100, 22);
            this.txbTransferLeft.TabIndex = 7;
            // 
            // lblTransferLeft
            // 
            this.lblTransferLeft.AutoSize = true;
            this.lblTransferLeft.Location = new System.Drawing.Point(224, 34);
            this.lblTransferLeft.Name = "lblTransferLeft";
            this.lblTransferLeft.Size = new System.Drawing.Size(66, 17);
            this.lblTransferLeft.TabIndex = 6;
            this.lblTransferLeft.Text = "Transfer:";
            // 
            // grbLeft
            // 
            this.grbLeft.Controls.Add(this.lblBalanceLeft);
            this.grbLeft.Controls.Add(this.lblDepositLeft);
            this.grbLeft.Controls.Add(this.btnTransferLeft);
            this.grbLeft.Controls.Add(this.txbDepositLeft);
            this.grbLeft.Controls.Add(this.txbTransferLeft);
            this.grbLeft.Controls.Add(this.btnDepositLeft);
            this.grbLeft.Controls.Add(this.lblTransferLeft);
            this.grbLeft.Controls.Add(this.lblWithdrawLeft);
            this.grbLeft.Controls.Add(this.btnWithdrawLeft);
            this.grbLeft.Controls.Add(this.txbWithdrawLeft);
            this.grbLeft.Location = new System.Drawing.Point(12, 12);
            this.grbLeft.Name = "grbLeft";
            this.grbLeft.Size = new System.Drawing.Size(344, 138);
            this.grbLeft.TabIndex = 9;
            this.grbLeft.TabStop = false;
            this.grbLeft.Text = "Bank account left";
            // 
            // lblBalanceLeft
            // 
            this.lblBalanceLeft.AutoSize = true;
            this.lblBalanceLeft.Location = new System.Drawing.Point(15, 115);
            this.lblBalanceLeft.Name = "lblBalanceLeft";
            this.lblBalanceLeft.Size = new System.Drawing.Size(16, 17);
            this.lblBalanceLeft.TabIndex = 9;
            this.lblBalanceLeft.Text = "0";
            // 
            // grbRight
            // 
            this.grbRight.Controls.Add(this.lblBalanceRight);
            this.grbRight.Controls.Add(this.lblDepostRight);
            this.grbRight.Controls.Add(this.btnTransferRight);
            this.grbRight.Controls.Add(this.txbDepositRight);
            this.grbRight.Controls.Add(this.txbTransferRight);
            this.grbRight.Controls.Add(this.btnDepositRight);
            this.grbRight.Controls.Add(this.lblTransferRight);
            this.grbRight.Controls.Add(this.lblWithdrawRight);
            this.grbRight.Controls.Add(this.btnWithdrawRight);
            this.grbRight.Controls.Add(this.txbWithdrawRight);
            this.grbRight.Location = new System.Drawing.Point(362, 12);
            this.grbRight.Name = "grbRight";
            this.grbRight.Size = new System.Drawing.Size(344, 138);
            this.grbRight.TabIndex = 10;
            this.grbRight.TabStop = false;
            this.grbRight.Text = "Bank account right";
            // 
            // lblBalanceRight
            // 
            this.lblBalanceRight.AutoSize = true;
            this.lblBalanceRight.Location = new System.Drawing.Point(12, 115);
            this.lblBalanceRight.Name = "lblBalanceRight";
            this.lblBalanceRight.Size = new System.Drawing.Size(16, 17);
            this.lblBalanceRight.TabIndex = 10;
            this.lblBalanceRight.Text = "0";
            // 
            // lblDepostRight
            // 
            this.lblDepostRight.AutoSize = true;
            this.lblDepostRight.Location = new System.Drawing.Point(12, 34);
            this.lblDepostRight.Name = "lblDepostRight";
            this.lblDepostRight.Size = new System.Drawing.Size(60, 17);
            this.lblDepostRight.TabIndex = 0;
            this.lblDepostRight.Text = "Deposit:";
            // 
            // btnTransferRight
            // 
            this.btnTransferRight.Location = new System.Drawing.Point(227, 83);
            this.btnTransferRight.Name = "btnTransferRight";
            this.btnTransferRight.Size = new System.Drawing.Size(100, 23);
            this.btnTransferRight.TabIndex = 8;
            this.btnTransferRight.Text = "Transfer";
            this.btnTransferRight.UseVisualStyleBackColor = true;
            this.btnTransferRight.Click += new System.EventHandler(this.btnTransferRight_Click);
            // 
            // txbDepositRight
            // 
            this.txbDepositRight.Location = new System.Drawing.Point(15, 54);
            this.txbDepositRight.Name = "txbDepositRight";
            this.txbDepositRight.Size = new System.Drawing.Size(100, 22);
            this.txbDepositRight.TabIndex = 1;
            // 
            // txbTransferRight
            // 
            this.txbTransferRight.Location = new System.Drawing.Point(227, 54);
            this.txbTransferRight.Name = "txbTransferRight";
            this.txbTransferRight.Size = new System.Drawing.Size(100, 22);
            this.txbTransferRight.TabIndex = 7;
            // 
            // btnDepositRight
            // 
            this.btnDepositRight.Location = new System.Drawing.Point(15, 83);
            this.btnDepositRight.Name = "btnDepositRight";
            this.btnDepositRight.Size = new System.Drawing.Size(100, 23);
            this.btnDepositRight.TabIndex = 2;
            this.btnDepositRight.Text = "Deposit";
            this.btnDepositRight.UseVisualStyleBackColor = true;
            this.btnDepositRight.Click += new System.EventHandler(this.btnDepositRight_Click);
            // 
            // lblTransferRight
            // 
            this.lblTransferRight.AutoSize = true;
            this.lblTransferRight.Location = new System.Drawing.Point(224, 34);
            this.lblTransferRight.Name = "lblTransferRight";
            this.lblTransferRight.Size = new System.Drawing.Size(66, 17);
            this.lblTransferRight.TabIndex = 6;
            this.lblTransferRight.Text = "Transfer:";
            // 
            // lblWithdrawRight
            // 
            this.lblWithdrawRight.AutoSize = true;
            this.lblWithdrawRight.Location = new System.Drawing.Point(118, 34);
            this.lblWithdrawRight.Name = "lblWithdrawRight";
            this.lblWithdrawRight.Size = new System.Drawing.Size(70, 17);
            this.lblWithdrawRight.TabIndex = 3;
            this.lblWithdrawRight.Text = "Withdraw:";
            // 
            // btnWithdrawRight
            // 
            this.btnWithdrawRight.Location = new System.Drawing.Point(121, 83);
            this.btnWithdrawRight.Name = "btnWithdrawRight";
            this.btnWithdrawRight.Size = new System.Drawing.Size(100, 23);
            this.btnWithdrawRight.TabIndex = 5;
            this.btnWithdrawRight.Text = "Withdraw";
            this.btnWithdrawRight.UseVisualStyleBackColor = true;
            this.btnWithdrawRight.Click += new System.EventHandler(this.btnWithdrawRight_Click);
            // 
            // txbWithdrawRight
            // 
            this.txbWithdrawRight.Location = new System.Drawing.Point(121, 54);
            this.txbWithdrawRight.Name = "txbWithdrawRight";
            this.txbWithdrawRight.Size = new System.Drawing.Size(100, 22);
            this.txbWithdrawRight.TabIndex = 4;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 157);
            this.Controls.Add(this.grbRight);
            this.Controls.Add(this.grbLeft);
            this.Name = "Bank";
            this.Text = "Bank";
            this.grbLeft.ResumeLayout(false);
            this.grbLeft.PerformLayout();
            this.grbRight.ResumeLayout(false);
            this.grbRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDepositLeft;
        private System.Windows.Forms.TextBox txbDepositLeft;
        private System.Windows.Forms.Button btnDepositLeft;
        private System.Windows.Forms.Button btnWithdrawLeft;
        private System.Windows.Forms.TextBox txbWithdrawLeft;
        private System.Windows.Forms.Label lblWithdrawLeft;
        private System.Windows.Forms.Button btnTransferLeft;
        private System.Windows.Forms.TextBox txbTransferLeft;
        private System.Windows.Forms.Label lblTransferLeft;
        private System.Windows.Forms.GroupBox grbLeft;
        private System.Windows.Forms.GroupBox grbRight;
        private System.Windows.Forms.Label lblDepostRight;
        private System.Windows.Forms.Button btnTransferRight;
        private System.Windows.Forms.TextBox txbDepositRight;
        private System.Windows.Forms.TextBox txbTransferRight;
        private System.Windows.Forms.Button btnDepositRight;
        private System.Windows.Forms.Label lblTransferRight;
        private System.Windows.Forms.Label lblWithdrawRight;
        private System.Windows.Forms.Button btnWithdrawRight;
        private System.Windows.Forms.TextBox txbWithdrawRight;
        private System.Windows.Forms.Label lblBalanceLeft;
        private System.Windows.Forms.Label lblBalanceRight;
    }
}

