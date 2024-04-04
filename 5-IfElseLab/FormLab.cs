using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_IfElseLab
{
    public partial class FormLab : Form
    {
        // Ekrandan 0-24 bir sayi aliniz
        // 4-11 arasi ise => Sabah
        // 11-14 arasi ise => Oglen
        // 14-19 arasi ise => İkindi
        // 19-22 arasi ise => Aksam
        // 22-4 arasi ise => Gece
        public FormLab()
        {
            InitializeComponent();
        }

        private void FormLab_Load(object sender, EventArgs e)
        {
            
        }

        private void kontrol_Click(object sender, EventArgs e)
        {
            int sayi;
            bool durum = int.TryParse(girdi.Text, out sayi);
            // Eger girilen textbox icerisindeki deger integer'a cevirildi mi kontrolu
            if (durum) // true
            {
                if(sayi>=4 && sayi<11)
                {
                    lblMesaj.Text = "Sabah";
                }
                else if(sayi>=11 && sayi<14)
                {
                    lblMesaj.Text = "Öğlen";
                }
                else if (sayi >= 14 && sayi < 19)
                {
                    lblMesaj.Text = "İkindi";
                }
                else if (sayi >= 19 && sayi < 22)
                {
                    lblMesaj.Text = "Akşam";
                }
                else
                {
                    lblMesaj.Text = "Gece";
                }
            }
            else
            {
                lblMesaj.Text = "Hatalı veri girişi! Lütfen sayı giriniz.";
                girdi.Text = "";
            }
        }
    }
}
