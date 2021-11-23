
namespace EendenVijverVanReno
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ltbDucks = new System.Windows.Forms.ListBox();
            this.lblDuck = new System.Windows.Forms.Label();
            this.lblFrog = new System.Windows.Forms.Label();
            this.ltbFrog = new System.Windows.Forms.ListBox();
            this.btnFrog = new System.Windows.Forms.Button();
            this.ltbStorks = new System.Windows.Forms.ListBox();
            this.lblNextAttack = new System.Windows.Forms.Label();
            this.lblStork = new System.Windows.Forms.Label();
            this.lblNextAttackSec = new System.Windows.Forms.Label();
            this.tmrAttack = new System.Windows.Forms.Timer(this.components);
            this.lblStorkKills = new System.Windows.Forms.Label();
            this.ltbKills = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltbDucks
            // 
            this.ltbDucks.FormattingEnabled = true;
            this.ltbDucks.Location = new System.Drawing.Point(13, 26);
            this.ltbDucks.Name = "ltbDucks";
            this.ltbDucks.Size = new System.Drawing.Size(215, 407);
            this.ltbDucks.TabIndex = 0;
            this.ltbDucks.SelectedIndexChanged += new System.EventHandler(this.ltbDucks_SelectedIndexChanged);
            // 
            // lblDuck
            // 
            this.lblDuck.AutoSize = true;
            this.lblDuck.Location = new System.Drawing.Point(10, 9);
            this.lblDuck.Name = "lblDuck";
            this.lblDuck.Size = new System.Drawing.Size(41, 13);
            this.lblDuck.TabIndex = 1;
            this.lblDuck.Text = "Ducks:";
            // 
            // lblFrog
            // 
            this.lblFrog.AutoSize = true;
            this.lblFrog.Location = new System.Drawing.Point(245, 9);
            this.lblFrog.Name = "lblFrog";
            this.lblFrog.Size = new System.Drawing.Size(36, 13);
            this.lblFrog.TabIndex = 3;
            this.lblFrog.Text = "Frogs:";
            // 
            // ltbFrog
            // 
            this.ltbFrog.FormattingEnabled = true;
            this.ltbFrog.Location = new System.Drawing.Point(248, 26);
            this.ltbFrog.Name = "ltbFrog";
            this.ltbFrog.Size = new System.Drawing.Size(215, 381);
            this.ltbFrog.TabIndex = 2;
            // 
            // btnFrog
            // 
            this.btnFrog.Location = new System.Drawing.Point(248, 410);
            this.btnFrog.Name = "btnFrog";
            this.btnFrog.Size = new System.Drawing.Size(215, 23);
            this.btnFrog.TabIndex = 4;
            this.btnFrog.Text = "Add frog";
            this.btnFrog.UseVisualStyleBackColor = true;
            this.btnFrog.Click += new System.EventHandler(this.btnFrog_Click);
            // 
            // ltbStorks
            // 
            this.ltbStorks.FormattingEnabled = true;
            this.ltbStorks.Location = new System.Drawing.Point(482, 26);
            this.ltbStorks.Name = "ltbStorks";
            this.ltbStorks.Size = new System.Drawing.Size(215, 381);
            this.ltbStorks.TabIndex = 5;
            this.ltbStorks.SelectedIndexChanged += new System.EventHandler(this.ltbStorks_SelectedIndexChanged);
            // 
            // lblNextAttack
            // 
            this.lblNextAttack.AutoSize = true;
            this.lblNextAttack.Location = new System.Drawing.Point(479, 410);
            this.lblNextAttack.Name = "lblNextAttack";
            this.lblNextAttack.Size = new System.Drawing.Size(65, 13);
            this.lblNextAttack.TabIndex = 7;
            this.lblNextAttack.Text = "Next attack:";
            // 
            // lblStork
            // 
            this.lblStork.AutoSize = true;
            this.lblStork.Location = new System.Drawing.Point(479, 9);
            this.lblStork.Name = "lblStork";
            this.lblStork.Size = new System.Drawing.Size(40, 13);
            this.lblStork.TabIndex = 6;
            this.lblStork.Text = "Storks:";
            // 
            // lblNextAttackSec
            // 
            this.lblNextAttackSec.AutoSize = true;
            this.lblNextAttackSec.Location = new System.Drawing.Point(545, 410);
            this.lblNextAttackSec.Name = "lblNextAttackSec";
            this.lblNextAttackSec.Size = new System.Drawing.Size(16, 13);
            this.lblNextAttackSec.TabIndex = 8;
            this.lblNextAttackSec.Text = "...";
            // 
            // tmrAttack
            // 
            this.tmrAttack.Interval = 1000;
            this.tmrAttack.Tick += new System.EventHandler(this.tmrAttack_Tick);
            // 
            // lblStorkKills
            // 
            this.lblStorkKills.AutoSize = true;
            this.lblStorkKills.Location = new System.Drawing.Point(713, 9);
            this.lblStorkKills.Name = "lblStorkKills";
            this.lblStorkKills.Size = new System.Drawing.Size(55, 13);
            this.lblStorkKills.TabIndex = 10;
            this.lblStorkKills.Text = "Stork kills:";
            // 
            // ltbKills
            // 
            this.ltbKills.FormattingEnabled = true;
            this.ltbKills.Location = new System.Drawing.Point(716, 26);
            this.ltbKills.Name = "ltbKills";
            this.ltbKills.Size = new System.Drawing.Size(215, 381);
            this.ltbKills.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.lblStorkKills);
            this.Controls.Add(this.ltbKills);
            this.Controls.Add(this.lblNextAttackSec);
            this.Controls.Add(this.lblNextAttack);
            this.Controls.Add(this.lblStork);
            this.Controls.Add(this.ltbStorks);
            this.Controls.Add(this.btnFrog);
            this.Controls.Add(this.lblFrog);
            this.Controls.Add(this.ltbFrog);
            this.Controls.Add(this.lblDuck);
            this.Controls.Add(this.ltbDucks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbDucks;
        private System.Windows.Forms.Label lblDuck;
        private System.Windows.Forms.Label lblFrog;
        private System.Windows.Forms.ListBox ltbFrog;
        private System.Windows.Forms.Button btnFrog;
        private System.Windows.Forms.ListBox ltbStorks;
        private System.Windows.Forms.Label lblNextAttack;
        private System.Windows.Forms.Label lblStork;
        private System.Windows.Forms.Label lblNextAttackSec;
        private System.Windows.Forms.Timer tmrAttack;
        private System.Windows.Forms.Label lblStorkKills;
        private System.Windows.Forms.ListBox ltbKills;
    }
}

