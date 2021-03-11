using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qqqq
{
    public partial class AlkashkaForm : Form
    {
        public AlkashkaForm(string category)
        {
            InitializeComponent();


            int x = 10;
            int y = 10;

            foreach(Product product in AllProducts.products_list)
            {
                if (product.category == category)
                {
                    PictureBox pb = new PictureBox();

                    try
                    {
                        pb.Load("../../Resources/" + product.name + ".jpg");
                    }
                    catch (Exception) { }

                    pb.Location = new Point(x, y);
                    pb.Size = new Size(120, 120);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Tag = product.price;
                    pb.Click += new EventHandler(pictureBox1_Click);
                    Controls.Add(pb);

                    x = x + 160;
                    if (x + 120 > Width)
                    {
                        y = y + 180;
                        x = 10;
                    }
                }
            }
        }

        private void AlkashkaForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MessageBox.Show("С Вас " + pb.Tag.ToString() + " рублей");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
