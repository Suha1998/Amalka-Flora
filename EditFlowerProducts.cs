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
using System.Data;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;


namespace AmalkaFlora
{
    public partial class EditFlowerProducts : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public EditFlowerProducts()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Select and display an image in the picture box
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
               pbFlower.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update the selected product
            FLOWERPRO product = new FLOWERPRO();

            int id = Convert.ToInt32(tbID.Text);
            string category = cbCat.Text;
            string productName = tbName.Text;
            string proPrice = tbPrice.Text;
            string description = tbDes.Text;
           

            try
            {
                //Get Image
                MemoryStream image = new MemoryStream();
                pbFlower.Image.Save(image, pbFlower.Image.RawFormat);

                if (product.editFlowerProducts(id, category, productName, proPrice, description, image))
                {
                    MessageBox.Show("The flower product details are updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            //Delete a product
            int productID = Convert.ToInt32(tbID.Text);
            FLOWERPRO product = new FLOWERPRO();

            //Show a confirmation message before delete
            if (MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (product.deleteProducts(productID))
                {
                    MessageBox.Show("FlowerProducts Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear fields
                    tbID.Text = "";
                    cbCat.Text = "";
                    tbName.Text = "";
                    tbDes.Text = "";
                    tbPrice.Text = "";
                    pbFlower.Image = null;
                }
                else
                {
                    MessageBox.Show("FlowerProduct is not Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //select a product using product ID
        private void btnSelectPro_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT  * FROM floral_shop_db.ex5 WHERE `productID`= '" + tbID.Text + "' ";

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader mdr;



            try
            {
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    //id, category, productName, proPrice, description, image
                    //  int quantity = Convert.ToInt32(tbquantity.Text);
                    cbCat.Text = mdr.GetString("category");
                    tbName.Text = mdr.GetString("productName");
                    tbPrice.Text = mdr.GetString("proPrice");
                    tbDes.Text = mdr.GetString("description");
                    //pbFlower.
                    
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

        private void EditFlowerProducts_Load(object sender, EventArgs e)
        {

        }
        //button for previous page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertUpdateDeleteFlower iud = new InsertUpdateDeleteFlower();
            iud.ShowDialog();
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
        //validating the price
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            string prc = "^([0-9]{2,10})$";
            if (Regex.IsMatch(tbPrice.Text, prc))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tbPrice, "Please enter a valid price");
                return;
            }
        }
    }
}
