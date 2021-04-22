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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AlkashkaClick(object sender, EventArgs e)
        {
            AlkashkaForm af = new AlkashkaForm("Напитки");
            af.Show();
        }

        private void SnacksClick(object sender, EventArgs e)
        {
            AlkashkaForm af = new AlkashkaForm("Снэки");
            af.Show();
        }


        private void AllProductsClick(object sender, EventArgs e)
        {
            AllProducts af = new AllProducts();
            af.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                Korzina af = new Korzina();
                af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                AddProduct af = new AddProduct();
                af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                AuthForm af = new AuthForm();
                af.ShowDialog();
            label1.Text = AuthForm.Login;
            if (AuthForm.Login == "")
                label1.Visible = false;
        }
    }
}
