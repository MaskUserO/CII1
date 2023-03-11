using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CII3.Views
{
    public partial class MainWindowViews : Form, IMainWindowViews 
    {
        private bool isEdit;

        public MainWindowViews()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
          
        }
        private void AssociateAndRaiseViewEvents()
        {
            // Search
            SearchBT.Click += delegate { SerchEvent?.Invoke(this, EventArgs.Empty); };
            Searchtext.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SerchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Other Event 
            button4.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };

            // Add 
            addbt.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add Client";

            };
            // Edit
            editbts.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Client";
            };
            // Delete
            deletebt.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected customer?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            // Save
            savebt.Click += delegate 
            { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);

                }
                MessageBox.Show(Message);
                
            };
        }
        // Properties
        public string ID 
        {
            get { return idtx.Text; }
            set { idtx.Text = value; }
        }
        public string fnaln
        {
            get { return nametx.Text; }
            set { nametx.Text = value; }
        }
        public string passaport
        {
            get { return passaporttx.Text; }
            set { passaporttx.Text = value; }
        }
        public string address
        {
            get { return addtx.Text; }
            set { addtx.Text = value; }
        }
        public string phone 
        {
            get { return phonetx.Text; }
            set { phonetx.Text = value; }
        }
        public string email 
        {
            get { return emtx.Text; }
            set { emtx.Text = value; }
        }
        public string jobtitle 
        {
            get { return jbtx.Text; }
            set { jbtx.Text = value; }
        }
        public string gender 
        {
            get { return gendertx.Text; }
            set { gendertx.Text = value; }
        }
        public string dateofbirth 
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string SerchValue
        { 
            get { return Searchtext.Text; }
            set { Searchtext.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public string emergency
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string insurancetype
        {
            get { return comboboxinsurance.Text; }
            set { comboboxinsurance.Text = value; }
        }
        public string paymentype
        {
            get { return comboBoxpayment.Text; }
            set { comboBoxpayment.Text = value; }
        }
        public string maximumcover

        {
            get { return textmx.Text; } 
            set { textmx.Text = value; }
        }
        public string servicefees
        {
            get { return textsf.Text; }
            set { textsf.Text = value; }
        }


        //Events
        public event EventHandler SerchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        //Methods
        public void SetCustomerListBindingSource(BindingSource customerList)
        {
           dataGridView1.DataSource = customerList;
        }


        private void ExitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Singleton patterrn (Open a single form instance)
        private static MainWindowViews instance;
        private bool isSuccessful;
        private string message;
        public static MainWindowViews GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainWindowViews();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle= FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
                
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        private void CloseBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainWindowViews_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cIIDataSet.CII' table. You can move, or remove it, as needed.

        }
    }
}
