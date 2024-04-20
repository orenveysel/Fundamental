namespace _23_VeriGirisEkrani
{
    public partial class Form1 : Form
    {
        List<Personel> personelListesi = new List<Personel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Personel Nesnesi Olusturma
            Personel personel = new Personel();
            personel.Id = 1;
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.Cinsiyet = rdbErkek.Checked;
            personel.Sehir = cmbSehir.Text;
            personel.DogumTarihi = dogumTarihiPicker.Value;
            personel.Departman = cmbDepartman.Text;
            personel.Maas = maasUpDown.Value;
            #endregion

            #region Olusan Personel Listeye Atilsin
            personelListesi.Add(personel);
            #endregion

            #region Olusan Kayit Dosyaya Kaydedilsin

            StreamWriter sw = File.AppendText("Personel.txt");

            sw.WriteLine(personel.Id + ";" + personel.Ad + ";" + personel.Soyad + ";" + personel.Cinsiyet + ";"
                + personel.Sehir + ";" + personel.DogumTarihi + ";" + personel.Departman + ";" + personel.Maas);

            sw.Close();

            #endregion

            #region Veri Giris Ekranini Sifirlama
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            rdbErkek.Checked = false;
            rdbKadin.Checked = false;
            cmbSehir.SelectedIndex = 0;
            dogumTarihiPicker.Value = DateTime.Now;
            cmbDepartman.SelectedIndex = 0;
            maasUpDown.Value = 17002;
            #endregion

        }

        public int SonNumarayiVer()
        {
            var veriler = File.ReadAllLines("Personel.txt");
            int sondeger = int.Parse(veriler[veriler.Length - 1].Split(';')[0]);
            sondeger++;
            return sondeger;
        }
    }
}
