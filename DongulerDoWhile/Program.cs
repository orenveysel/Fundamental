namespace _7_DongulerDoWhile
{
    internal class Program
    {
        // DONGULER - LOOPS
        // Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri
        // tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz 
        static void Main(string[] args)
        {
            #region While Dongusu

            #region Basic Template
            //while (condition)
            //{
            //    // code block to be executed
            //}

            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //} 
            #endregion

            #region 1-50 arasindaki tek sayilari bastiralim
            //int index =0;
            //while (index <= 50)
            //{
            //    if (index % 2 != 0)
            //    {
            //        Console.WriteLine(index);
            //    }
            //    index++;
            //}
            #endregion

            #region Ekrandan 0 girilene kadar sayilari okutunuz
            // Okutulan sayilarin cift toplamlarini ekrana yazdiriniz
            //int sayi = 0;
            //int ciftToplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayi giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        break; // burada donguyu kirar
            //    }
            //    else if (sayi % 2 == 0)
            //    {
            //        ciftToplam = ciftToplam + sayi; // ciftToplam += sayi; kisa yazilimi
            //    }
            //}
            //Console.WriteLine("Toplam :" + ciftToplam);
            #endregion

            #region 8 haneli rastgele sayisal bir sifre
            //Random rndm = new Random();
            ////int sifre = rndm.Next(10000000, 99999999);
            ////Console.WriteLine(sifre);

            //string sifre = "";
            //int index = 1;
            //while (index <= 8)
            //{
            //    sifre = sifre + rndm.Next(0, 10);
            //    index++;
            //}
            //Console.WriteLine(sifre);
            #endregion

            #region 8 haneli rastgele sifre + ODEV
            //char ch;
            ////Console.WriteLine(char.ConvertFromUtf32(100));
            //// Ascii tabloda 48-57 arasi sayisal alan
            //// 65-90 arasi buyuk harf ile alfabe
            //// 97-122 arasi kucuk harf ile alfabe
            //// Yukarisi odev

            //// 33-127 arasi random bir deger yeterli olacaktir

            //Random rndm = new Random();

            //string sifre = "";
            //int index = 1;
            //Console.WriteLine("Uretilecek sifre uzunlugu: ");
            //int uzunluk = int.Parse(Console.ReadLine());
            //while (index <= uzunluk)
            //{
            //    sifre = sifre + char.ConvertFromUtf32(rndm.Next(33, 127));
            //    index++;
            //}
            //Console.WriteLine(sifre);
            #endregion

            #region 1-100 arasindaki sayilarin cift toplamlari ile tek toplamlari arasindaki farkin karesi

            //int tekSayilar = 0;
            //int ciftSayilar = 0;
            //int index = 0;
            //while (index <= 100)
            //{
            //    if (index % 2 != 0)
            //    {
            //        tekSayilar += index;
            //    }
            //    else if (index % 2 == 0)
            //    {
            //        ciftSayilar += index;
            //    }
            //    index++;
            //}
            //int fark = ciftSayilar - tekSayilar;
            //Console.WriteLine(fark*fark);

            #endregion

            #endregion

            #region Do-While Dongusu

            #region Konu Anlatimi

            /* do-while dongusunun while'dan farki 
                Donguye en az bir kere girer
                kullanimi:
            do
            {
                // yapilacak isler

            }while(condition)

             */

            #endregion

            #region Anket

            // Bir urun icin yapilan ankette begenen, begenmeyen ve kararsiz kalanlarin sayisini
            // ve toplam musteri sayisini ekrana yazdiran program
            // "Baska musteri var mi?" sorusuna hayir(H/h) demedigi surece ankete devam edilsin

            //int begenenSayisi = 0, begenmeyenSayisi = 0, kararsizSayisi = 0, sayac = 0;
            //string cevap = "";
            //do
            //{
            //    sayac++;
            //    Console.WriteLine("Urunu begendiniz mi? [ E / H / K ]");
            //    string str = Console.ReadLine();
            //    switch (str)
            //    {
            //        case "e":
            //        case "E":
            //            begenenSayisi = begenenSayisi + 1;
            //            break;
            //        case "h":
            //        case "H":
            //            begenmeyenSayisi = begenmeyenSayisi + 1;
            //            break;
            //        case "k":
            //        case "K":
            //            kararsizSayisi = kararsizSayisi + 1;
            //            break;
            //        default:
            //            Console.WriteLine("Yanlis cevap verdiniz. Lutfen yeni giris yapiniz [ E / H / K ]");
            //            break;
            //    }

            //    Console.WriteLine("Baska anket yapilacak mi? [E/H]");
            //    cevap = Console.ReadLine();
            //    if (cevap == "H" || cevap == "h")
            //    {
            //        break;
            //    }
            //} while (cevap == "E" || cevap == "e");
            //Console.WriteLine("Begenen Sayisi: " + begenenSayisi);    
            //Console.WriteLine("Begenmeyen Sayisi: " + begenmeyenSayisi);
            //Console.WriteLine("Kararsiz Sayisi: " + kararsizSayisi);

            //Console.WriteLine("Yapilan toplam anket sayisi: " + sayac);

            #endregion

            #region Kulanicinin girdigi kelimeyi kullanicinin istedigi kadar tekrar eden dongu
            int sayac = 0;

            Console.WriteLine("Bir kelime giriniz: ");
            string kelime = Console.ReadLine();

            Console.WriteLine("Kac kere tekrar edilecek? ");
            sayac = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(kelime);
                sayac--;
            }while(sayac > 0);

            #endregion

            #endregion
        }
    }
}
