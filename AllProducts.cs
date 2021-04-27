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

namespace qqqq
{
    /// <summary>
    /// Продукт
    /// </summary>
    public struct Product
    {
        public PictureBox picture;
        public Label label;

        public string name;
        public string category;
        public int price;
        //List<string> options;

        public Product(string _name, string _category, int _price)
        {
            name = _name;
            category = _category;
            price = _price;
            picture = new PictureBox();
            label = new Label();
            label.Text = price + " руб";
            //combo = new ComboBox();
            //combo.DataSourse = ops;            
        }

    }

    public partial class AllProducts : Form
    {
        public static List<Product> products_list = new List<Product>();
        public static Dictionary<Product, int> bascet = new Dictionary<Product, int>();

        public static void FillProducts()
        {
            string[] products = File.ReadAllLines("../../Продукты.txt");

            foreach (string product in products)
            {
                string[] parts = product.Split(new String[] { ", " }, StringSplitOptions.None);
                List<string> options = new List<string>();
                if (parts.Length > 3)
                    options = parts[3].Split(new char[] { ';' }).ToList();
                products_list.Add(new Product(parts[0], parts[1], Convert.ToInt32(parts[2])));
            }

            for (int i = 0; i < products_list.Count; i++)
            {
                try
                {
                    products_list[i].picture.Load("../../Resources/" + products_list[i].name + ".jpg");
                }
                catch (Exception) { }
                products_list[i].picture.Click += new EventHandler(AddToCart);
            }
        }

        public static void FillTranslations()
        {
            EngWords.Add("Продукты", "Products");
            EngWords.Add("Поиск", "Search");
            EngWords.Add("Корзина", "Basket");
            EngWords.Add("Наименование", "Name");

            RusWords.Add("Продукты", "Продукты");
            RusWords.Add("Поиск", "Поиск");
            RusWords.Add("Корзина", "Корзина");
            RusWords.Add("Наименование", "Наименование");
        }


        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();

        void translate(Dictionary<string, string> Words)
        {
            Text = Words["Продукты"];
            button1.Text = Words["Поиск"];
            button2.Text = Words["Корзина"];
            label6.Text = Words["Наименование"];
        }
        void button3_Click(object sender, EventArgs e)
        {
            translate(EngWords);
        }

        void button4_Click(object sender, EventArgs e)
        {
            translate(RusWords);
        }


        public AllProducts()
        {

            InitializeComponent();


            Text = "Все продукты";


            int x = 10;
            int y = 10;
            for (int i = 0; i < products_list.Count; i++)
            { 
                products_list[i].picture.Location = new Point(x, y);
                products_list[i].picture.Size = new Size(120, 120);
                products_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                toolTip1.SetToolTip(products_list[i].picture, "Кликни, чтобы добавить в корзину");
                panel1.Controls.Add(products_list[i].picture);

                products_list[i].label.Location = new Point(x, y + 120);
                products_list[i].label.Size = new Size(100, 20);
                panel1.Controls.Add(products_list[i].label);
                x = x + 160;
                if (x + 120 > Width)
                {
                    y = y + 180;
                    x = 10;
                }
            }
        }
        /// <summary>
        /// Добавление в корзину
        /// </summary>
        public static void AddToCart(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            foreach (Product prod in products_list)
            {
                //Ткнули на эту картинку
                if (pb.Image == prod.picture.Image)
                {
                    //Добавить в корзину
                    if (!bascet.ContainsKey(prod))
                    {
                        bascet.Add(prod, 1);
                    }
                    else
                        bascet[prod] = bascet[prod] + 1;

                    MessageBox.Show("Добавлено в корзину");
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


                products_list[i].label.Visible = products_list[i].picture.Visible;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Korzina af = new Korzina();
            af.Show();
        }
    }
}
