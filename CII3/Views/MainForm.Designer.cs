namespace CII3.Views
{
    partial class MainForm
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
            this.CustomerBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exitbt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerBT
            // 
            this.CustomerBT.Location = new System.Drawing.Point(25, 89);
            this.CustomerBT.Name = "CustomerBT";
            this.CustomerBT.Size = new System.Drawing.Size(98, 23);
            this.CustomerBT.TabIndex = 0;
            this.CustomerBT.Text = "Customer DTB";
            this.CustomerBT.UseVisualStyleBackColor = true;
            this.CustomerBT.Click += new System.EventHandler(this.CustomerBT_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Exitbt);
            this.panel1.Controls.Add(this.CustomerBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 559);
            this.panel1.TabIndex = 2;
            // 
            // Exitbt
            // 
            this.Exitbt.Location = new System.Drawing.Point(25, 497);
            this.Exitbt.Name = "Exitbt";
            this.Exitbt.Size = new System.Drawing.Size(98, 23);
            this.Exitbt.TabIndex = 3;
            this.Exitbt.Text = "Exit";
            this.Exitbt.UseVisualStyleBackColor = true;
            this.Exitbt.Click += new System.EventHandler(this.Exitbt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 559);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CustomerBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exitbt;
    }
}