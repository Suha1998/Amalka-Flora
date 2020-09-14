using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace AmalkaFlora
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }


        //Button for add new employee
        private void btnadd_Click(object sender, EventArgs e)
        {
            EMPLOYEE emp = new EMPLOYEE();

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
                pbpic.Image.Save(photo,pbpic.Image.RawFormat);

                if(emp.insertEmployee(name,  tel,  addr,  email, empType,  sal,  photo,  nic))
                {
                    MessageBox.Show("New Employee is added", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Something went wrong", "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button for browse an image
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

        private void AddEmployee_Load(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmp me = new ManageEmp();
            me.ShowDialog();
        }

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

        private void tbemail_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]{1,20}([-\\.\\w]*@[0-9a-zA-Z])*@([0-9a-zA-Z][*\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(tbemail.Text, pattern))
            {
                errorProvider2.Clear();

            }
            else
            {
                errorProvider2.SetError(this.tbemail, "Please enter a valid email");
                return;
            }
        }

        private void tbnic_TextChanged(object sender, EventArgs e)
        {
            string empnic = "^([0-9]{9})*[V]$";
            if(Regex.IsMatch(tbnic.Text,empnic))
            {
                errorProvider3.Clear();
            }
            else
            {
                errorProvider3.SetError(this.tbnic, "Please enter a valid NIC");
                return;
            }
        }
    }
}
