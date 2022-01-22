namespace Int_Değişkenler_Aritmetik_İşlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, fark, carpma, bolum;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            bolum = sayi1 / sayi2;
            carpma = sayi1 * sayi2;
            MessageBox.Show("Toplam: " + toplam + "\n" + "Fark: " + fark + "\n" + "Çarpma: " + carpma + "\n" + "Bölüm: " + bolum);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}