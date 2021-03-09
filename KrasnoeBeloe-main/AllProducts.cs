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

        public Product(string _name, string _category, int _price)
        {
            name = _name;
            category = _category;
            price = _price;
            picture = new PictureBox();
        }
    }

    public partial class AllProducts : Form
    {

        List<Product> products_list = new List<Product>();
        public AllProducts()
        {
            InitializeComponent();

            products_list.Add(new Product("сухари2", "Снэки", 30));
            products_list.Add(new Product("сухари6","Снэки", 30));
            products_list.Add(new Product("Хрустеам","Снэки", 30));
            products_list.Add(new Product("сухари3", "Снэки", 30));
            products_list.Add(new Product("сухари4", "Снэки", 30));
            products_list.Add(new Product("пиво1", "Напитки", 60));
            products_list.Add(new Product("пиво2", "Напитки", 61));
            products_list.Add(new Product("пиво3", "Напитки", 62));
            products_list.Add(new Product("пиво4", "Напитки", 63));

            int x = 10;
            int y = 10;
            for (int i = 0; i < products_list.Count; i++)
            {
                //PictureBox pb = new PictureBox();

                try
                {
                    products_list[i].picture.Load("../../Resources/" + products_list[i].name + ".jpg");
                }
                catch (Exception) { }

                products_list[i].picture.Location = new Point(x, y);
                products_list[i].picture.Size = new Size(120, 120);
                products_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(products_list[i].picture);
                //products_list[i].picture = pb;

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
            for (int i = 0; i < products_list.Count; i++)
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
