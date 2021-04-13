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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("../../Продукты.txt", Environment.NewLine + 
                textBox1.Text + ", " + comboBox1.Text + ", " + textBox2.Text);
            MessageBox.Show("1");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //TODO добавление картинки
        }
    }
}
