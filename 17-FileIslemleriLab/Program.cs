namespace _17_FileIslemleriLab
{
    //Id;FilmAdi;Aciklama;Sure
    public struct Film
    {
        public int Id;
        public string FilmAdi;
        public string Aciklama;
        public int Sure;
    }

    // id,city,gender,CardType,Sector,Department
    public struct Kayit
    {
        public int Id;
        public string City;
        public string Gender;
        public string CardType;
        public string Sector;
        public string Department;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kayit
            List<Kayit> kayitListesi = new List<Kayit>();
            string fileName = "C:\\Users\\Lenovo\\source\\repos\\Istka2024\\Fundamental\\15-HazirMetodlar\\bin\\Debug\\net8.0\\SampleFile (1).csv";


            string[] satirlar = File.ReadAllLines(fileName);

            for (int i = 1; i < satirlar.Length; i++)
            {
                string[] satir = satirlar[i].Split(",");
                // id,city,gender,CardType,Sector,Department
                //Buradaki tanimlama da aynidir
                //var satir1 = satirlar[0].Split(",");

                Kayit kayit = new Kayit();
                //kayit.Id = int.Parse(satir[0]);
                int.TryParse(satir[0], out kayit.Id);
                kayit.City = satir[1];
                kayit.Gender = satir[2];
                kayit.CardType = satir[3];
                kayit.Sector = satir[4];
                kayit.Department = satir[5];

                kayitListesi.Add(kayit);
            }
            foreach (var kayit in kayitListesi)
            {
                // id,city,gender,CardType,Sector,Department
                Console.WriteLine($"{kayit.Id}\t{kayit.City}\t{kayit.Gender}\t{kayit.CardType}\t{kayit.Sector}\t{kayit.Department}");
            }
            Console.WriteLine("Hello, World!");
            #endregion


            #region Film
            List<Film> filmler = new List<Film>();
            string fileName1 = "C:\\Users\\Lenovo\\source\\repos\\Istka2024\\Fundamental\\15-HazirMetodlar\\bin\\Debug\\net8.0\\Filmler.csv";

            string[] satirlar1 = File.ReadAllLines(fileName1);

            for (int i = 1; i < satirlar1.Length; i++)
            {
                string[] satir1 = satirlar1[i].Split(";");
                //Id;FilmAdi;Aciklama;Sure

                Film film = new Film();
                int.TryParse(satir1[0], out film.Id);
                film.FilmAdi = satir1[1];
                film.Aciklama = satir1[2];
                int.TryParse(satir1[3], out film.Sure);

                filmler.Add(film);
            }
            foreach (var film in filmler)
            {
                //Id;FilmAdi;Aciklama;Sure
                Console.WriteLine($"{film.Id}\n{film.FilmAdi}\n{film.Aciklama}\n{film.Sure}\n");
            } 
            #endregion
        }
    }
}
