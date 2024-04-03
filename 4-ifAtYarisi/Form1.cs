using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_ifAtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        // Yarisi sifirlama
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            at1.Left = at2.Left = at3.Left = 9;
            lblDurum.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form Load Event tetiklendi");
        }

        //Zamanlayicinin ne yapmasi gerektigi burada yazilacak
        private void timer1_Tick(object sender, EventArgs e)
        {
            at1.Left += rnd.Next(10, 30);
            at2.Left += rnd.Next(10, 30);
            at3.Left += rnd.Next(10, 30);
            //lblDurum.Text = "Atin X Konumu: "+at1.Left.ToString()+ " Y Konumu: "+ at1.Right;
            //lblDurum.Text = $"Atin X Konumu: {at1.Left.ToString()} Y Konumu: {at1.Right}";
            #region Atlarin Durumu, Kim Onde?
            if (at1.Left > at2.Left && at1.Left > at3.Left)
            {
                lblDurum.Text = $"At1 onde gidiyor, X Konumu: {at1.Left.ToString()} + Y Konumu: {at1.Right}";
            }
            else if (at2.Left > at1.Left && at2.Left > at3.Left)
            {
                lblDurum.Text = $"At2 onde gidiyor, X Konumu: {at2.Left.ToString()} + Y Konumu: {at2.Right}";
            }
            else
            {
                lblDurum.Text = $"At3 onde gidiyor, X Konumu: {at3.Left.ToString()} + Y Konumu: {at3.Right}";
            }
            #endregion

            #region Kazanan At
            if (at1.Left + at1.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Birinci At Kazandi");
            }
            else if (at2.Left + at2.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("İkinci At Kazandi");
            }
            else if (at3.Left + at3.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Ucuncu At Kazandi");
            } 
            #endregion
        }
    }
}
