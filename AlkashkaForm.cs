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

            Text = category;

            int x = 10;
            int y = 10;
            for (int i = 0; i < AllProducts.products_list.Count; i++)
            {
                //Если категория неправильная, идем дальше
                if (category != AllProducts.products_list[i].category)
                    continue;

                //Формируем картинку с продуктом
                PictureBox picture = new PictureBox();
                picture.Image = AllProducts.products_list[i].picture.Image;                
                picture.Location = new Point(x, y);
                picture.Size = new Size(120, 120);
                picture.Tag = AllProducts.products_list[i].name;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += new EventHandler(AllProducts.AddToCart);
                panel1.Controls.Add(picture);

                //Формируем цену продукта (подпись)
                Label label = new Label();
                label.Location = new Point(x, y + 120);
                label.Size = new Size(120, 30);
                label.Tag = AllProducts.products_list[i].name;
                label.Text = AllProducts.products_list[i].price.ToString() + " руб.";
                panel1.Controls.Add(label);

                x = x + 160;
                if (x + 120 > Width)
                {
                    y = y + 180;
                    x = 10;
                }
            }
        }

        private void AlkashkaForm_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AllProducts.products_list.Count; i++)
            {
                //Если категория неправильная, идем дальше
                if (Text != AllProducts.products_list[i].category)
                    continue;

                AllProducts.products_list[i].picture.Visible = true;
                if (!AllProducts.products_list[i].name.Contains(nameTB.Text))
                    AllProducts.products_list[i].picture.Visible = false;

                if (priceTB.Text != "" &&
                    AllProducts.products_list[i].price > Convert.ToInt32(priceTB.Text))
                    AllProducts.products_list[i].picture.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Korzina af = new Korzina();
            af.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
