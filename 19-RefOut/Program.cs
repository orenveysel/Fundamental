namespace _19_RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Out Konu Anlatimi

            /*OUT ANAHTAR KELİMESİ
             *Bir metot icerisinden disariya birden fazla deger dondurmek isterseniz, 
             *"return" anahtar kelimesi fonksiyonlarda size yetmeyecektir.
             *Void metotlar ise zaten geriye deger dondurmez.
             *Bu bilinenleri yikabilmek icin kullandigimiz anahtar kelime "out" anahtar kelimesidir...
            */
            #endregion

            #region Out Ornekleri
            //int deger = 0;
            //bool sayi = int.TryParse("12", out deger);
            //int toplam, fark, carpim;
            //decimal bolum;
            //Hesapla(8, 3, out toplam, out fark, out carpim, out bolum);
            //Console.WriteLine($"{toplam} {fark} {carpim} {bolum}");

            //bool oldumu = SayiCevir("13", out deger);
            #endregion

            #region Ref Konu Anlatimi 

            /*
             REF ANAHTAR KELİMESİ

            ref parametre niteleyicisi C#’ın “değer olarak çağrı” yerine “referans olarak çağrı” oluşturmasını sağlar. 
            ref kullanarak, void tipli methodlardan değer alabilirsiniz. Üstelik bu değeri alabilmek için yeni bir değişken atamanıza gerek bile kalmaz. 
            ref, methoda parametre olarak soktuğunuz, elinizdeki varolan değişkeni değiştirebilir.

            ref : C'deki pointer mantigi ile aynidir
             */
            //int[] sayilar = { 1, 2, 3, 4, 5 };
            //DiziBoyutlandir(ref sayilar, 10);

            //int a = 5;
            //DegerDegistir(ref a);
            #endregion

            #region Recursive Metodlar . Kendi kendini cagiran metodlar
            long faktoryel = FaktoryelRecursive(3);
            #endregion

            Console.WriteLine("Hello, World!");
        }

        // Kendi Kendisini Cagiran Metodlar => Recursive metodlar
        public static long FaktoryelRecursive(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            else
            {
                return sayi * FaktoryelRecursive(sayi - 1);
            }

        }
        public static void DegerDegistir(ref int sayi)
        {
            sayi += 10;
        }

        public static void DiziBoyutlandir(ref int[] sayidizisi, int yeniboyut)
        {
            int[] yeniDizi = new int[yeniboyut];
            try
            {
                sayidizisi.CopyTo(yeniDizi, 0); //Sayi dizisini 0. indexten başlayarak kopyalar

            }
            catch (Exception ex)
            {

                throw new Exception("Daha Kucuk bir dizi olusturulamaz");
            }
            sayidizisi = yeniDizi;
        }

        // int.TryParse() kendimiz yazalim 
        public static bool SayiCevir(string str, out int deger)
        {
            try
            {
                deger = Convert.ToInt32(str);
                return true;
            }
            catch (Exception ex)
            {
                deger = 0;
            }
            return false;
        }
        public static void Hesapla(int a, int b, out int toplam, out int fark, out int carpim, out decimal bolum)
        {
            toplam = a + b;
            fark = a - b;
            carpim = b * a;
            bolum = a / (decimal)b;
        }
        // Out ile isaretlenen parametreye mutlaka metod icerisinde bir deger atanmasi gerekir.
        public static void KaresiniAl(int sayi, out int karesi)
        {
            karesi = sayi * sayi;
        }
    }
}
