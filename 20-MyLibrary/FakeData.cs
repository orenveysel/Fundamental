using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MyLibrary
{
    public struct Kisi
    {
        public int Id;
        public string Ad;
        public string Soyad;
        public string Cinsiyet;
        public DateTime DogumTarihi;
    }
    /// <summary>
    /// Fake Data olusturmaya yarayan Siniftir
    /// </summary>

    public class FakeData
    {
        Faker faker = new Faker("tr");
        /// <summary>
        /// Kisilerden olusan bir liste doner
        /// </summary>
        /// <param name="adet">Uretilecek kisi sayisi, integer olmalidir</param>
        /// <returns>Verilen adet kadar kisi listesi doner</returns>
        public List<Kisi> KisiListesiVer(int adet)
        {
            List<Kisi> kisiler = new List<Kisi>();
            for (int i = 0; i < adet; i++)
            {
                Kisi kisi = new Kisi();
                kisi.Id = i;
                kisi.Ad = faker.Name.FirstName();
                kisi.Soyad = faker.Name.LastName();
                kisi.DogumTarihi = faker.Person.DateOfBirth;
                kisiler.Add(kisi);
            }
            return kisiler;
        }
    }
}
