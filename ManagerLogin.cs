using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmalkaFlora
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //button for login
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ex2` WHERE `username`=@anju AND `pass`=@pass", db.getConnection);

            command.Parameters.Add("@anju", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You are Logged In.");

                this.Hide();
                ManageSystem ms = new ManageSystem();
                ms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Inavalid Username and a Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemOperation so = new systemOperation();
            so.ShowDialog();
        }
    }
    }

