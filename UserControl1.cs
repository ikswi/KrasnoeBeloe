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
    public partial class UserControl1 : UserControl
    {
        Product product;
        public UserControl1(Product product1)
        {
            product = product1;
            InitializeComponent();

            label1.Text = product.name;
            label2.Text = product.price.ToString() + " рублей";
            pictureBox1.Image = product.picture.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllProducts.bascet.Remove(product);
            this.Parent = null;

        }
    }
}
