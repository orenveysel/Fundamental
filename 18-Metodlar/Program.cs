namespace _18_Metodlar
{
    public struct Kayit
    {
        public int Id;
        public string Name;
        public string Description;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> kayitListesi = new List<Kayit>();

            //f(x) = x + x;
            //f(x, y) = x + y;

            /*
              
              C#’ta bir metot, belirli bir işlevi yerine getirmek için kullanılan bir kod bloğudur. 
              Metotlar, bir veya daha fazla parametre alabilir, bir değer döndürebilir veya belirli bir işi gerçekleştirebilir. 
              Metotlar, kodun tekrar kullanılabilirliğini sağlar, kodun okunabilirliğini artırır 
              ve programları daha modüler hale getirir.
              
              Ayni isimde Metod aldigi parametreler de ayni ise tanimlanamaz.
              Ancak aldigi paremetre ya da parametreler farkli ise ayni isimde Metod tanimlanabilir.
              Buna AşırıYukleme Denir. (Overloading)
              
               
              Geriye deger donen fonsksiyonlar => Metod da denir
              Geriye herhangi bir deger donmeyen metodlar
               
              
              GeriDonusTipi MetodAdi(aldigi parametreler)
              
              [erişim_belirteci] [geri_dönüş_tipi] [metot_adı]([parametreler])
                {
                    // Metot gövdesi (işlemler)
                    // İsteğe bağlı olarak bir değer döndürme
                }

              
             */

            //int sayi1 = SayiOku("Birinci sayiyi giriniz: ");
            //int sayi2 = SayiOku("İkinci sayiyi giriniz: ");

            //Console.WriteLine("Toplam: " + Topla(sayi1, sayi2));
            int toplam1 = Topla(1, 2, 3, 4, 5);
            int toplam2 = Topla(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine("Hello, World!");

            int carpim = Carpma(3, 5);
            int bolum = Bolme(15, 10);
            int cikarma = Cikarma(8, 5);
            Console.WriteLine($"Carpma sonucu: {carpim}\nBolme sonucu: {bolum}\nCikarma sonucu: {cikarma}");
            string kelimeler = Birlestirme("ali", "ayse");
            Console.WriteLine(kelimeler);
            bool sayi = TekCift(5);
            Console.WriteLine(sayi ? "Cift sayidir":"Tek sayidir"); // Ternary Operator
            int sayi5 = SayiGir();


        }

        // Carpma, Bolme, Cikartma Parametre olarak iki adet integer sayi alsin

        #region Carpma, Bolme, Cikarma
        public static int Carpma(params int[] sayilar)
        {
            int carpim = 1;
            for (int i = 0; i < sayilar.Length; i++)
            {
                carpim *= sayilar[i];
            }
            return carpim;
        }
        public static int Bolme(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
        public static int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        #endregion

        // Verilen iki kelimeyi birlestirip geri donen Metod
        #region Verilen iki kelimeyi birlestirme
        public static string Birlestirme(string kelime1, string kelime2)
        {
            return kelime1 + kelime2;
        }
        #endregion

        // verilen sayinin tek mi cift mi oldugunu bool /true/false olarak geri donen metod
        #region Tek Cift Kontrol
        public static bool TekCift(int sayi) // cift ise true donecektir
        {
            return (sayi % 2 == 0);// dogruysa true doner degilse false doner,
                                   // return (sayi % 2 == 0) ? true : false; bu kullanima gerek yoktur
        }
        #endregion

        // Login Metodu yapalim. Parametre olarak username ve password alsin
        // username ="admin" password = "123" ise true degilse false donsun
        #region Login Kontrol
        public static bool Login(string username, string password)
        {
            bool giris;
            string usernamee = "admin";
            string passwordd = "123";
            if (usernamee == username && password == password)
            {
                giris = true;
            }
            else
            {
                giris = false;
            }
            return giris;
        }
        #endregion

        // Ekrandan duzgun sayi girene kadar kullanicidan giris isteyen metod
        #region Sayi girene kadar giris isteme
        public static int SayiGir()
        {
            string mesaj = "Bir sayi giriniz: ";
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
        public static void KayitGoster(Kayit kayit)
        {
            Console.WriteLine(kayit.Id + " " + kayit.Name + " " + kayit.Description);
        }

        public static void KayitlariGoster(List<Kayit> kaytListesi)
        {

        }
        // Kullanicidan bir sayi okutup geri donen Metod => SayiOku()
        static int SayiOku(string mesaj)
        {
            Console.WriteLine(mesaj);
            int sayi = int.Parse(Console.ReadLine());
            return sayi;
        }

        //Geriye Deger Donmeyen Metod
        //public static void Topla(long a, long b)
        //{
        //    Console.WriteLine($"Toplam: {a + b}");
        //}

        //public static int Topla(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Topla(byte a, int b)
        //{
        //    return a + b;
        //}

        //public static int Topla(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //public static int Topla(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}

        //public static int Topla(int a, int b, int c, int d, int e)
        //{
        //    return a + b + c + d + e;
        //}

        // Girilen parametrelerin sayisinin belli olmadigi durumlarda params kullanilir.
        // Paramas her zaman en sonda olmak zorundadir.
        public static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

        // Paramas her zaman en son parametre olmak zorundadir.
        public static int Topla(string mesaj, long sayi, decimal[] qwe, params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

    }
}
