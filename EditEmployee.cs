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
    public partial class EditEmployee : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;



        public EditEmployee()
        {
            InitializeComponent();
        }


        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectEmp_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT  * FROM floral_shop_db.ex3 WHERE `id`= '" + tbID.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader mdr;



            try
            {
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    tbname.Text = mdr.GetString("name");
                    tbcontact.Text = mdr.GetString("tel");
                    tbaddr.Text = mdr.GetString("addr");
                    tbemail.Text = mdr.GetString("email");
                    comboBox1.Text = mdr.GetString("empType");
                    tbsal.Text = mdr.GetString("sal");
                   //pbpic.Image = mdr.GetValue("photo");
                    tbnic.Text = mdr.GetString("nic");
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

        private void btnupload_Click(object sender, EventArgs e)
        {
            //Select and display an image in the picture box
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbpic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update the selected employee
            EMPLOYEE emp = new EMPLOYEE();

            int id = Convert.ToInt32(tbID.Text);
            string name = tbname.Text;
            string tel = tbcontact.Text;
            string addr = tbaddr.Text;
            string email = tbemail.Text;
            string empType = comboBox1.Text;
            string sal = tbsal.Text;
            string nic = tbnic.Text;

            try
            {
                //Get Image
                MemoryStream photo = new MemoryStream();
                pbpic.Image.Save(photo, pbpic.Image.RawFormat);

                if (emp.editEmployee(id, name, tel, addr, email, empType, sal, photo, nic))
                {
                    MessageBox.Show("The employee details are updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete Employee
            int id = Convert.ToInt32(tbID.Text);
            EMPLOYEE emp = new EMPLOYEE();

            //Show a confirmation message before delete
            if(MessageBox.Show("Are you sure?","DELETE",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(emp.deleteEmployee(id))
                {
                    MessageBox.Show("Employee Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear fields
                    tbID.Text = "";
                    tbname.Text = "";
                    tbcontact.Text = "";
                    tbaddr.Text = "";
                    tbemail.Text = "";
                    comboBox1.Text = "";
                    tbsal.Text = "";
                    pbpic.Image = null;
                    tbnic.Text = "";
                }
                else
                {
                    MessageBox.Show("Employee is not Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           /* int id = Convert.ToInt32(tbID.Text);
            string name = tbname.Text;
            string tel = tbcontact.Text;
            string addr = tbaddr.Text;
            string email = tbemail.Text;
            string empType = comboBox1.Text;
            string sal = tbsal.Text;
            string nic = tbnic.Text;

            try
            {
                //Get Image
                MemoryStream photo = new MemoryStream();
                pbpic.Image.Save(photo, pbpic.Image.RawFormat);

                if (emp.deleteEmployee(id))
                {
                    MessageBox.Show("The employee details are deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Something went wrong", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        //Button for minimize
        private void btmMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Button for close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Button for previous page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmp me = new ManageEmp();
            me.ShowDialog();
        }
        //Validating the contact number
        private void tbcontact_TextChanged(object sender, EventArgs e)
        {
            string cont = "^([0-9]{10})$";
            if (Regex.IsMatch(tbcontact.Text, cont))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tbcontact, "Please enter a valid contact number");
                return;
            }
        }

        //validating the email
        private void tbemail_TextChanged(object sender, EventArgs e)
        {
            string mail = "^([0-9a-zA-Z]{1,20}([-\\.\\w]*@[0-9a-zA-Z])*@([0-9a-zA-Z][*\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(tbemail.Text, mail))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.tbemail, "Please enter a valid email address");
                return;
            }
        }

        //validating the salary
        private void tbsal_TextChanged(object sender, EventArgs e)
        {
            string salary = "^([0-9]{1,10})$";
            if (Regex.IsMatch(tbsal.Text, salary))
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.tbsal, "Please enter a valid salary amount");
                return;
            }
        }

        //validating the employee NIC
        private void tbnic_TextChanged(object sender, EventArgs e)
        {
            string empnic = "^([0-9]{9}[V])$";
            if (Regex.IsMatch(tbnic.Text, empnic))
            {
                errorProvider4.Clear();
            }
            else
            {
                errorProvider4.SetError(this.tbnic, "Please enter a valid NIC");
                return;
            }
        }
    }
}

