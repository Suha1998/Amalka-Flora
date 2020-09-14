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
    public partial class InsertUpdateDeleteFlower : Form
    {
        public InsertUpdateDeleteFlower()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlowerItems afi = new AddFlowerItems();
            afi.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditFlowerProducts efp = new EditFlowerProducts();
            efp.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSystem ms = new ManageSystem();
            ms.ShowDialog();
        }

        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
