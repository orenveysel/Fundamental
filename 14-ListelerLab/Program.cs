using Bogus;
namespace _14_ListelerLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Isimler listesi, Sehirler listesi, Adresler listesi
            var faker = new Faker("tr");
            List<string> sehirler = new List<string>();
            List<string> isimler = new List<string>();
            List<DateTime> dogumGunleri = new List<DateTime>();
            // faker.Person.DateOfBirth
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    isimler.Add(faker.Name.FullName(Bogus.DataSets.Name.Gender.Female));
                    dogumGunleri.Add(faker.Person.DateOfBirth);
                    sehirler.Add(faker.Address.City());
                }
                else
                {
                    isimler.Add(faker.Name.FullName(Bogus.DataSets.Name.Gender.Male));
                    dogumGunleri.Add(faker.Date.Between(DateTime.Now.AddYears(-30),DateTime.Now.AddYears(-20)));
                    sehirler.Add(faker.Address.City());
                }
            }

            
            #region Listeleri Ekrana Bastirma
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i] + " => " + dogumGunleri[i] + " => " + sehirler[i]);
            }
            #endregion


            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}


            #region Sehirler ile ilgili listelemeler

            //Console.WriteLine("**************Sehirler***************");

            //sehirler.Sort();
            //List<string> tekilSehirler = new List<string>();

            //List<string> marmaraBolgesi = new List<string>();
            //marmaraBolgesi.Add("Bursa");
            //marmaraBolgesi.Add("Çanakkale");
            //marmaraBolgesi.Add("İstanbul");
            //marmaraBolgesi.Add("Edirne");
            //marmaraBolgesi.Add("Tekirdağ");
            //marmaraBolgesi.Add("Kırklareli");
            //marmaraBolgesi.Add("Balıkesir");
            //marmaraBolgesi.Add("Yalova");
            //marmaraBolgesi.Add("Sakarya");
            //marmaraBolgesi.Add("Kocaeli");



            //foreach (var sehir in sehirler)
            //{
            //    if (!tekilSehirler.Contains(sehir))
            //    {
            //        tekilSehirler.Add(sehir);
            //    }
            //    //Console.WriteLine(sehir);
            //}
            //int index = 1;
            //foreach (var sehir in tekilSehirler)
            //{
            //    if (marmaraBolgesi.Contains(sehir))
            //    {
            //        Console.WriteLine(index + " => " + sehir + " => Marmara Bolgesindedir");
            //    }
            //    else
            //    {
            //        Console.WriteLine(index + " => " + sehir);
            //    }
            //    index++;
            //} 
            #endregion

            //foreach (var item in collection)
            //{

            //}

            //var o = new Order()
            //{
            //    OrderId = faker.Random.Number(1, 100),
            //    Item = faker.Lorem.Sentence(),
            //    Quantity = faker.Random.Number(1, 10)
            //};
            //o.Dump();

            #region 1-100 arasinda 50 adet sayi uretip bir diziye atalim

            List<int> sayilar = new List<int>();

            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(rnd.Next(100));
            }

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
