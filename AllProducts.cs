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
    public struct Product
    {
        public PictureBox picture;
        
        public string name;
        public string category;
        public int price;
    }

    public partial class AllProducts : Form
    {

        Product[] products_list = new Product[600];
        public AllProducts()
        {
            InitializeComponent();

            //products_list[0].picture = pictureBox2;
            products_list[0].name = "сухари2";
            products_list[0].category = "Снэки";
            products_list[0].price = 30;

            //products_list[1].picture = pictureBox3;
            products_list[1].name = "сухари6";
            products_list[1].category = "Снэки";
            products_list[1].price = 30;

            //products_list[2].picture = pictureBox3;
            products_list[2].name = "Хрустеам";
            products_list[2].price = 30;

            //products_list[3].picture = pictureBox3;
            products_list[3].name = "сухари3";
            products_list[3].price = 50;

            products_list[4].name = "пиво1";
            products_list[4].category = "Напитки";
            products_list[4].price = 60;

            products_list[5].name = "пиво2";
            products_list[5].category = "Напитки";
            products_list[5].price = 61;

            products_list[6].name = "пиво3";
            products_list[6].category = "Напитки";
            products_list[6].price = 62;

            products_list[7].name = "пиво4";
            products_list[7].category = "Напитки";
            products_list[7].price = 63;

            int x = 10;
            int y = 100;
            for (int i = 0; i < 8; i++)
            {
                PictureBox pb = new PictureBox();

                try
                {
                    pb.Load("../../Resources/" + products_list[i].name + ".jpg");
                }
                catch (Exception) { }

                pb.Location = new Point(x, y);
                pb.Size = new Size(120, 120);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                products_list[i].picture = pb;

                x = x + 160;
                if (x + 120 > Width)
                {
                    y = y + 180;
                    x = 10;
                }
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                products_list[i].picture.Visible = true;
                if (!products_list[i].name.Contains(nameTB.Text))
                    products_list[i].picture.Visible = false;

                if (priceTB.Text != "" &&
                    products_list[i].price > Convert.ToInt32(priceTB.Text))
                    products_list[i].picture.Visible = false;
            }
        }

    }
}
