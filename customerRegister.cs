using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace AmalkaFlora
{
    public partial class customerRegister : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public customerRegister()
        {
            InitializeComponent();
        }

        private void customerRegister_Load(object sender, EventArgs e)
        {

        }

        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblCPaswword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContact_TextChanged(object sender, EventArgs e)
        {
            string cont = "^([0-9]{10})$";
            if(Regex.IsMatch(tbContact.Text,cont))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.tbContact,"Please enter a valid contact number");
                return;
            }

        }

        private void gbGender_Enter(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]{1,20}([-\\.\\w]*@[0-9a-zA-Z])*@([0-9a-zA-Z][*\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(tbEmail.Text,pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.tbEmail,"Plzz enter a valid email");
                return;
            }

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            string ps = "^([0-9a-z]{10})$";
            if (Regex.IsMatch(tbPassword.Text, ps))
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.tbPassword, "Plzz enter a valid password");
                return;
            }

        }

        private void tbCPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbPassword.Text == tbCPassword.Text)
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(this.tbCPassword, "This is not match with your password");
                return;
            }
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Select and display an image in the picture box
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbProfile.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string addr = tbAddr.Text;
            string contact = tbContact.Text;
            string gender = gbGender.Text;
            string email = tbEmail.Text;
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            string cPassword = tbCPassword.Text;

            CUSTOMER customer = new CUSTOMER();

            if (verifFields("register"))
            {
                MemoryStream picture = new MemoryStream();
                pbProfile.Image.Save(picture, pbProfile.Image.RawFormat);

                //We need to check the username already exists
                //We need to insert the new customer into the database
                //We will create that in the class CUSTOMER
                if (!customer.usernameExists(userName)) //check the username already exists
                {
                    if (customer.insertCustomer(name, addr, contact, gender, email, userName, password, cPassword, picture))
                    {
                        MessageBox.Show("Registration Completed Successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ProductView_main pv = new ProductView_main();
                        pv.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This username already exists. Try again.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Required Fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        //Create a function to check empty fields

        public bool verifFields(string operation)
        {
            bool check = false;

            //If the operation is register
            if (operation == "register")
            {
                if (tbName.Text.Equals("") || tbAddr.Text.Equals("") || tbContact.Text.Equals("") || tbEmail.Text.Equals("") || tbUserName.Text.Equals("") || tbPassword.Text.Equals("") || tbCPassword.Text.Equals("") || pbProfile.Image == null)
                {
                    check = false;
                }

                else
                {
                    check = true;
                }
            }
            //if the operation is login
            else if (operation == "login")
            {
                if (tbUserName.Text.Equals("") || tbContact.Text.Equals(""))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSystem ms = new ManageSystem();
            ms.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update the selected customer
            CUSTOMER cust = new CUSTOMER();

            int id = Convert.ToInt32(tbCustID.Text);
            string name = tbName.Text;
            string addr = tbAddr.Text;
            string gender = gbGender.Text;
            string email = tbEmail.Text;
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            string cPassword = tbCPassword.Text;

            


            try
            {
                //Get Image
                MemoryStream picture = new MemoryStream();
                pbProfile.Image.Save(picture, pbProfile.Image.RawFormat);

                if (cust.editCustomer(id, name, addr, addr, gender, email, userName, password, cPassword,picture))
                {
                    MessageBox.Show("The Customer details are updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Something went wrong", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT  * FROM floral_shop_db.ex1 WHERE `id`= '" + tbCustID.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader mdr;



            try
            {
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    tbName.Text = mdr.GetString("name");
                    tbAddr.Text = mdr.GetString("addr");
                    tbContact.Text = mdr.GetString("contact");
                    gbGender.Text = mdr.GetString("gender");
                    tbEmail.Text = mdr.GetString("email");
                    tbUserName.Text = mdr.GetString("userName");
                    tbPassword.Text = mdr.GetString("password");
                    tbCPassword.Text = mdr.GetString("cPassword");
                    //pbpic.Image = mdr.GetValue("photo");
                  

                    //SELECT `id`, `name`, `addr`, `contact`, `gender`, `email`, `userName`, `password`, `cPassword`, `picture` FROM `ex1` WHERE 1

                }
                else

                {
                    MessageBox.Show("No Data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //Delete Customer
            int id = Convert.ToInt32(tbCustID.Text);
            CUSTOMER cust = new CUSTOMER();

            //Show a confirmation message before delete
            if (MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cust.deleteCustomer(id))
                {
                    MessageBox.Show("Employee Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear fields
                    tbName.Text = "";
                    tbAddr.Text = "";
                    tbContact.Text = "";
                    gbGender.Text = "";
                    tbEmail.Text = "";
                    tbUserName.Text = "";
                    tbPassword.Text = "";
                    tbCPassword.Text = "";
                    pbProfile.Image = null;
                    
                }
                else
                {
                    MessageBox.Show("Customer is not deleted is not Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
