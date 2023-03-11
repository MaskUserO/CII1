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
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            CustomerBT.Click += delegate { ShowMainWindowViews?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowMainWindowViews;
        public event EventHandler ShowInsurance;
        public event EventHandler ShowPolicies;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Exitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerBT_Click(object sender, EventArgs e)
        {

        }
    }
}
