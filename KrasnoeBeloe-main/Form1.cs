﻿using System;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AlkashkaForm af = new AlkashkaForm("Снэки");
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
