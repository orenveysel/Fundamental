namespace _6_Try_Catch
{
    /*
          * ISTISNA TIPLERI
          * 
          * Calisma Zamani Hatalarý (Runtime Exception) => Cogunlukla kullanici kaynakli hatalardir. (Verinin yanlis, eksik ya da bos girilmesi). Cozum Yolu, try-catch ile hatalari ele alabilirsiniz...
          * 
          * Derleme Zamani Hatalari (Compile Exception) => Tamamen yazilimci kaynakli hatalardir. Yazim hatalari meydana geldiginde devreye girer. En kolay cozulen hata tipidir. Visual Studio sizi uyarir (asagidaki Error List penceresi ile). Ilgili hataya cift tiklayip detaya gidebilir ve hatayi aninda duzeltebilirsiniz...
          * 
          * Mantiksal Hatalar => Tamamen programci kaynakli hatalardir. Uygulamanin algoritmasinda meydana gelir. Ornegin bolme yapilacak yerde islem unutulmasi, degerin yanlis bir degerle degistirilmesi... Cozulmesi en zor hatalardir. Anlik olarak derleme asamasini takip etmeli ve degerlerinizi gozlemlemelisiniz. Bu konuda Visual Studio size sagladigi tool'larla yardimci olur. (Immediate Window, Watch, Breakpoint)
          */
    /*
    * BREAKPOINT => Derleme asamasina adim adim dahil olmak icin kullandigimiz yardimci tool'dur. Yapmaniz gereken tek sey, hangi satirdan derleme anina dahil olmak istiyorsaniz, ilgili satirin en sol kismina gelip (gri alan) mouse'un sol tusuyla bir kýrmýzý top yerlestirmek. Artik derleyici bu satira geldigi zaman sizi olaya dahil edecektir...
    * F11 ile adim ilerleyebilirsiniz. Degiskenlerin, nesnelerin uzerine gelip o anki degerlerini ogrenebilirsiniz, islemin bittigine inanýyorsaniz F5'e basip breakpoint'ten cikabilir ve islemin kendisini devam ettirmesini saglayabilirsiniz.
    * Sol blokta cikan sari ok, derlenen satirin isaretcisidir. Mouse yardimiyla ileri ya da geri oynatabilir yani adimlari atlayabilir ya da tekrarlatabilirsiniz...
    */

    /*
     * WATCH
     * Yalnizca run-time'da - calisma zamani - kullanabilecegimiz bir tool'dur. Dolayisiyla pencereyi sadece calisma zamaninda gorursunuz...
     * Ýlk ayarlarinizda Watch penceresi kapali olabilir. Uygulamanizi calistirip "CTRL+ALT+W" ardindan 1'e basarsaniz Watch penceresini getirirsiniz...
     * Run-time'de elinizde olan degerleri (kontrol degerler, degisken degerleri) degistirmenize, izlemenize olanak saglayan yardimci tool'dur. Acilan penceredeki "Name" alanina ilgili degiskenin adini yazip Enter'a basarsaniz, "Value" alaninda o anki degerini gozlemleyebilirsiniz. Hatta degistirebilirsiniz...
     * "Name" alanina degeri ilk yazmaya basladiginizda intellisense size destek vermez. Ancak "CTRL+Space" kombinasyonu ile intellisense'i aktif hale getirebilirsiniz. Hatta cogu zaman kendisi otomatik olarak tamamlar. 
     * Noktalar, virgüller, noktali virgüller - yani tum yazim kurallari - watch penceresi icin de gecerlidir...
     */

    //Eger disaridan bir veri aliyorsaniz, verinin tutarligindan emin de degilseniz, orada mutlaka hata riski vardýr!
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    //Yapilacak iþler buraya yazilacak
            //    string str = "ali";
            //    int a = Convert.ToInt32(str);
            //}
            //catch (Exception)
            //{
            //    //Yakalanan hata olursa burada iþlem gorecek
            //    throw new Exception(" Formun Yuklenmesi sirasinda hata olustu");
            //}
            //finally
            //{
            //    // Hata olsun yada olmasin burasi mutlaka calisacak.
            //    // Genelde SqlConnection tarzi socket iþlemlerinde acik olan connection'i kapatmaya yarar.
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 5;
            b = 6;
            c = 7;
            int toplam = a + b + c; // 18 cikar
            int carpma = a * b * c; // 210 cikar
            c = 1;
            int bolum = a / c;
            int gelenDeger = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = 5;
                b = 6;
                c = 7;
                int toplam = a + b + c; // 18 cikar
                int carpma = a * b * c; // 210 cikar
                c = 0;
                int bolum = a / c; // DivideByZero hatasi alacaktir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = 5;
                c = 7;

                c = int.Parse(textBox1.Text);
                int bolum = a / c;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Sifira Bolme Hatasi Olustu. Lutfen 0 Girmeyiniz");

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lutfen Sayi Giriniz");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = 5;

                c = int.Parse(textBox1.Text);
                int bolum = a / c;
            }
            // Bu kisim mutlaka sonda olacak . Eger Diger Exception'larin onunde olursa hata alirsiniz.
            //catch (Exception ex) // burasi mutlaka en son kisimda olmasi gerekiyor.
            //{
            //    MessageBox.Show("Beklenmedik bir hata olustu");
            //}
            catch (FormatException ex)
            {
                MessageBox.Show("Lutfen Sayi Giriniz");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Sifira Bolme Hatasi Olustu. Lutfen 0 Girmeyiniz");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenDeger = Convert.ToInt32(textBox1.Text);
                int sonuc = gelenDeger / 0;
            }
            catch (FormatException hata) // Format Hatasi
            {
                throw new Exception("Girilen deger integer tipinde degildir..");
            }
            catch (DivideByZeroException hata) // Sifira bolme Hatasi
            {
                throw new Exception("Sifira Bolme hatasi:" + hata.Source);
            }
            catch (OverflowException hata) // Taþma hatasi
            {
                throw new Exception(hata.Message);
            }
            catch (Exception hata) // Burasi gelen butun hatalari yakalar
            {
                throw new Exception(hata.Message);
            }
            finally // Burasi en son yapilmasi gereken isler icin kullanilir
            {
                MessageBox.Show("Her kosulda en son burasi calisir");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenDeger = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler Dogru Formatta girdiniz");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Olustu. Detay :" + ex.Message);
            }
            finally // Burasi en son yapilmasi gereken isler icin kullanilir
            {
                MessageBox.Show("Her kosulda en son burasi calisir");
            }
        }
    }
}
