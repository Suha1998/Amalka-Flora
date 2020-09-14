using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmalkaFlora
{
    public partial class ManageEmp : Form
    {
        public ManageEmp()
        {
            InitializeComponent();
        }

        private void btnaddEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee ae = new AddEmployee();
            ae.ShowDialog();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditEmployee ee = new EditEmployee();
            ee.ShowDialog();
        }

        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSystem ms = new ManageSystem();
            ms.ShowDialog();
        }
    }
}
