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
using System.IO;

namespace AmalkaFlora
{
    public partial class SelectEmp : Form
    {
        public SelectEmp()
        {
            InitializeComponent();
        }

        private void SelectEmp_Load(object sender, EventArgs e)
        {
            //display the employee list
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Display the selected employee in a new form to edit or delete
            EditEmployee editEmp = new EditEmployee();
            editEmp.tbID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editEmp.tbname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editEmp.tbcontact.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editEmp.tbaddr.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            editEmp.tbemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            editEmp.comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            editEmp.tbsal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //The image
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream photo = new MemoryStream(pic);
            editEmp.pbpic.Image = Image.FromStream(photo);
            editEmp.Show();
            






            editEmp.tbnic.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
