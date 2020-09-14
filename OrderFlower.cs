using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace AmalkaFlora
{
    public partial class OrderFlower : Form
    {
        //Get the sql connection
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        public OrderFlower()
        {
            InitializeComponent();
        }

        private void OrderFlower_Load(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //auto generate the details of the supplier by entering the supplier name
        private void btnload_Click(object sender, EventArgs e)
        {
            connection.Open();
            
            string selectQuery = "SELECT  * FROM floral_shop_db.ex4 WHERE `companyName`= '" + cbname.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader mdr;

            

            try
            {
                mdr = command.ExecuteReader();
                if(mdr.Read())
                {
                    tbemail.Text = mdr.GetString("email");
                    tbcontact.Text = mdr.GetString("tele");
                }
                else
                {
                    MessageBox.Show("No Data");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            
            
        }
        //button to make a order
        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            ORDER flowers = new ORDER();

            string name = cbname.Text;
            string email = tbemail.Text;
            string tele = tbcontact.Text;
            string flowerName = cbFlower.Text;
            int quantity = Convert.ToInt32(tbquantity.Text);
            DateTime odate = dtpDate.Value;
            string time = cbTime.Text;
            string branch = cbBranch.Text;

              if (flowers.insertOrder(name, email, tele, flowerName, quantity, odate, time, branch))
               {
                   MessageBox.Show("Order Added Successfully", "OrderNow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.Hide();
                   MaterialEmail mat = new MaterialEmail();
                   mat.ShowDialog();
               }
               else
               {
                   MessageBox.Show("Something Went Wrong", "OrderNow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               


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
        //button for previous window
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSystem ms = new ManageSystem();
            ms.ShowDialog();
        }
        //validating the email
        private void tbemail_TextChanged(object sender, EventArgs e)
        {
            string mail = "^([0-9a-zA-Z]{1,20}([-\\.\\w]*@[0-9a-zA-Z])*@([0-9a-zA-Z][*\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(tbemail.Text, mail))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tbemail, "Please enter a valid email address");
                return;
            }
        }
        //validating the contact number
        private void tbcontact_TextChanged(object sender, EventArgs e)
        {
            string contact = "^([0-9]{10})$";
            if (Regex.IsMatch(tbcontact.Text, contact))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.tbcontact, "Please enter a valid contact number");
                return;
            }
        }
        //validating the quantity
        private void tbquantity_TextChanged(object sender, EventArgs e)
        {
            string quan = "^([0-9]){3}$";
            if (Regex.IsMatch(tbquantity.Text, quan))
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.tbquantity, "Please enter a valid quantity");
                return;
            }
        }
    }
}
