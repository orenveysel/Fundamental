using System.Collections;

namespace _16_FileIslemleri
{
    /*
     * 
     * Yapı (Struct) : Birbirleriyle ilişkili değişkenlerin, 
     * bir isim altında toplanmasına yapı adı verilir. Yapılar, değişik veri tiplerinde elemanlar içerebilirler .
     */

    //benim Veri tipim
    // Modelim :id,first_name,last_name,city,gender,car,DrugName
    public struct Kisi
    {
        // HErhangi bir eriim belirteci vermez isenin default olarak private gelir
        public int Id;
        public string Ad;
        public string Soyad;
        public string Sehir;
        public string Cinsiyet;
        public string Arac;
        public string Ilac;
    }
    // Mazda Erkek : 10 Bayan : 15
    // Toyota Erkek 3 : Bayan 3
    public struct AracDagilimi
    {
        public string Marka;
        public int ErkekKullanici;
        public int KadinKullanici;
    }

    // Ogrencileri temsil eden bir struct yapiniz.
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

            #region Struct -Yapi => Kendi Veri Tipim
            // Kisi kisi = new Kisi();

            List<string> list = new List<string>();
            List<Kisi> kisiList = new List<Kisi>();// Kisi Tipinden bir liste olusturur
            int[] sayilar = new int[2];
            Kisi[] kisiler = new Kisi[1000];
            List<AracDagilimi> aracDagilimListesi = new List<AracDagilimi>();

            #endregion


            #region Dosya Okuma
            //string FileName = "C:\\Users\\Lenovo\\source\\repos\\Istka2024\\Fundamental\\15-HazirMetodlar\\bin\\Debug\\net8.0\\SampleFile.csv"";
            //string fileName = @C:\\Users\\Lenovo\\source\\repos\\Istka2024\\Fundamental\\15 - HazirMetodlar\\bin\\Debug\\net8.0\\SampleFile.csv";
            //FileStream fs = File.OpenRead(FileName);
            //StreamReader sr = new StreamReader(fs);
            //string line;

            //int sayac = 0;
            //while ((line = sr.ReadLine()) != null)
            //{

            //    var gelenler = line.Split(',');
            //    if (sayac > 0)
            //    {
            //        Kisi kisi = new Kisi();
            //        kisi.Id = int.Parse(gelenler[0]);
            //        kisi.Ad = gelenler[1];
            //        kisi.Soyad = gelenler[2];
            //        kisi.Sehir = gelenler[3];
            //        kisi.Cinsiyet = gelenler[4];
            //        kisi.Arac = gelenler[5];
            //        kisi.Ilac = gelenler[6];

            //        kisiList.Add(kisi);

            //        #region AracDagilimi icin gerekli kodlar

            //        AracDagilimi arac = new AracDagilimi(); // Ornek olusturma
            //        arac.Marka = gelenler[5];
            //        if (!aracDagilimListesi.Contains(arac))
            //        {
            //            //arac.ErkekKullanici = gelenler[4] == "Male" ? 1 : 0;
            //            //arac.KadinKullanici = gelenler[4] == "Male" ? 0 : 1;
            //            if (gelenler[4] == "Male")
            //            {
            //                arac.ErkekKullanici = 1;
            //            }
            //            else
            //            {
            //                arac.KadinKullanici = 1;
            //            }
            //            aracDagilimListesi.Add(arac);
            //        }

            //        #endregion
            //    }

            //    sayac++;
            //    //Console.WriteLine(gelenler[0] + " " + gelenler[1] + " " + gelenler[2] + " " + gelenler[3] + " " + gelenler[5] + " " + gelenler[6]);
            //}
            //sr.Close();
            //fs.Close();

            //foreach (var kisi in kisiList)
            //{

            //    Console.WriteLine($"{kisi.Id} {kisi.Ad}  {kisi.Soyad}  {kisi.Sehir}  {kisi.Cinsiyet}  {kisi.Arac}  {kisi.Ilac}");
            //}
            #endregion
            //Arac markalarina gore cinsiyet dagilimi yapalim
            // Mazda Erkek : 10 Bayan : 15
            // Toyota Erkek 3 : Bayan 3


            #region Ceyda
            StreamReader sr = new StreamReader("C:\\Users\\Lenovo\\source\\repos\\Istka2024\\Fundamental\\15-HazirMetodlar\\bin\\Debug\\net8.0\\SampleFile.csv"); // FileStream olusturmadan da okuyor
            List<AracDagilimi> aracList = new List<AracDagilimi>();
            string line;
            bool header = true;
            while ((line = sr.ReadLine()) != null)
            {
                if (header == true)
                {
                    header = false;
                    continue;
                }

                var gelenler = line.Split(",");

                Kisi kisi = new Kisi();
                kisi.Id = int.Parse(gelenler[0]);
                kisi.Ad = gelenler[1];
                kisi.Soyad = gelenler[2];
                kisi.Sehir = gelenler[3];
                kisi.Cinsiyet = gelenler[4];
                kisi.Arac = gelenler[5];
                kisi.Ilac = gelenler[6];

                kisiList.Add(kisi);

                // Class'lar reference type, Struct'lar value type,
                // List class'indan Struct bir eleman cagirdigimizda bize o value'nun kopyasini veriyor,
                // kopya uzerindeki degisiklikler orjinali etkilemeyeceginden compiler buna izin vermiyor

                // Structure listesinin sorunu liste elemanlarinin (AracDagilimi value type) degerlerini degistirememek
                // Cozumu:
                // 1) ayni value tipinde bir local variable olusturup
                // 2) degerini degistirmek istedigimiz elemani local degiskenimize kopyalayip
                // 3) bu local degiskende degisiklik yapip
                // 4) listedeki eski elemanin yerine atamaktir 

                AracDagilimi tempArac = new AracDagilimi(); // Gecici bos arac, (1)
                bool aracVarMi = false;
                for (int i = 0; i < aracList.Count; i++)
                {
                    if (aracList[i].Marka == kisi.Arac)
                    {
                        aracVarMi = true;
                        tempArac = aracList[i]; // listede bulunun aracin degerlerini gecici aracimiza atiyoruz, (2)
                        if (kisi.Cinsiyet == "Female") // cinsiyete gore gecici aracin degerlerini degistir
                        {
                            tempArac.KadinKullanici++; // (3)
                        }
                        else
                        {
                            tempArac.ErkekKullanici++; // (3)
                        }
                        aracList[i] = tempArac; // Asil aracin yerine degerleri degismis gecici araci ata, (4)
                        break;
                    }
                }

                if (!aracVarMi) // Listede bu kisinin araci yoksa aracListesine tempArac'i doldurduktan sonra ekle
                {
                    tempArac.Marka = kisi.Arac;
                    if (kisi.Cinsiyet == "Female")
                    {
                        tempArac.KadinKullanici = 1;
                    }
                    else
                    {
                        tempArac.ErkekKullanici = 1;
                    }
                    aracList.Add(tempArac);
                }
            }

            sr.Close();

            // Arac dagilimini konsola bastirma
            int toplamKadinSayisi = 0;
            int toplamErkekSayisi = 0;

            foreach (AracDagilimi arac in aracList)
            {
                Console.WriteLine($"{arac.Marka,15} => Kadin: {arac.KadinKullanici,2}, Erkek: {arac.ErkekKullanici,2}");
                toplamKadinSayisi += arac.KadinKullanici;
                toplamErkekSayisi += arac.ErkekKullanici;
            }

            Console.WriteLine($"---------------------------------------\n" +
                $"Toplam kadin sayisi: {toplamKadinSayisi}, " +
                $"Toplam erkek sayisi: {toplamErkekSayisi}, " +
                $"Toplam kisi: {toplamKadinSayisi + toplamErkekSayisi}");

            ////Value type ve Reference type arasindaki fark
            //int a = 5;
            //List<int> valueTipiListe = new List<int>();
            //valueTipiListe.Add(a);
            //a = 6;
            //Console.WriteLine($"int a'nin degeri: {a}, listedeki degeri: {valueTipiListe[0]}");

            //Sayi sayi = new Sayi();
            //sayi.a = 5;
            //List<Sayi> referenceTipiListe = new List<Sayi>();
            //referenceTipiListe.Add(sayi);
            //sayi.a = 6;
            //Console.WriteLine($"Sayi class'indaki int a'nin degeri: {sayi.a}, listedeki degeri: {referenceTipiListe[0].a}");
            ////Reference tipinde yapilan degisiklik verinin memory'deki yerine gidip degistiriyor, boylelikle daha onceden listeye eklesek de listedeki degeri degisiyor


            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}