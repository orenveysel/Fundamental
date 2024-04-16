namespace _9_OdevCozumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 0-100 arasindaki uce  ve yediye bolunenlerin toplamini ekrana yaziniz
            //int toplam = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam); 
            #endregion

            #region Klavyeden girilen  sayiya kadar olan fibanocci sayilarini listeleyiniz
            //int fibo, oldFibo, print, sayac;
            //print = 0;
            //fibo = 1;
            //oldFibo = 0;
            //sayac = 0;
            //Console.WriteLine("Bir sayi giriniz: ");
            //int counter = int.Parse(Console.ReadLine()); 

            //do
            //{
            //    for (int i = 1; i <= counter; i++)
            //    {
            //        Console.WriteLine(fibo);
            //        print = oldFibo + fibo;
            //        oldFibo = fibo;
            //        fibo = print;
            //        sayac += 1;

            //    }
            //} while (sayac < counter);

            //while (sayac < counter)
            //{
            //    for (int i = 1; i <= counter; i++)
            //    {
            //        Console.WriteLine(fibo);
            //        print = oldFibo + fibo;
            //        oldFibo = fibo;
            //        fibo = print;
            //        sayac += 1;
            //    }
            //}
            #endregion

            #region Klavyeden girilen sayinin basamaklarini while ile bulunuz
            //Console.Write("Bir sayı giriniz:");
            //string sayi = Console.ReadLine();
            //int sayac = 0;
            //char c;
            //Console.WriteLine($"Girdiğiniz sayı {sayi.Length} basamaklıdır, basamaklar şu şekildedir:");
            //while (sayac < sayi.Length)
            //{
            //    c = sayi[sayac];
            //    Console.WriteLine(c);
            //    sayac++;
            //} 
            #endregion

            #region do-while ile ekrandan 0 girilene kadar sayi okutan donguyu yapiniz
            //int sayi = 0;
            //do
            //{
            //    Console.WriteLine("Bir sayi giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());
            //} while (sayi != 0); 
            #endregion

            #region Kullanicidan istenecek sayilarin toplami 100 veya uzeri olana kadar sayi girmeye devam ettirecek dongu
            //int sayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Bir sayi giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    Console.WriteLine($"Sayilarin toplami: {toplam}");
            //} while (toplam < 100); 
            #endregion

            #region Kullanicidan alinan iki sayi arasindaki sayilarin kare ve küp toplamlari
            // Kurallar : i--girilen sayilarin birincisi kucuk, ikincisi buyuk olabilir.
            // veya birinci buyuk ikinci kucuk olacak sekilde siraya bagli kalmaksizin veri girebilir. 
            // ii- kullanicin girdigi degerlerin sayi olup olmadigi kontrol edip ekrana uygun mesaj verilecek. VE girilen deger yeniden istenecek
            // iii- Girilen degerler ekrana 3 kolon seklinde basilacak.
            // Sayi Karesi  Küpü
            // iV- Devam etmek istiyormusunuz sorusu sorulacak.Evet derse program devam edecek.Programi sonlandirmak icin hayir yazilacak.

            //string sayi1, sayi2;
            //string cevap;
            //bool devammi = true;
            //do
            //{
            //    int kupToplam = 0, kareToplam = 0;
            //    Console.WriteLine("1. Sayıyı Giriniz: ");
            //    sayi1 = Console.ReadLine();
            //    Console.WriteLine("2.Sayıyı Giriniz: ");
            //    sayi2 = Console.ReadLine();
            //    if ((int.TryParse(sayi1, out int s1)) && (int.TryParse(sayi2, out int s2)))
            //    {
            //        if (s1 >= s2)
            //        {
            //            for (int i = s2 + 1; i < s1; i++)
            //            {
            //                kupToplam += i * i * i;
            //                kareToplam += i * i;
            //            }
            //        }
            //        else if (s2 > s1)
            //        {
            //            for (int i = s2 - 1; i > s1; i--)
            //            {
            //                kupToplam += i * i * i;
            //                kareToplam += i * i;
            //            }
            //        }

            //        Console.WriteLine("Kare \t Küp  ");
            //        Console.WriteLine(kareToplam + "\t" + kupToplam);
            //        Console.WriteLine("-----------------");

            //        Console.WriteLine("Devam Etmek İster misiniz ?  [Evet/Hayır]");
            //        cevap = Console.ReadLine();
            //        if ((cevap == "Hayır") || (cevap == "hayır") || (cevap == "HAYIR"))
            //        {
            //            devammi = false;
            //        }
            //        else
            //        {
            //            devammi = true;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş Hatalı Lütfen Sayi Giriniz...");
            //    }
            //} while (devammi == true);
            #endregion

            #region Bilgisayarin tutugu bir sayiyi tahmin eden oyun
            // Kurallar : Tutlan sayi Araligi 1-100 arasinda olacak.
            // Tahmin hakkini ekran dan alin.Girilen tahmin hakki ladar ekrandan deger okutun.
            // Kullanici yi yönlendirin.Buyuk yada kucuktur diye. Musteri kacmasin .
            // Devam etmek istiyormusunuz sorusu sorulacak.Evet derse program devam edecek.Programi sonlandirmak icin hayir yazilacak.

            Random random = new Random();
            int tutulanSayi = 1 + random.Next(100); // tutulan sayi 0 olabilir. 1-100 arasinda sayi olusumunu garantiye almak icin 
            int tahminHakki = 0;
            bool cevrildimi;

            #region 1. Yontem
            //Tekrar:
            //Console.Write("Tahmin Hakki giriniz:");

            // cevrildimi = int.TryParse(Console.ReadLine(), out tahminHakki);
            //if (!cevrildimi)
            //{
            //    Console.WriteLine("Lutfen Sayisal br deger Giriniz...");
            //    goto Tekrar;
            //} 
            #endregion

            #region 2. Yontem
            //2. yontem
            string devamEtmekIstiyormusunuz = "e";
            do
            {
                #region Tahmin Hakki Bolumu
                do
                {
                    Console.Write("Tahmin Hakki giriniz:");

                    cevrildimi = int.TryParse(Console.ReadLine(), out tahminHakki);
                } while (!cevrildimi);
                #endregion

                bool bayrak = true;
                int girilenSayi = 0;

                #region Sayi Tahmin Oyunu
                do
                {
                    Console.Write($"{tahminHakki}. Tahmini Giriniz:");
                    girilenSayi = int.Parse(Console.ReadLine());

                    if (girilenSayi > tutulanSayi)
                    {
                        Console.WriteLine("Daha Kucuk Bir Sayi Giriniz ");
                    }
                    else if (girilenSayi < tutulanSayi)
                    {
                        Console.WriteLine("Daha Büyük Bir Sayi Giriniz ");
                    }
                    else
                    {
                        Console.WriteLine($"Tebrikler {tahminHakki} . Denemede Bildiniz");
                        bayrak = false;
                    }

                    tahminHakki = tahminHakki - 1;
                    if (tahminHakki == 0)
                    {
                        Console.WriteLine("Tahmin Hakkiniz Bitti..");
                        bayrak = false;
                    }
                } while (bayrak);
                #endregion

                Console.Write("Devam Etmek Istiyormusunuz [E/H]");
                devamEtmekIstiyormusunuz = Console.ReadLine();

            } while (devamEtmekIstiyormusunuz.ToLower() == "e");
            #endregion

            #endregion
        }
    }
}
