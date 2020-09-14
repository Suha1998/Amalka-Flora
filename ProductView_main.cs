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
    public partial class ProductView_main : Form
    {
        public ProductView_main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlowerBouquets flower = new FlowerBouquets();
            flower.Show(); //linking to next page
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //linking to the facebook website through the URL
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //linking to the instagram website through the URL
            System.Diagnostics.Process.Start("https://www.instagram.com/?hl=en");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //linking to the twitter website through the URL
            System.Diagnostics.Process.Start("https://twitter.com/login?lang=en");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //linking to the youtube website through the URL
            System.Diagnostics.Process.Start("https://www.youtube.com");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSystem Ms = new ManageSystem();
            Ms.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            carDeco_main car = new carDeco_main();
            car.Show();
        }
    }
}
