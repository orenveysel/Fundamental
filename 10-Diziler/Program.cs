namespace _10_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir siniftaki ogrencilerin notlarini tutacak degiskenleri tanımlayiniz
            // Sinif 5 kisidir.. Asagidaki kod hammaliye kodudur
            int ogrenci1, ogrenci2, ogrenci3, ogrenci4, ogrenci5 = 0;
            // Birden fazla ayni tipteki veriyi bir arada tutmamizi saglayan nesnelere dizi denir
            // Dizi Operanti [] ile gosterilir
            // Tanimlamasi tip[] diziAdi;
            // ogrencilerin notlarini tutacak dizi tanimi

            // 1. Tanimlama yontemi
            int[] notlar = new int[5];
            Random rand = new Random();
            // Notlar dizisini rastgele degerlerle doldurma
            for (int i = 0; i < notlar.Length; i++)
            {
                notlar[i] = 1 + rand.Next(100);
            }

            // Manuel deger atama, 3. siradaki ogrenciye not girisi
            notlar[2] = 60;
            // Degeri ekrana bastirma
            Console.WriteLine(notlar); // Bu sekilde sadece dizinin tipini verir
            Console.WriteLine(notlar[1]); // Dizideki 2. elemanın degerini verir

            // notlar[5] = 56; // Burasi index outside the bound hatasi

            #region Dizilerde 2. Tanimlama Yontemi
            // Diziler tanimlandigi anda sabit boyuttadir
            // Asagidaki tanimlama ilk deger atamasinin yapildigi bir tanimlamadir
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            #endregion

            #region 3. Yontem
            // Tanimlamasi VeriTipi[] DiziAdi = {dizielemanlari};
            // Asagidaki tanimlama ilk deger atamasinin yapildigi bir tanimlamadir
            // Bu tanimlamada new keywordune gerek yoktur
            int[] sayilar2 = { 1, 2, 3, 4, 5, 6 };
            #endregion

            #region Diger Veri Tipleri ile dizi tanimlama
            string[] sehirler = { "Adana", "Ankara", "Izmir", "Istanbul" };
            char[] harfler = { 'a', 'b', 'c' };
            char[] chars = new char[10];
            bool[] tercihler = { true, false, false, false, true };
            bool[] tercih2 = new bool[10];
            DateTime[] dateTimes = { DateTime.MinValue, DateTime.MaxValue, DateTime.Now };
            #endregion

            #region Sorular
            // Kullanicilarin Adlari ve Soyadlarini tutan dizi tanimlamasi
            string[] adSoyadlar = new string[10];

            // Kullanicilarin email'lerini tutan dizi
            string[] emailler = new string[10];
            emailler[0] = "ali@gmail.com";

            // gsm'lerini tutan dizi
            string[] gsmler = new string[10];

            // Dogum tarihlerini tutan dizi tanimlamasi yapiniz
            DateTime[] dogumGunleri = new DateTime[10];

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
