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
    public partial class OrderNow : Form
    {
        
        //connecting the database
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        
        public OrderNow()
        {
            InitializeComponent();
        }

        private void OrderNow_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == "")//validating the date field
            {

                MessageBox.Show("Date is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (listBox1.Text == "")//validating the branch field
            {

                MessageBox.Show("Branch is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox4.Text == "")//validating the time field
            {
                textBox4.BackColor = Color.LightPink;
                MessageBox.Show("Time is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Focus();
                return;
            }

            //inserting values to the database
            string insertQuery = "INSERT INTO floral_shop_db.ex6(name, branch, odate, otime, totalAmount) VALUES('" + textBox3.Text + "','" + listBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            connection.Open();
            //SELECT `id`, `name`, `branch`, `odate`, `otime`, `totalAmount` FROM `ex6` WHERE 1
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data not inserted ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")//validating the name textbox
            {
                textBox3.BackColor = Color.LightPink;
                MessageBox.Show("Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return;
            }

            connection.Open();

            string selectQuery = "SELECT * FROM floral_shop_db.ex1 WHERE name = '" + textBox3.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader MDR;


            try
            {
                MDR = command.ExecuteReader();
                if (MDR.Read())
                {
                    textBox2.Text = MDR.GetString("email");
                    textBox1.Text = MDR.GetString("addr");

                }
                else
                {
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                    MessageBox.Show("you are not logged in");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = Calculate_Price.PassingText1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == "")//validating the date field
            {

                MessageBox.Show("Date is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (listBox1.Text == "")//validating the branch field
            {

                MessageBox.Show("Branch is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox4.Text == "")//validating the time field
            {
                textBox4.BackColor = Color.LightPink;
                MessageBox.Show("Time is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Focus();
                return;
            }

            if (textBox3.Text == "")//validating the Name field
            {
                textBox3.BackColor = Color.LightPink;
                MessageBox.Show("Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return;
            }

            if (textBox2.Text == "")//validating the Email field
            {
                textBox2.BackColor = Color.LightPink;
                MessageBox.Show("Email is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }

            if (textBox1.Text == "")//validating the address field
            {
                textBox1.BackColor = Color.LightPink;
                MessageBox.Show("Time is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }

            if (textBox5.Text == "")//validating the Total price field
            {
                textBox5.BackColor = Color.LightPink;
                MessageBox.Show("Total amount is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox5.Focus();
                return;
            }

            this.Hide();
            SendingMails sm = new SendingMails();
            sm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //validate the email
            string pattern = "^([0-9a-zA-Z]{1,20}([-\\.\\w]*@[0-9a-zA-Z])*@([0-9a-zA-Z][*\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBox2.Text, pattern))
            {
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(this.textBox2, "Please enter a valid email");
                return;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculate_Price c = new Calculate_Price();
            c.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com");
        }
    }
}
