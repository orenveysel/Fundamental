namespace _6_Try_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Onaylama_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a= 5;
            b= 6;
            c= 7;
            int toplam = a + b + c; // 18 cikar
            int carpma = a * b * c; // 210 cikar
            c = 1;
            int bolum = a / c; // DivideByZero hatasi alacaktir
        }
    }
}
