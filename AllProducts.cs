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
        /// <summary>
        /// Все т овары
        /// </summary>
        public static List<Product> products_list = new List<Product>();
        /// <summary>
        /// Корзина
        /// </summary>
        public static List<Product> bascet = new List<Product>();

        public static void FillProducts()
        {
            products_list.Add(new Product("сухари2", "Снэки", 30));
            products_list.Add(new Product("сухари6", "Снэки", 30));
            products_list.Add(new Product("сухари3", "Снэки", 30));
            products_list.Add(new Product("сухари4", "Снэки", 30));
            products_list.Add(new Product("пиво1", "Напитки", 60));
            products_list.Add(new Product("пиво2", "Напитки", 61));
            products_list.Add(new Product("пиво3", "Напитки", 62));
            products_list.Add(new Product("пиво4", "Напитки", 63));
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
            EngWords.Add("Поиск", "Search");
            EngWords.Add("Корзина", "Basket");
            EngWords.Add("Наименование", "Name");

            RusWords.Add("Поиск", "Поиск");
            RusWords.Add("Корзина", "Корзина");
            RusWords.Add("Наименование", "Наименование");
        }


        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();

        void translate(Dictionary<string, string> Words)
        {
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




        int x = 10;
            int y = 10;
            for (int i = 0; i < products_list.Count; i++)
            { 
                products_list[i].picture.Location = new Point(x, y);
                products_list[i].picture.Size = new Size(120, 120);
                products_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                toolTip1.SetToolTip(products_list[i].picture, "Кликни, чтобы добавить в корзину");
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
        /// <summary>
        /// Добавление в корзину
        /// </summary>
        public static void AddToCart(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            for (int i = 0; i < products_list.Count; i++)
            {
                //Ткнули на эту картинку
                if (pb.Image == products_list[i].picture.Image)
                {
                    //Добавить в корзину
                    bascet.Add(products_list[i]);
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
