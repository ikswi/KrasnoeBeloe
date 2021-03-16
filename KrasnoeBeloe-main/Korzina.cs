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
    public partial class Korzina : Form
    {
        public Korzina()
        {
            InitializeComponent();
        }

        private void Korzina_Load(object sender, EventArgs e)
        {

            int x = 10;
            int y = 10;
            foreach(Product product in AllProducts.bascet)
            {
                PictureBox pb = new PictureBox();

                try
                {
                    pb.Load("../../Resources/" + product.name + ".jpg");
                }
                catch (Exception) { }

                pb.Location = new Point(x, y);
                pb.Size = new Size(120, 120);
                pb.Tag = product.name;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                //products_list[i].picture.Click += new EventHandler(addToCart);
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
}
