namespace _19_MetodlarLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Odev Ciktilari
            //Console.WriteLine(MutlakDeger(-34)); // Odev 1 ciktisi

            //Console.WriteLine(UstelFonksiyon(2, 4)); // Odev 2 ciktisi

            //double x1, x2; // Odev 3 ciktisi
            //Console.WriteLine("ax²+bx+c denkleminin katsayilarini giriniz.a: b: c: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //KokBulma(a, b, c, out x1, out x2);

            #endregion

            Console.WriteLine("Hello, World!");
            //UrunFiyatHesapla();
            //OrtalamaHiz();
            NotOrtalamasi();
        }
        #region Odevler
        // 1- Verilen sayinin mutlak degerini alan metod
        static string MutlakDeger(int sayi)
        {
            switch (sayi < 0 ? -1 : (sayi == 0 ? 0 : 1))
            {
                case -1:
                    return $"{sayi} sayısının mutlak değeri: {-sayi}";
                case 0:
                    return $"{sayi} sayısının mutlak değeri: {0}";
                case 1:
                    return $"{sayi} sayısının mutlak değeri: {sayi}";
                default:
                    return "Geçersiz sayı";
            }
        }

        // 2- Verilen sayinin ikinci verilen sayiya gore üssünü alan metod
        public static int UstelFonksiyon(int a, int b)
        {
            int sonuc = 1;
            for (int i = 1; i <= b; i++)
            {
                sonuc *= a;
            }
            return sonuc;
        }

        // 3- Katsayilari verilen ikinci derece denklemin koklerini yazdiran metod
        // b2-4ac 
        public static void KokBulma(int a, int b, int c, out double x1, out double x2)
        {
            double delta = (Math.Pow(b, 2) - (4 * a * c));
            if (delta > 0)
            {
                x1 = ((-b) + (Math.Sqrt(delta)) / (2 * a));
                x2 = ((-b) - (Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("X1=" + x1 + "\tX2=" + x2);
            }
            else if (delta == 0)
            {
                x1 = -(b / (2 * a));
                x2 = x1;
                Console.WriteLine("Çakışık iki kök vardir. X1=X2=" + x2);
            }
            else
            {
                x1 = 0; x2 = 0;
                Console.WriteLine("Reel Kok Yok");
            }
        }

        #endregion

        #region Ortalama Hiz
        public static void OrtalamaHiz()
        {
            float yol, sure, ortalamaHiz;
            yol = SayiGir("Aracin gittigi yol mesafesini giriniz(kilometre): ");
            sure = SayiGir("Aracin yolu ne kadar surede gittigini giriniz(dakika): ");
            sure = sure / 60;
            Console.WriteLine(sure);
            float ortalamahiz = yol / sure;
            Console.WriteLine($"Aracin ortalama hizi: {ortalamahiz} km/saat'tir!");
        }
        #endregion

        #region Not Ortalamasi

        public static void NotOrtalamasi()
        {
            float vize1, vize2, vizeOrtalama, final, genelOrtalama;
            bool gectiMi;
            vize1 = SayiGir("1. Vize notunu giriniz: ");
            vize2 = SayiGir("2. Vize notunu giriniz: ");
            final = SayiGir("Final notunu giriniz: ");
            vizeOrtalama = (vize1 + vize2) / 2;
            genelOrtalama = (vizeOrtalama * (0.3f)) + (final * (0.7f));
            Console.WriteLine($"Genel not ortalamaniz: {genelOrtalama:F2}");
            //Console.WriteLine("Genel not ortalamaniz: {0:F2}",genelOrtalama);
            Console.WriteLine(genelOrtalama >= 50 ? "Dersi gectiniz!" : "Dersten kaldiniz!");
        }

        #endregion

        #region Urun Fiyat Hesapla
        public static void UrunFiyatHesapla()
        {
            int fiyat, indirimOrani;
            float kdv, hesaplananFiyat;
            fiyat = SayiGir("Urun fiyatini giriniz: ");
            indirimOrani = SayiGir("Indirim oranini giriniz: ");
            hesaplananFiyat = fiyat * indirimOrani / (float)100;
            Console.WriteLine("Indirilecek tutar: " + hesaplananFiyat);
            kdv = (fiyat - hesaplananFiyat) * (0.2f);
            Console.WriteLine("Kdv'si: " + kdv);
            Console.WriteLine("Urunun kdv'li fiyati: " + ((fiyat - hesaplananFiyat) + kdv));
        }
        #endregion

        #region Sayi Gir
        public static int SayiGir(string mesaj)
        {
            string hata = "Yanlis format!";
            int sayi;
            bool sayiMi;

            do
            {
                Console.WriteLine(mesaj);
                sayiMi = int.TryParse(Console.ReadLine(), out sayi);
                if (!sayiMi)
                {
                    Console.WriteLine(hata);
                }
            } while (!sayiMi);

            return sayi;
        } 
        #endregion
    }
}
