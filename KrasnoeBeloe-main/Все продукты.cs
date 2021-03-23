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
        public Label label;
        
        public string name;
        public string category;
        public int price;

        public Product(string _name, string _category, int _price)
        {
            name = _name;
            category = _category;
            price = _price;
            picture = new PictureBox();
            label = new Label();
        }
    }

    public partial class AllProducts : Form
    {
        /// <summary>
        /// Заполнить все продукты
        /// </summary>
        public static void FillProducts()
        {
            products_list.Add(new Product("сухари2", "Снэки", 30));
            products_list.Add(new Product("сухари6", "Снэки", 30));
            products_list.Add(new Product("сухари5", "Снэки", 30));
            products_list.Add(new Product("сухари3", "Снэки", 30));
            products_list.Add(new Product("сухари4", "Снэки", 30));
            products_list.Add(new Product("сухари7", "Снэки", 63));
            products_list.Add(new Product("сухари8", "Снэки", 63));
            products_list.Add(new Product("сухари9", "Снэки", 63));
            products_list.Add(new Product("сухари10", "Снэки", 63));
            products_list.Add(new Product("пиво1", "Напитки", 60));
            products_list.Add(new Product("пиво2", "Напитки", 61));
            products_list.Add(new Product("пиво3", "Напитки", 62));
            products_list.Add(new Product("пиво4", "Напитки", 63));
            products_list.Add(new Product("пиво6", "Напитки", 63));

            for (int i = 0; i < products_list.Count; i++)
            {
                try
                {
                    products_list[i].picture.Load("../../Resources/" + products_list[i].name + ".jpg");
                }
                catch (Exception) { }
            }
        }

        public static List<Product> products_list = new List<Product>();
        public static List<Product> bascet = new List<Product>();
        public AllProducts()
        {
            InitializeComponent();

            int x = 10;
            int y = 10;
            for (int i = 0; i < products_list.Count; i++)
            {
                products_list[i].picture.Location = new Point(x, y);
                products_list[i].picture.Size = new Size(120, 120);
                products_list[i].picture.Tag = products_list[i].name;
                products_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                products_list[i].picture.Click += new EventHandler(addToCart);
                panel1.Controls.Add(products_list[i].picture);

                products_list[i].label.Location = new Point(x, y + 120);
                products_list[i].label.Size = new Size(120, 30);
                products_list[i].label.Tag = products_list[i].name;
                products_list[i].label.Text = products_list[i].price.ToString() + " руб.";
                panel1.Controls.Add(products_list[i].label);

                x = x + 160;
                if (x + 120 > Width)
                {
                    y = y + 180;
                    x = 10;
                }
            }
        }
        private void addToCart(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string name = pb.Tag.ToString();

            foreach (Product prod in products_list)
            {
                if (prod.name == name)
                {
                    bascet.Add(prod);
                }
            }
        }

        private void OpenKorzina(object sender, EventArgs e)
        {
            Korzina af = new Korzina();
            af.Show();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < products_list.Count; i++)
            {
                products_list[i].picture.Visible = true;

                if (!products_list[i].name.Contains(nameTB.Text))
                    products_list[i].picture.Visible = false;

                if (priceTB.Text != "" &&
                    products_list[i].price > Convert.ToInt32(priceTB.Text))
                    products_list[i].picture.Visible = false;

                products_list[i].label.Visible = products_list[i].picture.Visible;

                if (products_list[i].picture.Visible)
                {
                    products_list[i].picture.Location = new Point(x, y);
                    products_list[i].label.Location = new Point(x, y + 120);
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
}
