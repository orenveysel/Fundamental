using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _5_IfElseLab
{
    public partial class SayiTahmin : Form
    {
        // Program calistiginda 1-50 arasinda bilgisayar bir sayi tutacak
        // Ekrandan 5 kere tahmin hakki istenecek
        // lblMesaj Text'ine eger tutulan sayidan daha buyuk bir deger girdi ise
            // daha kucuk bir sayi giriniz mesaji,
            // tersi durumda ise daha buyuk bir sayi giriniz mesaji yazdirilacak
        // Ekranda tahmin hakkini gosteren bir lable da olsun

        Random random = new Random();
        int tutulanSayi, hak=5, girilenSayi;
        public SayiTahmin()
        {
            InitializeComponent();
        }

        private void SayiTahmin_Load(object sender, EventArgs e)
        {
            // next metodundaki birinci parametre dahil,
            // ikinci parametredeki sayinin bir eksigine kadar rastgele sayi uretilir
            tutulanSayi = random.Next(1, 51);        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Normal sekilde integer yanlis formatta girilmis ise
            // Asagidaki kod hata verecektir

            if (hak > 0)
            {
                int cevirilenSayi;
                bool olduMu = int.TryParse(deneme.Text, out cevirilenSayi);

                if (olduMu)
                {
                    if (tutulanSayi == cevirilenSayi)
                    {
                        lblMesaj.Text = $"Tebrikler {6 - hak}. denemede buldunuz!!";
                        hak = 5;
                        deneme.Text = "";
                    }
                    else if (tutulanSayi > cevirilenSayi)
                    {
                        lblMesaj.Text = $"Daha buyuk bir sayi giriniz";
                        lblMesaj.BackColor = Color.Red;
                    }
                    else
                    {
                        lblMesaj.Text = $"Daha kucuk bir sayi giriniz";
                        lblMesaj.BackColor = Color.Green;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Value");
                }
                hak--;
                lblTahmin.Text = $"Kalan tahmin hakkiniz {hak}";
            }
            else
            {
                lblMesaj.Text = "Tahmin Hakkiniz Bitmistir.";
                deneme.Text = "";
            }
        }
    }
}
