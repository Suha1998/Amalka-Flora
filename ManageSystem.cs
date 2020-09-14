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
    public partial class ManageSystem : Form
    {
        public ManageSystem()
        {
            InitializeComponent();
        }

        private void ManageSystem_Load(object sender, EventArgs e)
        {

        }
        //button for next window
        private void btnCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerRegister cr = new customerRegister();
            cr.ShowDialog();
        }
        //button for next window
        private void btnEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmp me = new ManageEmp();
            me.ShowDialog();
        }
        //button for next window
        private void btnPro_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertUpdateDeleteFlower iud = new InsertUpdateDeleteFlower();
            iud.ShowDialog();
        }
        //button for next window
        private void btnOrderFlowers_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderFlower of = new OrderFlower();
            of.ShowDialog();
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
        //button for next window
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin ml = new ManagerLogin();
            ml.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductView_main pvm = new ProductView_main();
            pvm.ShowDialog();
        }
    }
}
