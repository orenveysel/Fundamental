using System.Collections;

namespace _13_ArraySinifiVeListeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 12, 3, 9, 4, 21, 0, 49, 32 };

            // Dizileri siralama ve diger operasyonlar icin Array Sinifi kullanilir

            #region Siralama
            // Siralamak icin short metodunu kullanabiliriz
            //Array.Sort(sayilar);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //} 
            #endregion

            #region Dizi boyutunu arttirma Array Sinifi

            #region Manuel Yontem
            //Console.WriteLine("Yeni dizi boyutunu giriniz: ");
            //int boyut  = int.Parse(Console.ReadLine());

            //int[] yeniDizi = new int[boyut];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    yeniDizi[i] = sayilar[i];
            //}
            //for (int i = 0; i < yeniDizi.Length; i++)
            //{
            //    Console.WriteLine(yeniDizi[i]);
            //} 
            #endregion

            Array.Resize(ref sayilar, 15);
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //}
            string[] sehirler = new string[4] { "Izmir", "Istanbul", "Ankara", "Eskisehir" };

            //Array.Reverse(sehirler);
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Clear(sayilar);
            //Array.Clear(sayilar,3,2);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region ArrayList

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(3); // integer
            //arrayList.Add("Ali"); // string
            //arrayList.Add(DateTime.Now); // dateTime

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            #endregion

            #region Listeler

            List<int> notlar = new List<int>();
            Random rnd = new Random();
            int gelenDeger = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    gelenDeger = rnd.Next(100);
            //    Console.WriteLine(gelenDeger);
            //    notlar.Add(gelenDeger);
            //}
            //notlar.Sort();

            //foreach (int i in notlar)
            //{
            //    Console.WriteLine(i);
            //}
            List<string> isimler = new List<string>();
            List<string> isimler2 = new List<string>() { "Ali", "Veli", "Ayse", "Fatma" };
            List<string> isimler3 = new List<string> { "Ali", "Veli", "Ayse", "Fatma" };


            List<DateTime> dateTimes = new List<DateTime>();
            List<bool> bools = new List<bool>();
            //foreach (var item in isimler3)
            //{
            //    Console.WriteLine(item);
            //}
            //isimler3.ForEach(s =>Console.WriteLine(s));

            // Listeden eleman cikartmak icin kullanilir
            isimler3.Remove("Ayse");
            //foreach (var item in isimler3)
            //{
            //    Console.WriteLine(item);
            //}

            //Belirli bir indexdeki elemani listeden atmaya yarar
            isimler2.RemoveAt(0);
            //foreach (var item in isimler2)
            //{
            //    Console.WriteLine(item);
            //}

            #region Contains
            // Listede belirli bir arama yapmaya yarar
            // 1. Yontem normal versiyon
            //bool varmi = isimler2.Contains("Ayse");

            //if (varmi)
            //{
            //    Console.WriteLine("Ayse Listede mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Listede yok");
            //}
            //// 2. Yontem Ternary if ile
            //string sonuc = isimler2.Contains("Ayse") ? "Ayse Listede mevcut" : "Listede yok";

            ////3. Yontem En Kisa olani
            //Console.WriteLine(isimler2.Contains("Ayse") ? "Ayse Listede mevcut" : "Listede yok"); 
            #endregion

            #region CopyTo
            //string[] yeniIsımler = new string[0];
            // Bu tum listeyi diziye aktarir
            //isimler2.CopyTo(yeniIsımler);
            // Bu dizideki 2. elemandan itibaren listeyi kopyalar
            //isimler2.CopyTo(yeniIsımler, 2);

            // isimler2 listesinde 1. index'ten baslayarak yeniIsimler dizisinde
            // 0. indexten itibaren 2 adet kopyalama yapar
            //isimler2.CopyTo(1, yeniIsımler, 2, 2);
            #endregion


            #endregion
            //Console.WriteLine("Hello, World!");
        }
    }
}
