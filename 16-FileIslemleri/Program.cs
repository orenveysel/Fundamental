namespace _16_FileIslemleri
{
    /*
     * 
     * Yapı (Struct) : Birbirleriyle ilişkili değişkenlerin, 
     * bir isim altında toplanmasına yapı adı verilir. Yapılar, değişik veri tiplerinde elemanlar içerebilirler .
     */

    // Benim veri tipim
    // Modelim :id,first_name,last_name,city,gender,car,DrugName
    public struct Kisi
    {
        // Herhangi bir erisim belirteci vermezsek default olarak private gelir
        public int Id;
        public string Ad;
        public string Soyad;
        public string Sehir;
        public string Cinsiyet;
        public string Arac;
        public string Ilac;
    }

    // Mazda Erkek: 10 Kadın: 15
    // Toyota Erkek: 3 Kadın: 3

    // Ogrencileri temsil eden bir struct yapiniz
    public struct Ogrenci
    {
        public int OgrenciNo;
        public string Ad;
        public string Soyad;
        public string Sehir;
        public bool Cinsiyet;
        public string TcNo;
        public string Gsm;
        public string Email;
    }

    public struct AracDagilimi
    {
        public string Marka;
        public int ErkekKullanici;
        public int KadinKullanici;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Escape Karakterler
            //\' – Output a Single quote.
            //\” – Output a double quote.
            //\ – Output a Backslash.
            //\n – Insert a newline.
            //\r – Insert a carriage -return.
            //\t – Insert a tab.
            //\0 – Insert a null character.
            //\b – Insert a backspace. 
            #endregion

            #region Struct - Yapi => Kendi Veri Tipim

            // Kisi kisi = new Kisi();
            
            List<string> list = new List<string>();
            List<Kisi> kisiList = new List<Kisi>(); // Kisi tipinden bir liste olusturur
            int[] sayilar = new int[2];
            Kisi[] kisiler = new Kisi[1000];
            List<AracDagilimi> aracDagilimListesi = new List<AracDagilimi>();

            #endregion

            string FileName = "C:\\Users\\Lenovo\\source\\repos\\Istka2024\\Fundamental\\15-HazirMetodlar\\bin\\Debug\\net8.0\\SampleFile.csv";
            string fileName = @"C:\Users\Lenovo\source\repos\Istka2024\Fundamental\15-HazirMetodlar\bin\Debug\net8.0\SampleFile.csv";
            FileStream fs = File.OpenRead(FileName);
            StreamReader sr = new StreamReader(fs);
            string line;

            int sayac = 0;
            while ((line = sr.ReadLine()) != null)
            {
                var gelenler = line.Split(',');
                if (sayac > 0)
                {
                    Kisi kisi = new Kisi();
                    kisi.Id = int.Parse(gelenler[0]);
                    kisi.Ad = gelenler[1];
                    kisi.Soyad = gelenler[2];
                    kisi.Sehir = gelenler[3];
                    kisi.Cinsiyet = gelenler[4];
                    kisi.Arac = gelenler[5];
                    kisi.Ilac = gelenler[6];

                    kisiList.Add(kisi);

                    #region Arac Dagilimi icin gerekli kodlar
                    
                    AracDagilimi arac = new AracDagilimi(); // Ornek olusturma
                    arac.Marka = gelenler[5];
                    if (!aracDagilimListesi.Contains(arac))
                    {
                        //arac.ErkekKullanici = gelenler[4] == "Male" ? 1 : 0;
                        //arac.ErkekKullanici = gelenler[4] == "Male" ? 0 : 1;

                        if (gelenler[4]=="Male")
                        {
                            arac.ErkekKullanici = 1;
                        }
                        else
                        {
                            arac.KadinKullanici = 1;
                        }
                        aracDagilimListesi.Add(arac);
                    }
                    else
                    {
                        
                    }
                    #endregion
                }
                sayac++;

                //Console.WriteLine(gelenler[0] + " " + gelenler[1] + " " + gelenler[2] + " " + gelenler[3]
                //    + " " + gelenler[4] + " " + gelenler[5] + " " + gelenler[6]);
            }
            sr.Close();
            fs.Close();

            foreach (var kisi in kisiList)
            {
                Console.WriteLine($"{kisi.Id} {kisi.Ad} {kisi.Soyad} {kisi.Sehir} {kisi.Cinsiyet} " +
                    $"{kisi.Arac} {kisi.Ilac}");
            }

            // Arac markalarina gore cinsiyet dagilimi yapalim
            // Mazda Erkek: 10 Kadın: 15
            // Toyota Erkek: 3 Kadın: 3

            Console.WriteLine("Hello, World!");
        }
    }
}
