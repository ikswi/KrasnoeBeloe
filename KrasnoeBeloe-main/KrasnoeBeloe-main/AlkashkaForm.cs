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

            if (category == "Снэки")
            {
                pictureBox1.Load("../../Resources/арахис.jpg");
                pictureBox1.Tag = "10";
                label1.Text = "10 рублей";
            }
            if (category == "Напитки")
            {
                pictureBox1.Load("../../Resources/пиво.jpg");
                pictureBox1.Tag = "60";
                label1.Text = "60 рублей";
                pictureBox2.Load("../../Resources/пиво1.jpg");
                pictureBox2.Tag = "50";
                label2.Text = "75 рубля";
                pictureBox3.Load("../../Resources/пиво2.jpg");
                pictureBox3.Tag = "70";
                label3.Text = "70 рублей";
                pictureBox4.Load("../../Resources/пиво3.jpg");
                pictureBox4.Tag = "70";
                label4.Text = "70 рублей";
            }



            //Скрываем ненужные картинки
            if (label2.Text == "Бесценно")
            {
                label2.Visible = false;
                pictureBox2.Visible = false;
            }
            if (label3.Text == "Бесценно")
            {
                label3.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void AlkashkaForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MessageBox.Show("С Вас " + pb.Tag.ToString() + " рублей");
        }
    }
}
