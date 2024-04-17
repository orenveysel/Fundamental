using Bogus;
using System.Text.RegularExpressions;

namespace _15_HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Math sinifinin metodlari

            //Console.WriteLine(Math.PI);

            //// Mutlak deger alma
            //Console.WriteLine(Math.Abs(-12));

            //// Verilen ondalikli sayiyi asagi yuvarlama
            //Console.WriteLine(Math.Floor(12.99));

            //// Verilen ondalikli sayiyi yukari yuvarlama
            //Console.WriteLine(Math.Ceiling(12.01));
            //Console.WriteLine("****Round****");

            //// Round metodu verilen ondalikli sayiyi tek ve cift olma durumuna gore yuvarlar
            //// Eger cift ise asagi, tek ise yukari yuvarlar
            //Console.WriteLine(Math.Round(48.50));
            //Console.WriteLine(Math.Round(49.50));

            //// Truncate metodu ondalikli sayinin ondalik kismini atar
            //Console.WriteLine(Math.Truncate(48.75));

            //// Verilen sayinin kuvvetini almak
            //Console.WriteLine("Power => " + Math.Pow(2, 4));

            //// Karekokunu alma
            //Console.WriteLine("Karekok => " + Math.Sqrt(5));

            //// Kupkokunu alma
            //Console.WriteLine("Kupkok => " + Math.Pow(8, 1 / (double)3));

            //// Verilen sayinin isaretini alma
            //// Eger sayi negatif ise -1, pozitif ise +1 verecektir
            //Console.WriteLine("Sign => " + Math.Sign(-3));
            //Console.WriteLine("Sign => " + Math.Sign(0));
            //Console.WriteLine("Sign => " + Math.Sign(3));
            //// Max, Min
            //Console.WriteLine("Max => " + Math.Max(3, 5));
            //Console.WriteLine("Min => " + Math.Min(3, Math.Min(7, 8)));


            #endregion

            #region string metodlari

            // Elimizdeki metinsel degerleri manipulasyonunda hazir olarak kullanacagimiz bir cok metod
            // .NET altyapisinde mevcuttur

            //string cumle = "Buna göre kahvehane, kafeterya, pastane, hazır yemek şirketleri dahil lokantalarda " +
            //    "KDV oranı yüzde 8'den yüzde 10'a çıkacak. Gazino, bar, dans salonu, pavyon, taverna, birahane " +
            //    "gibi yerlerde verilen hizmetlere uygulanan KDV oranı da yüzde 18'den yüzde 20'ye yükseltilecek. " +
            //    "Tebliğ taslağı görüşlerin alınmasının ardından Resmi Gazete'de yayınlandığı tarihte yürürlüğe " +
            //    "girecek.";

            #region CompareTo

            // CompareTo > Elimizdeki string ifadeyi verilen string ile karsilastirir

            //string test = "Ali veli ayse";
            //string test2 = "Ali veli";
            //int deger = test.CompareTo(test2);
            //string mesaj = "";
            //switch (deger)
            //{
            //    case -1:
            //        mesaj = "Verilen kelime digeri ile eslesmemistir";
            //        break;
            //    case 0:
            //        mesaj = "Kelimeler esittir";
            //        break;
            //    case 1:
            //        mesaj = "Fazla kelime var";
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(mesaj); 

            #endregion

            #region Contains

            // Verilen ifade elimizdeki string icerisinde var mi yok mu ona bakar
            // Buyuk/kucuk harfe duyarlidir

            //string cumle = "Bugun gunlerden carsamba";
            //bool varmi = cumle.Contains("Bugun");
            //Console.WriteLine("Aradiginiz kelime " + (varmi ? "bulunmaktadir" : "bulunmamaktadir"));

            #endregion

            #region StartWith EndWith

            // Girilen deger ile elimizdeki string baslayip baslamadigini kontrol eder
            // Geriye bool deger doner

            //string cumle = "Bugun gunlerden carsamba";
            //bool varmi = cumle.StartsWith("Yarin");
            //Console.WriteLine("Cumle Bugun ile " + (varmi ? "baslamaktadir" : "baslamamaktadir"));

            //varmi = cumle.EndsWith("carsamba");
            //Console.WriteLine("Cumle carsamba ile " + (varmi ? "bitmektedir" : "bitmemektedir"));

            #endregion

            #region Remove

            // 1. Kullanimi

            //string yeniCumle = cumle.Remove(11);
            //Console.WriteLine(yeniCumle);
            //Console.WriteLine(cumle);

            // 2. Kullanimi

            //yeniCumle = cumle.Remove(10, 10);
            //Console.WriteLine(cumle);
            //Console.WriteLine(yeniCumle);

            #endregion

            #region Split

            // Split elimizdeki string'i parcalamaya yarar
            // Neye gore parcalanacagi ise metod'a parametre olarak gecilir

            //var sonuc = cumle.Split(',');
            //foreach (string s in sonuc)
            //{
            //    Console.WriteLine(s);
            //}

            // Paragraftaki cumle sayisini bulma

            //var cumleler = cumle.Split('.');
            //foreach (var item in cumleler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Replace

            // Verilen kelime ya da karakteri elindeki string icerisinde arar bulur ve degistirir

            //var yeniCumle = cumle.Replace("dans", "*****");
            //Console.WriteLine(yeniCumle);

            // *****ODEV****** Cumle icerisinde asagidaki blaclist icerisindeki kelimeler yerine **** bastirilsin

            //List<string> blacklist = new List<string>();
            //blacklist.Add("bar");
            //blacklist.Add("dans");
            //blacklist.Add("pastane");
            //blacklist.Add("gazino");
            //blacklist.Add("pavyon");
            //blacklist.Add("taverna");

            //string[] kelimeler = cumle.Split(' ', '.', ',', '!', '?', ':', ';');

            //foreach (string kelime in kelimeler)
            //{
            //    string yeniKelime = kelime;
            //    if (blacklist.Contains(kelime.ToLower()))
            //    {
            //        yeniKelime = new string("******");
            //    }
            //    Console.Write(yeniKelime + " ");
            //}

            #endregion

            #region Substring

            // Elimizdeki metin icerisinde verilen sayidan baslayarak diger verilen sayi kadar olan kismi bize verir

            //string substr = cumle.Substring(10);
            //Console.WriteLine(substr);
            //substr = cumle.Substring(10, 10);
            //Console.WriteLine(substr);


            #endregion

            #region Trim

            //string str = "            elimizdeki metin icerisindeki bosluklari siler            ";
            //Console.WriteLine(str.TrimStart());
            //Console.WriteLine(str.TrimEnd());
            //Console.WriteLine(str.Trim());

            #endregion

            #region Char islemleri

            //char ch = 'A';
            //Console.WriteLine(Char.IsLower(ch)); // Kucuk harf olup olmadigini kontrol eder
            //Console.WriteLine(Char.IsUpper(ch)); // Buyuk harf olup olmadigini kontrol eder

            //Console.WriteLine(Char.IsNumber(ch)); // Sayi olup olmadigini kontrol eder
            //Console.WriteLine(Char.IsDigit(ch)); // Decimal digit olup olmadigini kontrol eder
            //Console.WriteLine(Char.IsWhiteSpace(ch)); // Bosluk olup olmadigini kontrol eder

            // string ifadeler aslinda char dizisidir. Foreach ile donulebilir

            //foreach (char c in cumle)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Odevler

            // Odev elimizdeki kodu "Kasa-002" seklinde yazmak isdigit + isnumber kullanilabilir

            //string kod = "Kasa-001";
            //int sayi = 0;
            //string sayiString = "";
            //foreach (char c in kod)
            //{
            //    if (Char.IsNumber(c))
            //    {
            //        Console.WriteLine(c);
            //        sayiString += c;
            //    }
            //}
            //sayi = int.Parse(sayiString) + 1;
            //string yeniKod = kod.Substring(0, kod.Length - sayiString.Length) + sayi.ToString("D" + sayiString.Length);
            //Console.WriteLine(yeniKod);

            // Ekran Ciktisi *e*i* seklinde yazdiralim

            //string kizlikSoyadi = "Demir";
            //var yeniCumle = kizlikSoyadi.Replace(kizlikSoyadi[0], '*')
            //    .Replace(kizlikSoyadi[2], '*')
            //    .Replace(kizlikSoyadi[4], '*');
            //Console.WriteLine(yeniCumle);


            // TcNo'nun son 4 hanesini ekrana yazdirin

            //string tcno = "12345678912";
            //string substr = tcno.Substring((tcno.Length - 4), 4);
            //Console.WriteLine(substr);

            #endregion

            #endregion

            #region DateTime metodlari

            // DATETIME => Zamanla ilgili yapabileceginiz tum islemleri ve tum verileri size teslim eden nesnemizdir...

            // Bulundugumuz ani veren metod

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(DateTime.Now.ToLongDateString()); // Ay ve Gun isimlerini verir
            //Console.WriteLine(DateTime.Now.ToLongTimeString()); // Zamani verir
            //Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanin gununu verir
            //Console.WriteLine(DateTime.Now.DayOfYear); // Yilin gununu verir

            // Artik yil

            //Console.WriteLine(DateTime.IsLeapYear(2024)==true?"2024 Subat ayi 29 gundur":"2021 Subat ayi 28 gundur");

            // Iki zaman dilimi arasindaki fark

            //DateTime dtrh = new DateTime(1999, 3, 31);
            //DateTime bugun = DateTime.Now;

            //TimeSpan zamanfarki = bugun - dtrh;
            //Console.WriteLine("Omer Faruk");
            //Console.WriteLine(zamanfarki.TotalDays + " gundur yasıyor");
            //Console.WriteLine(zamanfarki.TotalHours + " saattir yasıyor");

            //for (long i = 0; i < 1000000000; i++)
            //{

            //}

            //DateTime suan = DateTime.Now;

            //zamanfarki = suan - bugun;
            //Console.WriteLine($"Dongu suresi: {zamanfarki.TotalMilliseconds} milisaniyedir");

            #endregion

            #region File Create

            //List<string> isimler = new List<string>();
            //List<string> sehirler = new List<string>();
            //List<string> emails = new List<string>();

            //Faker faker = new Faker("tr");
            //for (int i = 0; i < 100; i++)
            //{
            //    isimler.Add(faker.Name.FullName());
            //    sehirler.Add(faker.Address.City());
            //    emails.Add(faker.Person.Email);
            //}

            // Dosya olusturmak icin
            #region Escape Karakterler
            //\' – Output a Single quote.
            //\” – Output a double quote.
            //\ – Output a Backslash.
            //\n – Insert a newline.
            //\r – Insert a carriage -return.
            //\t – Insert a tab.
            //\0 – Insert a null character.
            //\b – Insert a backspace. 
            #endregion

            //FileStream writer = File.Create("Kisiler2.csv"); // Dosya olusturmaya yarar
            //StreamWriter streamWriter = new StreamWriter(writer); // Hafizadaki bilgiyi dosyaya yazdirir

            //streamWriter.WriteLine("Ad Soyad\tSehir\tEmail"); // 
            //for (int i = 0; i < 100; i++)
            //{
            //    streamWriter.WriteLine($"{isimler[i].ToString()};{sehirler[i].ToString()};{emails[i].ToString()}");
            //}
            //streamWriter.Close();
            //streamWriter.Dispose();
            //writer.Close();
            #endregion

            #region File Read
            //string fileName = "Kisiler2.csv";
            //FileStream fs;
            //StreamReader sr;
            //try
            //{
            //    if (File.Exists(fileName))
            //    {
            //        fs = File.OpenRead(fileName);
            //        sr = new StreamReader(fs);

            //        string satir = "";
            //        int sayac = 0;
            //        while ((satir = sr.ReadLine()) != null)
            //        {
            //            string[] alanlar = satir.Split(";");
            //            if (sayac > 0)
            //            {
            //                Console.WriteLine($" {alanlar[0]}\t{alanlar[1]}\t{alanlar[2]}");
            //            }
            //            sayac++;
            //        }
            //        sr.Close();
            //        fs.Close();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dosya Mevcut Degildir");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //finally
            //{
            //    // sr.Close();
            //}

            #endregion

            string fileName = "SampleFile.csv";
            FileStream fs;
            StreamReader sr;
            try
            {
                if (File.Exists(fileName))
                {
                    fs = File.OpenRead(fileName);
                    sr = new StreamReader(fs);

                    string satir = "";
                    int sayac = 0;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        string[] alanlar = satir.Split(",");
                        if (sayac > 0)
                        {
                            Console.WriteLine($"{alanlar[0]}\t{alanlar[1]}\t{alanlar[2]}\t{alanlar[3]}\t{alanlar[4]}\t{alanlar[5]}\t{alanlar[6]}");
                        }
                        sayac++;
                    }
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    Console.WriteLine("Dosya Mevcut Degildir");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // sr.Close();
            }

        }
        public static void Beklet()
        {
            for (int i = 0; i < 100; i++)
            {

            }
        }
    }
}
