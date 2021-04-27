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

            Text = "Добавление нового продукта";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (price.Value <= 0)
            {
                MessageBox.Show("Укажите цену");
                return;
            }

            File.AppendAllText("../../Продукты.txt", Environment.NewLine + 
                textBox1.Text + ", " + comboBox1.Text + ", " + price.Value.ToString());
            MessageBox.Show("Добавлено");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //TODO добавление картинки
        }
    }
}
