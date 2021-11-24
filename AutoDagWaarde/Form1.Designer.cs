
namespace AutoDagWaarde
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
            this.ltbCars = new System.Windows.Forms.ListBox();
            this.tmrChange = new System.Windows.Forms.Timer(this.components);
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbCars
            // 
            this.ltbCars.FormattingEnabled = true;
            this.ltbCars.ItemHeight = 16;
            this.ltbCars.Location = new System.Drawing.Point(12, 12);
            this.ltbCars.Name = "ltbCars";
            this.ltbCars.Size = new System.Drawing.Size(776, 404);
            this.ltbCars.TabIndex = 0;
            // 
            // tmrChange
            // 
            this.tmrChange.Interval = 1000;
            this.tmrChange.Tick += new System.EventHandler(this.tmrChange_Tick);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(13, 421);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(118, 17);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "Volgende Telling:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(137, 421);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(20, 17);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.ltbCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbCars;
        private System.Windows.Forms.Timer tmrChange;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblChange;
    }
}

