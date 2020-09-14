using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AmalkaFlora
{
    public partial class systemOperation : Form
    {
       //thread for load the first interface of the application
        public systemOperation()
        {
            Thread t = new Thread(new ThreadStart(interfaceStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }
        public void interfaceStart()
        {
            Application.Run(new Interface2());
        }
        //button for the next window
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure, you are the manager??", "Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            ManagerLogin ml = new ManagerLogin();
            ml.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure, you are the admin??", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            AdminLogin al = new AdminLogin();
            al.ShowDialog();
        }
        //button for minimize
        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //button for close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void systemOperation_Load(object sender, EventArgs e)
        {

        }
    }
}
