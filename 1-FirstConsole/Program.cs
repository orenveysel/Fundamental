namespace _1_FirstConsole
{
    internal class Program
    {
        /*
         * 
         * Main metodu olmazsa program calismaz
         * Isletim sistemleri calistirilacak programda mutlaka main metodunu arar
         * 
         * 
         * Kisa Yollar:
         * 
         *      ctrl + shift + B => programi derler
         *      
         *      ctrl + K + C => secilen yeri yorum satiri yapar
         *      
         *      ctrl + K + U => secilen yeri yorum satirindan cikarir
         *      
         *      ctrl + K + S => Region olusturmaya yarar
         * 
         */
        static void Main(string[] args)
        {
            #region Giris
            /*
            // Degisken Tanimlari
            // veritipi <degisken ismi>;
            string kelime1, kelime2;
            int sayi1, sayi2;

            // Bu bir yorum satiridir
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Bir kelime giriniz: ");
            kelime1 = Console.ReadLine();
            Console.WriteLine("Baska bir kelime giriniz: ");
            kelime2 = Console.ReadLine();

            //Girilen kelimeleri ekrana basalim
            Console.WriteLine("Girilen kelimeler " + kelime1 + " " + kelime2);

            //Ekrani bekletmek icin yazildi
            Console.ReadLine();
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------
            #region Tamsayi degisken tipleri
            /*
            
            byte : Uzunluğu 1 byte'dır, 0 ile 255 arasında değer alır.

            sbyte : Uzunluğu 1 byte'dır, -128 ile 127 arasında değer alır.

            short : Uzunluğu 2 byte'dır, -32768 ile 32767 arasında değer alır.

            ushort : Uzunluğu 2 byte'dır, 0 ile 65535 arasında değer alır.

            int : Uzunluğu 4 byte'dır, -2.147.483.648 ile 2.147.483.648 arasında değer alır.

            uint : Uzunluğu 4 byte'dır, 0 ile 4.294.967.295 arasında değer alır.

            long : Uzunluğu 8 byte'dır, -10^20 ile 10^20 arasında değer alır.

            ulong : Uzunluğu 8 byte'dır, 0 ile 2 x 10^20 arasında değer alır.

            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Degisken Tanimlama Kurallari
            /*
            sayı ile baslayamaz
            _ haric özel karakter içeremez
            255 karakterden büyük olamaz
            kelimeler arası boşluk bırakılamaz
            Microsoft PascalCase kullanılır

            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region İki sayinin toplami
            /*
            // Asagidaki degisken tanimlamalari aynidir
            string input1, input2;
            int sayi1 = 0;
            Int32 sayi2 = 0; // kisa keyword int

            Int64 sayi3 = 0; // kisa keyword long
            long sayi4 = 0;

            Console.WriteLine("Birinci Sayiyi Giriniz: ");
            input1 = Console.ReadLine();
            // Girilen ifadeyi int veri tipine çevirmek icin
            // 1. yol

            sayi1 = Convert.ToInt32(input1);
            Console.WriteLine("İkinci Sayiyi Giriniz: ");
            input2 = Console.ReadLine();

            // Girilen ifadeyi int veri tipine çevirmek icin
            // 2. yol
            sayi2 = int.Parse(input2);

            Console.WriteLine("Girilen sayilarin toplami: " + (sayi1 + sayi2)); // Burasi normal toplama yapar
            Console.WriteLine("Girilen sayilarin toplami: " + (input1 + input2)); // Burasi string birlestirme islemi yapar
            */

            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Kesirli Sayilar

            /* Kesirli Sayilar
            
            float : Uzunluğu 4 byte'dir, 1.5 x 10-45 ile 3.4 x 1038 arasında değer alır.

            double : Uzunluğu 8 byte'dir, 5.0 x 10-324 ile 1.7 x 10308 arasında değer alır.

            decimal : Uzunluğu 12 byte'dir, ±1.0 x 10-28 ile ±7.9 x 1028 arasında değer alır.

            Asagıdaki tanimlama hata verecektir
            float sayiFloat = 12.5;
            decimal sayiDecimal = 12.5;

            Eger noktali bir sayi atamasi yapiliyorsa default olarak c# double kabul eder
            double sayiDouble = 12.5;

            Duzeltilmis hali
            float sayiFloat = 12.5f;
            decimal sayiDecimal = 12.5m;

            */

            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region String Degiskenler
            /*
            
            string  => kelime ya da cumle, paragraf artik ne atadiysaniz kabul eder

            char => uzunlugu 2 byte'dir. Unicode karakter temsil eder. Bir karakter kabul eder

            string str = "asdk asldkjasbd alsjdnasjnd .askjdnaskjd";
            char c = 'a';

            */

            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Mantiksal Degisken
            /*
            
            bool veri tipi true ya da false degerleri alir
            bool devamMi = false;

            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region null ifadesi ve nullable degiskenler
            /*
            null ascii tablodaki 0. elemandır. Ozel bir karakterdir. Hiclik anlamina gelir

            int a = null; 
            bu satir hata verecektir, nullable degildir cunku

            herhangi bir veri tipinin sonuna ? eklenirse nullable oldugu anlamina gelir
            int? b = null;

            */

            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region var keyword
            /*
            
            Degisken tanimlamalarinda once tip sonra degisken adi verilmek zorundadir
            var ile kullanilir ise atanan deger ne ise degisken o veri tipine burunur

            var ali = "Ali veli";
            var sayi = 12.5;

            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Tarih ve Zaman
            /*
            Tarih ve zamani beraber tutar
            DateTime dateTime = DateTime.Now;

            Kendi belirledigimiz tarihi olusturma
            DateTime tarih = new DateTime(2000, 2, 2, 12, 15, 30);
            Console.WriteLine(dateTime);

            DateOnly Sadece tarihi tutar, zamani tutmaz
            DateOnly trh = new DateOnly(2000,2,2);

            Sadece zamani tutar
            TimeOnly trh2 = new TimeOnly(12, 12, 12, 12);

            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Degiskenlerde Scope Kavrami
            /*
            string cumle = "Deneme 123";
            {
                cumle = cumle + " alt scope";
                int sayi3 = 0;
                sayi3 = 5 * 4;
                {
                    Console.WriteLine(sayi3);
                    int sayi4 = 0;
                }
                // Burasi da hata verecektir, sayi3 ust scope icerisinde kaldi
                Console.WriteLine(sayi4);
            }
            // Burasi hata verecektir cunku yukaridaki scope icerisinde kaldi ve biz sayi3 degiskenine ulasamıyoruz
            Console.WriteLine(sayi3);
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Bir siniftaki ogrencinin ozelliklerini temsilen degisken tanimlamalarini yapiniz

            //string ad, soyad, gsm, email;
            //DateTime dogumTarihi;
            //long tcNo = 12345678901;
            //string tcNoStr = "12345678901";
            //bool cinsiyet;

            //Console.WriteLine("Adınızı giriniz: ");
            //ad = Console.ReadLine();
            //Console.WriteLine("Soyadınızı giriniz: ");
            //soyad = Console.ReadLine();
            //Console.WriteLine("Tc kimlik numaranızı giriniz: ");
            //tcNo = Console.ReadLine();

            //Console.WriteLine("Bilgileri girilen kişinin adı: " + ad + ", soyadı: " + soyad + ", Tc kimlik numarası: " + tcNo);
            //Console.ReadLine();

            #endregion
        }
    }
}

