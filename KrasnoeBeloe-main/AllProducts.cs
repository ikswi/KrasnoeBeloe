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
//У нас будут персонажи
        public struct Product
        {
            public PictureBox picture;
            public string name;
            public int price;
        }

    public partial class AllProducts : Form
    {
        
        Product[] products_list = new Product[6];
        public AllProducts()
        {
            InitializeComponent();
            
            products_list[0].picture = pictureBox2;
            products_list[0].name = "Хрустеам сметана";
            products_list[0].price = 60;

            products_list[1].picture = pictureBox3;
            products_list[1].name = "Хрустеам стейк";
            products_list[1].price = 60;

            products_list[2].picture = pictureBox3;
            products_list[2].name = "Хрустеам";
            products_list[2].price = 60;

            products_list[3].picture = pictureBox3;
            products_list[3].name = "Хрустеам холодец";
            products_list[3].price = 60;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
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
