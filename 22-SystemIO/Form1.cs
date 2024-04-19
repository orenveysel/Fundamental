using System.IO;
namespace _22_SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DriverInfo surucu bilgilerine erisim saglar
            var suruculer = DriveInfo.GetDrives();

            foreach (var drive in suruculer)
            {

                if (drive.IsReady)
                {
                    listBox1.Items.Add("Surucu Adi: " + drive.Name);
                    listBox1.Items.Add("Bos Alan: " + drive.TotalFreeSpace);
                    listBox1.Items.Add("Toplam Adi: " + drive.TotalSize);
                    listBox1.Items.Add("Tanimli On Adi: " + drive.VolumeLabel);
                    listBox1.Items.Add("Formatlanma Tipi: " + drive.DriveFormat);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Klasorler ile ilgili islemler yapmaya yarar
            string path = @"C:\";
            if (Directory.Exists(path)) // Klasor varsa
            {
                var Klasorler = Directory.GetDirectories(path);

                foreach (var dir in Klasorler)
                {
                    listBox2.Items.Add(dir);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listBox2.SelectedItem.ToString();

            var klasorler = Directory.GetDirectories(item);
            var dosyalar = Directory.GetFiles(item);
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            foreach (var klasor in klasorler)
            {
                listBox2.Items.Add(klasor);
            }
            foreach (var dosya in dosyalar)
            {
                listBox3.Items.Add(dosya);
            }
        }
    }
}
