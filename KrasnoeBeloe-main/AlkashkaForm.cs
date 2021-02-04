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
            pictureBox1.Tag = "";
            pictureBox2.Tag = "";
            pictureBox3.Tag = "";
            pictureBox4.Tag = "";
            pictureBox5.Tag = "";

            label1.Text = "Бесценно";
            label2.Text = "Бесценно";
            label3.Text = "Бесценно";
            label4.Text = "Бесценно";
            label5.Text = "Бесценно";

            if (category == "Снэки")
            {
                pictureBox1.Load("../../Resources/арахис.jpg");
                pictureBox1.Tag = "60";
                pictureBox2.Load("../../Resources/сухари.jpg");
                pictureBox2.Tag = "60";
                pictureBox1.Load("../../Resources/сухари2.jpg");
                pictureBox2.Tag = "60";
            }
            if (category == "Напитки")
            {
                pictureBox1.Load("../../Resources/пиво.jpg");
                pictureBox1.Tag = "60";
                pictureBox2.Load("../../Resources/пиво1.jpg");
                pictureBox2.Tag = "50";
                pictureBox3.Load("../../Resources/пиво2.jpg");
                pictureBox3.Tag = "70";
                pictureBox4.Load("../../Resources/пиво3.jpg");
                pictureBox4.Tag = "50";
            }

            if (pictureBox1.Tag.ToString() != "")
                label1.Text = pictureBox1.Tag.ToString() + " рублей";
            if (pictureBox2.Tag.ToString() != "")
                label2.Text = pictureBox2.Tag.ToString() + " рублей";
            if (pictureBox3.Tag.ToString() != "")
                label3.Text = pictureBox3.Tag.ToString() + " рублей";
            if (pictureBox4.Tag.ToString() != "")
                label4.Text = pictureBox4.Tag.ToString() + " рублей";



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
            if (label4.Text == "Бесценно")
            {
                label4.Visible = false;
                pictureBox4.Visible = false;
            }
            if (label5.Text == "Бесценно")
            {
                label5.Visible = false;
                pictureBox5.Visible = false;
            }
            if (label6.Text == "Бесценно")
            {
                label6.Visible = false;
                pictureBox6.Visible = false;
            }
            if (label7.Text == "Бесценно")
            {
                label7.Visible = false;
                pictureBox7.Visible = false;
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
