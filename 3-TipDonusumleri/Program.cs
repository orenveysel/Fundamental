using System.Globalization;

namespace _3_TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir veri tipindeki degiskeni diger bir veri tipine cevirmek icin ihtiyacimiz olan yardimci bir sinifimiz vardir
            // Convert Sinifi ihtiyacimiz olan gerekli donusumleri yapacak metodlara sahiptir

            byte byteSayi=255; // burasi 1 byte yani en fazla 256'ya kadar destekler
            float floatSayi;
            double doubleSayi;
            decimal decimalSayi;
            long longSayi;
            string strDeger = "323";
            // Yukaridaki string tipindeki degiskenin degerini int yapmak istersek
            // 1. yol
            int sayi = Convert.ToInt32(strDeger);
            // 2. yol
            // veri tiplerinin metodlari arasinda her zaman Parse metodu vardir
            sayi = int.Parse(strDeger);
            Console.WriteLine("Cevirilen Deger: " + sayi);

            // Taşma Durumlari 4 byte'lik veri tipi 1 byte'lik veri tipine cevrilemez, hata verecektir
            //byteSayi = Convert.ToByte(sayi);
            //Console.WriteLine(byteSayi);

            #region Sayisal Tip Cevrimleri
            // Kucuk veri tipinden Buyuk Veri tipine gecis mumkun iken tersi geçerli degildir.
            //sayi = Convert.ToInt32(byteSayi);
            //Console.WriteLine("Sayi:" + sayi);
            //floatSayi = Convert.ToSingle(byteSayi);
            //Console.WriteLine("Float Sayi:" + floatSayi);
            //decimalSayi = Convert.ToDecimal(byteSayi);
            //Console.WriteLine("Decimal Sayi:" + floatSayi);
            //longSayi = Convert.ToInt64(byteSayi);
            //Console.WriteLine("long Sayi:" + floatSayi); 
            #endregion

            #region Date Veri Tipi Cevrimi
            //DateTime? date;
            //string str;
            //date = Convert.ToDateTime("2000.12.22");
            //str = date.ToString();
            //Console.WriteLine(date.ToString());
            //date = Convert.ToDateTime("2000/12/22");
            //Console.WriteLine(date);
            //date = null;
            //date = Convert.ToDateTime("12/22/2000");
            //Console.WriteLine(date);
            //var sonuc = Convert.IsDBNull(date);
            //Console.WriteLine(sonuc); 
            // DateTime trh = DateTime.Parse("01.01.2000");

            #endregion
            #region ToString() Metodu
            decimal value = 123.456m;
            Console.WriteLine(value.ToString("C2"));

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            string dateInfo = now.ToString("MM/dd/yyyy");
            Console.WriteLine(dateInfo);
            Console.WriteLine(now.ToString("yyyy.MM.dd"));
            Console.WriteLine(now.ToString("D"));
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine(now.ToString("T"));

            decimal price = 1000m;
            string priceInUS = price.ToString("C", new CultureInfo("en-US")); //"$1,000.00"
            string priceInGermany = price.ToString("C", new CultureInfo("de-DE")); // "1.000,00 €"
            string priceInTurkish = price.ToString("C", CultureInfo.GetCultureInfo("tr-TR"));
            Console.WriteLine(priceInUS);
            Console.WriteLine(priceInGermany);
            Console.WriteLine(priceInTurkish);


            string _GunuVer_TR = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];
            Console.WriteLine(_GunuVer_TR);
            string _GunuVer_DE = CultureInfo.GetCultureInfo("de-DE").DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];
            Console.WriteLine(_GunuVer_DE);
            #endregion




        }
    }
}
