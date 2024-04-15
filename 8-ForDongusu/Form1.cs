using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace _8_ForDongusu
{
    public partial class Form1 : Form
    {
        // For dongusu: Bir baslangic degeri olan ve bir kosula dek devam eden
        // ve belirledigimiz artisa gore hareket eden bir yapidir
        // Syntax:
        //      for (baslangic;kosul;artim)
        //      {
        //
        //      }
        // Ornek
        //      for(int i=1;i<10;i++)
        //      {
        //          Console.WriteLine("Ali Veli");    
        //      }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Donguye ilk giris aninda derleyici baslangic degerine bakar ve bir daha asla bu bloga ugramaz. 
            //Bundan sonraki islemler once arttir, daha sonra kosula bak,
            //kosul uygunsa dongunun kod blogunu harekete gecir,
            //uygun degilse donguden cik...

            //for(BaslangicDegeri; BitisKosulu; Artis-AzalisMiktari)
            for (int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 100; i > 0; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Yol
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
            // 2. Yol
            for (int i = 0; i <= 100; i = i + 2)
            {
                listBox1.Items.Add(i);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add(c + "-" + Convert.ToInt32(c));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 2000 yilindan gunumuze kadar olan yillari icerisine ekleyelim
            // Ancak 2019 ile 2021 pandemi yillari eklenmesin
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                if (i == 2019 || i == 2020 || i == 2021 || i == 2022)
                {
                    continue;
                }
                listBox1.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 1-100 arasindaki 5'e tam bolunenlerin listesini listbox icerisine ekleyin
            //for (int i = 0; i <= 100; i = i + 5)
            //{
            //    listBox1.Items.Add(i);
            //}

            // Ayni soruyu while ile yapin
            //int i = 0;
            //while (i <= 100)
            //{
            //    listBox1.Items.Add(i);
            //    i = i + 5;
            //}

            //// Ayni soruyu do while ile yapin
            int i = 0;
            do
            {
                listBox1.Items.Add(i);
                i = i + 5;
            } while (i <= 100);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi = 1;
            int faktoriyel = 1;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                sayi = Convert.ToInt32(textBox1.Text);

                for (int i = sayi; i > 0; i--)
                {
                    faktoriyel *= i;
                }
                listBox1.Items.Add($"{sayi} faktoriyel {faktoriyel} dir");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
             *   1 x 1 = 1
             *   ..
             *   .. 
             *   ..
             * 
             *   9 x 9 = 81
             */

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox1.Items.Add($"{i} X {j} = {i * j}");
                }
                listBox1.Items.Add("");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Kullanicidan alinan sayiyi 5 ile çarpma islemi yapmadan çarpan dongu
            listBox1.Items.Clear();

            int sayi = int.Parse(textBox1.Text);
            int sonuc = 0;
            for (int i = 0; i < 5; i++)
            {
                sonuc += sayi;
            }

            listBox1.Items.Add(sonuc);
        }
        // 1-  0-100 arasindaki üçe  ve yediye bölünenlerin toplamini ekrana yaziniz
        // 2-  Klavyeden girilen  sayiya kadar olan fibanocci sayilarini listeleyiniz
        // 3-  Klavyeden girilen sayini basamaklarini while ile bulunuz
        // 4-  do-while ile ekrandan 0 girilene kadar sayi okutan donguyu yapiniz.
        // 5- kullanicidan sayi istenecek.Girilen sayi toplami 100 veya uzeri olana kadar sayi girmeye devam ettirecek dongu
        // 6- Kullanicidan alinan iki sayi arasindaki sayilarin kare ve küp toplamlarini hesaplayin.
        //                 Kurallar : i--girilen sayilarin birincisi kucuk, ikincisi buyuk olabilir.
        //                            veya birinci buyuk ikinci kucuk olacak sekilde siraya bagli kalmaksizin veri girebilir. 
        //                           ii- kullanicin girdigi degerlerin sayi olup olmadigi kontrol edip ekrana uygun mesaj verilecek. VE girilen deger yeniden istenecek
        //                           iii- Girilen degerler ekrana 3 kolon seklinde basilacak.
        //                                Sayi Karesi  Küpü
        //                            iV- Devam etmek istiyormusunuz sorusu sorulacak.Evet derse program devam edecek.Programi sonlandirmak icin hayir yazilacak.
        //7-  Bilgisayarin tutugu bir sayiyi tahmin eden oyun.
        //                 Kurallar : Tutlan sayi Araligi 1-100 arasinda olacak.
        //                 Tahmin hakkini ekran dan alin.Girilen tahmin hakki ladar ekrandan deger okutun.
        //                 Kullanici yi yönlendirin.Buyuk yada kucuktur diye. Musteri kacmasin .

        //            Devam etmek istiyormusunuz sorusu sorulacak.Evet derse program devam edecek.Programi sonlandirmak icin hayir yazilacak.
    }
}
