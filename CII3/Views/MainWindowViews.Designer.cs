namespace CII3.Views
{
    partial class MainWindowViews
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
            this.Searchtext = new System.Windows.Forms.TextBox();
            this.SearchBT = new System.Windows.Forms.Button();
            this.addbt = new System.Windows.Forms.Button();
            this.editbts = new System.Windows.Forms.Button();
            this.deletebt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disbut = new System.Windows.Forms.Button();
            this.CloseBT = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textsf = new System.Windows.Forms.TextBox();
            this.textmx = new System.Windows.Forms.TextBox();
            this.gendertx = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxpayment = new System.Windows.Forms.ComboBox();
            this.comboboxinsurance = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idtx = new System.Windows.Forms.TextBox();
            this.nametx = new System.Windows.Forms.TextBox();
            this.passaporttx = new System.Windows.Forms.TextBox();
            this.addtx = new System.Windows.Forms.TextBox();
            this.jbtx = new System.Windows.Forms.TextBox();
            this.emtx = new System.Windows.Forms.TextBox();
            this.phonetx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.savebt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIIBindingSource)).BeginInit();

            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchtext
            // 
            this.Searchtext.Location = new System.Drawing.Point(134, 40);
            this.Searchtext.Multiline = true;
            this.Searchtext.Name = "Searchtext";
            this.Searchtext.Size = new System.Drawing.Size(421, 29);
            this.Searchtext.TabIndex = 6;
            // 
            // SearchBT
            // 
            this.SearchBT.Location = new System.Drawing.Point(590, 40);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(105, 29);
            this.SearchBT.TabIndex = 12;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = true;
            // 
            // addbt
            // 
            this.addbt.Location = new System.Drawing.Point(772, 76);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(105, 29);
            this.addbt.TabIndex = 13;
            this.addbt.Text = "ADD";
            this.addbt.UseVisualStyleBackColor = true;
            // 
            // editbts
            // 
            this.editbts.Location = new System.Drawing.Point(772, 111);
            this.editbts.Name = "editbts";
            this.editbts.Size = new System.Drawing.Size(105, 29);
            this.editbts.TabIndex = 14;
            this.editbts.Text = "Edit";
            this.editbts.UseVisualStyleBackColor = true;
            // 
            // deletebt
            // 
            this.deletebt.Location = new System.Drawing.Point(772, 146);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(105, 29);
            this.deletebt.TabIndex = 15;
            this.deletebt.Text = "Delete";
            this.deletebt.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 566);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.disbut);
            this.tabPage1.Controls.Add(this.CloseBT);
            this.tabPage1.Controls.Add(this.SearchBT);
            this.tabPage1.Controls.Add(this.deletebt);
            this.tabPage1.Controls.Add(this.editbts);
            this.tabPage1.Controls.Add(this.addbt);
            this.tabPage1.Controls.Add(this.Searchtext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cIIBindingSource
            // 
            this.cIIBindingSource.DataMember = "CII";

            // 
            // cIIDataSet
            // 
            // disbut
            // 
            this.disbut.Location = new System.Drawing.Point(772, 181);
            this.disbut.Name = "disbut";
            this.disbut.Size = new System.Drawing.Size(105, 29);
            this.disbut.TabIndex = 17;
            this.disbut.Text = "Display";
            this.disbut.UseVisualStyleBackColor = true;
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(772, 500);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(105, 29);
            this.CloseBT.TabIndex = 16;
            this.CloseBT.Text = "Close";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textsf);
            this.tabPage2.Controls.Add(this.textmx);
            this.tabPage2.Controls.Add(this.gendertx);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.comboBoxpayment);
            this.tabPage2.Controls.Add(this.comboboxinsurance);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.idtx);
            this.tabPage2.Controls.Add(this.nametx);
            this.tabPage2.Controls.Add(this.passaporttx);
            this.tabPage2.Controls.Add(this.addtx);
            this.tabPage2.Controls.Add(this.jbtx);
            this.tabPage2.Controls.Add(this.emtx);
            this.tabPage2.Controls.Add(this.phonetx);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.savebt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(897, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textsf
            // 
            this.textsf.Location = new System.Drawing.Point(446, 245);
            this.textsf.Multiline = true;
            this.textsf.Name = "textsf";
            this.textsf.Size = new System.Drawing.Size(113, 26);
            this.textsf.TabIndex = 60;
            // 
            // textmx
            // 
            this.textmx.Location = new System.Drawing.Point(446, 187);
            this.textmx.Multiline = true;
            this.textmx.Name = "textmx";
            this.textmx.Size = new System.Drawing.Size(113, 26);
            this.textmx.TabIndex = 59;
            // 
            // gendertx
            // 
            this.gendertx.FormattingEnabled = true;
            this.gendertx.Items.AddRange(new object[] {
            "Male ",
            "Femele"});
            this.gendertx.Location = new System.Drawing.Point(264, 163);
            this.gendertx.Name = "gendertx";
            this.gendertx.Size = new System.Drawing.Size(113, 21);
            this.gendertx.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(443, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "* Service Fees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "* Maximum Cover";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "* Emergency Contact";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 282);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 26);
            this.textBox2.TabIndex = 46;
            // 
            // comboBoxpayment
            // 
            this.comboBoxpayment.FormattingEnabled = true;
            this.comboBoxpayment.Items.AddRange(new object[] {
            "Cash",
            "Direct Debit",
            "Money Transfer"});
            this.comboBoxpayment.Location = new System.Drawing.Point(446, 99);
            this.comboBoxpayment.Name = "comboBoxpayment";
            this.comboBoxpayment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxpayment.TabIndex = 45;
            // 
            // comboboxinsurance
            // 
            this.comboboxinsurance.FormattingEnabled = true;
            this.comboboxinsurance.Items.AddRange(new object[] {
            "Phone",
            "Car",
            "Computer"});
            this.comboboxinsurance.Location = new System.Drawing.Point(446, 41);
            this.comboboxinsurance.Name = "comboboxinsurance";
            this.comboboxinsurance.Size = new System.Drawing.Size(121, 21);
            this.comboboxinsurance.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "* Payment Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "* Insurance Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 26);
            this.textBox1.TabIndex = 41;
            // 
            // idtx
            // 
            this.idtx.Location = new System.Drawing.Point(54, 36);
            this.idtx.Multiline = true;
            this.idtx.Name = "idtx";
            this.idtx.Size = new System.Drawing.Size(113, 26);
            this.idtx.TabIndex = 37;
            // 
            // nametx
            // 
            this.nametx.Location = new System.Drawing.Point(54, 94);
            this.nametx.Multiline = true;
            this.nametx.Name = "nametx";
            this.nametx.Size = new System.Drawing.Size(113, 26);
            this.nametx.TabIndex = 36;
            // 
            // passaporttx
            // 
            this.passaporttx.Location = new System.Drawing.Point(54, 158);
            this.passaporttx.Multiline = true;
            this.passaporttx.Name = "passaporttx";
            this.passaporttx.Size = new System.Drawing.Size(113, 26);
            this.passaporttx.TabIndex = 35;
            // 
            // addtx
            // 
            this.addtx.Location = new System.Drawing.Point(55, 216);
            this.addtx.Multiline = true;
            this.addtx.Name = "addtx";
            this.addtx.Size = new System.Drawing.Size(113, 26);
            this.addtx.TabIndex = 34;
            // 
            // jbtx
            // 
            this.jbtx.Location = new System.Drawing.Point(264, 216);
            this.jbtx.Multiline = true;
            this.jbtx.Name = "jbtx";
            this.jbtx.Size = new System.Drawing.Size(113, 26);
            this.jbtx.TabIndex = 33;
            // 
            // emtx
            // 
            this.emtx.Location = new System.Drawing.Point(264, 94);
            this.emtx.Multiline = true;
            this.emtx.Name = "emtx";
            this.emtx.Size = new System.Drawing.Size(113, 36);
            this.emtx.TabIndex = 32;
            // 
            // phonetx
            // 
            this.phonetx.Location = new System.Drawing.Point(264, 36);
            this.phonetx.Multiline = true;
            this.phonetx.Name = "phonetx";
            this.phonetx.Size = new System.Drawing.Size(113, 26);
            this.phonetx.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "* Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "* Job Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "* Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "* Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "* Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "* Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "* Passaport Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "* Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "* ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 29);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // savebt
            // 
            this.savebt.Location = new System.Drawing.Point(332, 455);
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(105, 29);
            this.savebt.TabIndex = 17;
            this.savebt.Text = "Save";
            this.savebt.UseVisualStyleBackColor = true;
            // 
            // cIITableAdapter
            // 
          // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(737, 449);
            this.dataGridView1.TabIndex = 18;
            // 
            // MainWindowViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindowViews";
            this.Text = "MainWindowViews";
            this.Load += new System.EventHandler(this.MainWindowViews_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIIBindingSource)).EndInit();

            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Searchtext;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Button editbts;
        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button savebt;
        private System.Windows.Forms.TextBox idtx;
        private System.Windows.Forms.TextBox nametx;
        private System.Windows.Forms.TextBox passaporttx;
        private System.Windows.Forms.TextBox addtx;
        private System.Windows.Forms.TextBox jbtx;
        private System.Windows.Forms.TextBox emtx;
        private System.Windows.Forms.TextBox phonetx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button disbut;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxpayment;
        private System.Windows.Forms.ComboBox comboboxinsurance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gendertx;
        private System.Windows.Forms.TextBox textsf;
        private System.Windows.Forms.TextBox textmx;
        private System.Windows.Forms.BindingSource cIIBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}