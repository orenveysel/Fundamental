using _20_MyLibrary;
using 
namespace _21_LibraryKullanma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = Tools.SayiGir("Bir sayi giriniz: ");
            FakeData fakeData = new FakeData();
            var result = fakeData.KisiListesiVer(100);

            foreach (var item in result)
            {
                Console.WriteLine(item.Id + " " + item.Ad + " " + item.Soyad);
            }

            //Console.WriteLine(sayi);
            Console.WriteLine("Hello, World!");
        }
    }
}
