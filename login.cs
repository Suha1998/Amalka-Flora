using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;


namespace AmalkaFlora
{
    public partial class login : Form
    {
        public login()
        {
            //Thread t = new Thread(new ThreadStart(interfaceStart));
            //t.Start();
           // Thread.Sleep(5000);

            InitializeComponent();

            //t.Abort();
        }

       // public void interfaceStart()
        //{
           // Application.Run(new Interface2());
        //}

        private void Interface1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ex1` WHERE `userName`=@anju AND `password`=@pass", db.getConnection);

            command.Parameters.Add("@anju", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("You are Logged In.");
            }
            else
            {
                MessageBox.Show("Inavalid Username and a Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to register to our system", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            customerRegister CR = new customerRegister();
            CR.ShowDialog();
        }

        private void btnSysOp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to access to the system. This will be a problem if you are not the manager or admin", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            systemOperation so = new systemOperation();
            so.ShowDialog();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
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
    }
}
