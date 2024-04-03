using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _5_IfElseLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            // username: admin password = 123 olarak kontrol edilecek
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (userName == "admin" && password == "123")
            {
                MessageBox.Show("Hoşgeldin Admin");
            }
            else
            {
                MessageBox.Show("Username ya da şifre hatalıdır!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // girilen textbox1'deki not
            // 0-29 arasinda "FF"
            // 30-49 arasinda "DD"
            // 50-69 arasinda "BB"
            // 70-100 arasinda "AA"
            // olacak sekilde kullaniciya bilgi veriniz
            int not = int.Parse(textBox1.Text);
            if (not >= 0 && not < 30)
            {
                MessageBox.Show("Harf Notunuz: FF");
            }
            else if (not >= 30 && not < 50)
            {
                MessageBox.Show("Harf Notunuz: DD");
            }
            else if (not >= 50 && not < 70)
            {
                MessageBox.Show("Harf Notunuz: BB");
            }
            else if (not >= 70 && not < 100)
            {
                MessageBox.Show("Harf Notunuz: AA");
            }
            else
            {
                MessageBox.Show("Hatalı Not Girişi!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urun = textBox2.Text;
            if (urun == "Domates" || urun == "Biber" || urun == "Patlican")
            {
                MessageBox.Show("Sebze Reyonu");
            }
            else if (urun == "Diş Macunu" || urun == "Parfüm" || urun == "Şampuan")
            {
                MessageBox.Show("Kozmetik reyonu");
            }
            else if (urun == "Cep Telefonu" || urun == "Bilgisayar" || urun == "Ses Sistemi")
            {
                MessageBox.Show("Teknoloji reyonu");
            }
            else
            {
                MessageBox.Show("Bu ürün bizde yok!!");

            }

        }
    }
}
