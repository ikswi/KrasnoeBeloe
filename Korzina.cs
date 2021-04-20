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

            int y = 10;
            int summa = 0;

            //Бегаешь по всем продуктам из корзины
            foreach(Product product in AllProducts.bascet)
            {
                UserControl1 pb = new UserControl1(product);
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
