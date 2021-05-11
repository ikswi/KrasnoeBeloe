using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qqqq
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Укажите тему");
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Укажите ваши контакты");
            }


            MailAddress from = new MailAddress("qqqqqqqqqqqwwwwwwwwwss@gmail.com");
            MailAddress to = new MailAddress("ikswi@yandex.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = comboBox1.Text;
            if (address != "")
            {
                Attachment att = new Attachment(address);
                att.Name = "1.jpg";
                m.Attachments.Add(att);
            }
            m.Body = textBox2.Text + 
                Environment.NewLine +
                Environment.NewLine + "Со мной связаться можно через: " + textBox1.Text;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("qqqqqqqqqqqwwwwwwwwwss@gmail.com", "12345678Aa");
            smtp.EnableSsl = true;
            smtp.Send(m);

            MessageBox.Show("Сообщение отправлено");

        }

        string address = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
