
namespace MarimbaAndBass
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
            this.txbMarimba = new System.Windows.Forms.TextBox();
            this.lblMarimba = new System.Windows.Forms.Label();
            this.lblBass = new System.Windows.Forms.Label();
            this.txbBass = new System.Windows.Forms.TextBox();
            this.btnMarimba = new System.Windows.Forms.Button();
            this.btnBass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMarimba
            // 
            this.txbMarimba.Location = new System.Drawing.Point(16, 33);
            this.txbMarimba.Name = "txbMarimba";
            this.txbMarimba.Size = new System.Drawing.Size(100, 22);
            this.txbMarimba.TabIndex = 0;
            // 
            // lblMarimba
            // 
            this.lblMarimba.AutoSize = true;
            this.lblMarimba.Location = new System.Drawing.Point(13, 13);
            this.lblMarimba.Name = "lblMarimba";
            this.lblMarimba.Size = new System.Drawing.Size(66, 17);
            this.lblMarimba.TabIndex = 1;
            this.lblMarimba.Text = "Marimba:";
            // 
            // lblBass
            // 
            this.lblBass.AutoSize = true;
            this.lblBass.Location = new System.Drawing.Point(134, 13);
            this.lblBass.Name = "lblBass";
            this.lblBass.Size = new System.Drawing.Size(43, 17);
            this.lblBass.TabIndex = 3;
            this.lblBass.Text = "Bass:";
            // 
            // txbBass
            // 
            this.txbBass.Location = new System.Drawing.Point(137, 33);
            this.txbBass.Name = "txbBass";
            this.txbBass.Size = new System.Drawing.Size(100, 22);
            this.txbBass.TabIndex = 2;
            // 
            // btnMarimba
            // 
            this.btnMarimba.Location = new System.Drawing.Point(16, 62);
            this.btnMarimba.Name = "btnMarimba";
            this.btnMarimba.Size = new System.Drawing.Size(100, 23);
            this.btnMarimba.TabIndex = 4;
            this.btnMarimba.Text = "Play";
            this.btnMarimba.UseVisualStyleBackColor = true;
            this.btnMarimba.Click += new System.EventHandler(this.btnMarimba_Click);
            // 
            // btnBass
            // 
            this.btnBass.Location = new System.Drawing.Point(137, 61);
            this.btnBass.Name = "btnBass";
            this.btnBass.Size = new System.Drawing.Size(100, 23);
            this.btnBass.TabIndex = 5;
            this.btnBass.Text = "Play";
            this.btnBass.UseVisualStyleBackColor = true;
            this.btnBass.Click += new System.EventHandler(this.btnBass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBass);
            this.Controls.Add(this.btnMarimba);
            this.Controls.Add(this.lblBass);
            this.Controls.Add(this.txbBass);
            this.Controls.Add(this.lblMarimba);
            this.Controls.Add(this.txbMarimba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMarimba;
        private System.Windows.Forms.Label lblMarimba;
        private System.Windows.Forms.Label lblBass;
        private System.Windows.Forms.TextBox txbBass;
        private System.Windows.Forms.Button btnMarimba;
        private System.Windows.Forms.Button btnBass;
    }
}

