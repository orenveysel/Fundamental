namespace _2_IfAndSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatimi
            /*
            - Şartlı Scope çalıştırmak için kullanılır
            - ilk şartı if, ikinci .... n-1 sart
            - else ile biter
            - sadece bir scope çalışır

            - Kısa yol shift + enter scope açmaya yarar 
            - if'de kıyaslama operatoru "=="'tir 
            - ve operatoru && ile ifade edilir, ya da ifadesi || ile
            - if ifadelerinin sonuna ; koymayın

            int suSicakligi;
            string input;
            Console.WriteLine("Suyun sicakligini giriniz: ");
            input = Console.ReadLine();

            suSicakligi = int.Parse(input);
            if (suSicakligi <= 0)
            {
                Console.WriteLine("Su kati haldedir");
            }
            else if (suSicakligi > 0 && suSicakligi < 100)
            {
                Console.WriteLine("Su sivi haldedir");
            }
            else if (suSicakligi > 100)
            {
                Console.WriteLine("Su gaz haldedir");
            }

            */

            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Haftanin Gunleri : Ekrandan 1-7 arasinda bir sayi aliniz

            // Girilen sayiya gore haftanin gununu yazdiriniz
            // Pazar 1. Gun
            /*
            int gun = 0;
            string input;
            Console.WriteLine("Haftanin Gununu giriniz: ");
            input = Console.ReadLine();
            gun = int.Parse(input);

            if (gun == 1)
            {
                Console.WriteLine("Pazar");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Sali");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Carsamba");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Persembe");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cuma");
            }
            else
            {
                Console.WriteLine("Cumartesi");
            }
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Ekrandan okutulan 3 sayinin buyuk olanini bulunuz
            /*
            int sayi1, sayi2, sayi3;
            Console.WriteLine("Birinci sayiyi giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ucuncu sayiyi giriniz: ");
            sayi3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Girilen sayilar {0}, {1}, {2}", sayi1, sayi2, sayi3);


            if (sayi1 > sayi2)
            {
                if (sayi1 > sayi3)
                {
                    Console.WriteLine("Buyuk olan sayi: " + sayi1);
                    Console.WriteLine($"Buyuk olan sayi {sayi1} dir");
                }
                else
                {
                    Console.WriteLine("Buyuk olan sayi: " + sayi3);
                }
            }
            else if (sayi3 > sayi2)
            {
                Console.WriteLine("Buyuk olan sayi: " + sayi3);
            }
            else
            {
                Console.WriteLine("Buyuk olan sayi: " + sayi2);
            }
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region indirim
            //Klavyeden girilen toplam tutar değeri 100’den küçük ise %5, 100 ile 500 arasında ise %10,
            //500’den büyük ise %15 indirim yapıp ödenecek tutarı hesaplayıp ekrana yazdırin
            /*
            int tutar = 0;
            double odenecekTutar = 0;
            string input;
            Console.WriteLine("Birinci sayiyi giriniz: ");
            input = Console.ReadLine();
            tutar = int.Parse(input);

            if (tutar >= 500)
            {
                odenecekTutar = tutar * 0.85;
                Console.WriteLine("Odenecek tutar: " + odenecekTutar);
            }
            else if (tutar >= 100 && tutar < 500)
            {
                odenecekTutar = tutar * 0.90;
                Console.WriteLine("Odenecek tutar: " + odenecekTutar);
            }
            else
            {
                odenecekTutar = tutar * 0.95;
                Console.WriteLine("Odenecek tutar: " + odenecekTutar);
            }
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region  Fatura
            //Aylık elektrik faturası hesaplanacaktır. Kullanıcıdan kaç kWh tükettiğini alınız.
            //Eğer tüketim 150’den küçükse kWh’i 10 tl, eğer 150 ile 300 arasında ise 20 tl, 300 üzeri ise 40 tl olarak hesaplanmaktadır.
            //Kişinin yaptığı tüketime göre faturasının kaç TL olacağını hesaplayıp ekrana yazdırınız.
            /*
            double kWh = 0;
            double fatura = 0;
            Console.WriteLine("Elektrik tuketiminizi kWh cinsinden yaziniz: ");
            kWh = int.Parse(Console.ReadLine());

            if (kWh >= 300)
            {
                fatura = kWh * 40;
                Console.WriteLine("Guncel faturaniz: " + fatura);
            }
            else if (kWh >= 150 && kWh < 300)
            {
                fatura = kWh * 20;
                Console.WriteLine("Guncel faturaniz: " + fatura);
            }
            else
            {
                fatura = kWh * 10;
                Console.WriteLine("Guncel faturaniz: " + fatura);
            }
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Boy Kilo Hesaplama
            /* Klavyeden girilen boy ve cinsiyet  göre kişinin ideal kilosunu aşağıdaki
             * açıklamaya göre hesaplayıp ekrana  
             * İdeal Kilonuz=... şeklinde yazdırınız.
             Kadınlar için: Boyunuzun ilk 150 santimetresi için 45 kilo, 
             sonraki her 2.5 cm için 2.2 kilo ekler.
            Örnek olarak; boyunuz 160 cm ise, ideal kilonuz 45 + 8.8 = 53.8 kilogram olacaktır.
            Erkekler için: Boyunuzun ilk 150 santimetresi için 48 kilo, sonraki 
            her 2.5 cm için 2.7 kilo ekler.
            Örnek olarak boyunuz 180 cm ise, ideal kilonuz 48 + 32.4 = 80.4 kilogram olacaktır. 
            */
            /*
            Console.WriteLine("Lütfen boyunuzu (cm cinsinden) girin:");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen cinsiyetinizi girin (K/E):");
            char cinsiyet = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            double idealKilo = 0;
            double herAdimKilo = 0;

            if (cinsiyet == 'K')
            {
                herAdimKilo = 2.2;
                idealKilo = 45;
            }
            else if (cinsiyet == 'E')
            {
                herAdimKilo = 2.7;
                idealKilo = 48;
            }
            else
            {
                Console.WriteLine("Geçersiz cinsiyet girdisi!");
                return;
            }

            for (double i = 150; i < boy; i += 2.5)
            {
                idealKilo += herAdimKilo;
            }

            Console.WriteLine($"İdeal Kilonuz: {idealKilo:F1} kilogram");
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            #region Vize Final Hesaplama
            /*
             *  Bir öğrenciye ait 2 vize notunun ve 1 final  ortalamasını hesaplayan ve (vizenin %30 Finalin %70 i alinacak)
             *  ortalama 50’den küçükse ekrana “kaldı” büyükse “geçti” yazan programı yazınız.
             * 
             */
            /*
            Console.WriteLine("vize 1:");
            int vize1 = int.Parse(Console.ReadLine());
            Console.WriteLine("vize 2:");
            int vize2 = int.Parse(Console.ReadLine());
            Console.WriteLine("final:");
            int final = int.Parse(Console.ReadLine());
            var total = (((vize1 + vize2) / 2) * 0.3) + (final * 0.7);

            string sonuc = total > 50 ? "geçti" : "Kaldı";
            Console.WriteLine(sonuc);
            */
            #endregion

            //------------------------------------------------------------------------------------------------------------------

            var doublesayi = 5.0;
            float sayi = 5.0f;
            decimal decimal2 = 5.0m;

            #region SwitchCase Konu Anlatimi 
            /*
            * Bir degeri dinleyerek 2 den cok scope dallanmasini yonetir.
            * if'ten farki indexlemesi ve dallara daha hizli erismesini saglar. Daha performanslidir.
            * Eger Aylarin kontrolu  gibi birden cok kontrol yapilacaksa switch case ifade kulanilmasi uygundur.
            * */

            Console.WriteLine("Ayin Numarasini giriniz");
            var giris = Console.ReadLine();
            int ay = int.Parse(giris);
            bool flag = false;
            int sayi2 = 55;
            if (ay == 1)
            {
                Console.WriteLine("Ocak");
            }
            else if (ay == 2)
            {
                Console.WriteLine("Subat");
            }
            else if (ay == 3)
            {
                Console.WriteLine("Mart");
            }
            else if (ay == 4)
            {
                Console.WriteLine("Nisan");
            }
            else if (ay == 5)
            {
                Console.WriteLine("Mayis");
            }
            else if (ay == 6)
            {
                Console.WriteLine("Haziran");
            }
            else if (ay == 7)
            {
                Console.WriteLine("Temmuz");
            }
            else if (ay == 8)
            {
                Console.WriteLine("Agustos");
            }
            else if (ay == 9)
            {
                Console.WriteLine("Eylul");
            }
            else if (ay == 10)
            {
                Console.WriteLine("Ekim");
            }
            else if (ay == 11)
            {
                Console.WriteLine("Kasim");
            }
            else if (ay == 12)
            {
                Console.WriteLine("Aralik");
            }

            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak");

                    break;
                case 2://when (flag == true) && sayi2 == 55:
                    Console.WriteLine("Subat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayis");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("agustos");
                    break;
                case 9:
                    Console.WriteLine("Eylul");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasim");
                    break;
                case 12:
                    Console.WriteLine("Aralik");
                    break;
                default:
                    Console.WriteLine("Girilen Deger Aralik Disidir");
                    break;
            }

            #region Odev
            /*
            * Hesaplama Uygulamasina Hosgeldiniz
            * 1-Toplama
            * 2-Cikarma
            * 3-Çarpma
            * 4-Bölme
            * Lutfen yapmak istediginiz ilemi seciniz:2
            * 1. Sayiyi giriniz: 5
            * 2. Sayiyi Giriniz :3
            * Sonuc = 5-2 =3
            */
            #endregion

        #endregion

        }
    }
}
