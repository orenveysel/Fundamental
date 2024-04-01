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

            //----------------------------------------

            #region Degisken Tanimlama Kurallari
            /*
            sayı ile baslayamaz
            _ haric özel karakter içeremez
            255 karakterden büyük olamaz
            kelimeler arası boşluk bırakılamaz
            Microsoft PascalCase kullanılır

            */
            #endregion
            /*
            string ad, soyad, tcNo;
            Console.WriteLine("Adınızı giriniz: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Tc kimlik numaranızı giriniz: ");
            tcNo = Console.ReadLine();

            Console.WriteLine("Bilgileri girilen kişinin adı: " + ad + ", soyadı: " + soyad + ", Tc kimlik numarası: " + tcNo);
            Console.ReadLine();
            */

        }
    }
}

