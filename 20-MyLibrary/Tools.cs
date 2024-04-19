using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MyLibrary
{
    public class Tools
    {
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

        public static int UstelFonksiyon(int a, int b)
        {
            int sonuc = 1;
            for (int i = 1; i <= b; i++)
            {
                sonuc *= a;
            }
            return sonuc;
        }

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


    }
}
