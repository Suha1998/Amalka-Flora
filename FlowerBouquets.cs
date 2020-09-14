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
    public partial class FlowerBouquets : Form
    {
        
        public FlowerBouquets()
        {
            InitializeComponent();
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //linking to the facebook website through the URL
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //linking to the instagram website through the URL
            System.Diagnostics.Process.Start("https://www.instagram.com/?hl=en");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //linking to the twitter website through the URL
            System.Diagnostics.Process.Start("https://twitter.com/login?lang=en");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //linking to the youtube website through the URL
            System.Diagnostics.Process.Start("https://www.youtube.com");
        }


       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculate_Price F1 = new Calculate_Price();
            F1.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
