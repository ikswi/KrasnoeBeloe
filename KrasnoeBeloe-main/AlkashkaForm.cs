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
                label1.Text = "10 рублей";
            }
            if (category == "Напитки")
            {
                pictureBox1.Load("../../Resources/пиво.jpg");
                pictureBox2.Load("../../Resources/пиво1.jpg");
                pictureBox3.Load("../../Resources/пиво2.jpg");
                pictureBox4.Load("../../Resources/пиво3.jpg");
                label1.Text = "60 рублей";
                label2.Text = "74 рубля";
                label3.Text = "70 рублей";
                label4.Text = "70 рублей";
            }
        }

        private void AlkashkaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
