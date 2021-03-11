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
            af.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AlkashkaForm af = new AlkashkaForm("Снэки");
            af.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AllProducts af = new AllProducts();
            af.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
