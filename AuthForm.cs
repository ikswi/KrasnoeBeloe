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
    public partial class AuthForm : Form
    {
        public static string Login = "";
        List<string> Users = new List<string>();

        public AuthForm()
        {
            InitializeComponent();
            Users = new List<string>();
            Users.Add("1");  Users.Add("1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sluchilos = false;

            for (int i = 0; i < Users.Count; i += 2)
            {
                if (textBox1.Text == Users[i] &&
                   textBox2.Text == Users[i + 1])
                {
                    Login = textBox1.Text;
                    Close();
                    sluchilos = true;
                }
            }

            if (!sluchilos)
                MessageBox.Show("Повторите попытку через год");
        }
    }
}
