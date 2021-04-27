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

            Text = "Корзина";
        }

        private void Korzina_Load(object sender, EventArgs e)
        {

            int y = 10;
            int summa = 0;

            //Бегаешь по всем продуктам из корзины
            foreach(KeyValuePair<Product, int> prod in AllProducts.bascet)
            {
                Product product = prod.Key;
                int count = prod.Value;

                UserControl1 pb = new UserControl1(product, count);
                pb.Location = new Point(10, y);
                summa = summa + product.price;
                Controls.Add(pb);
                    y = y + 90;
            }

            label1.Text = summa.ToString() +" рублей";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
