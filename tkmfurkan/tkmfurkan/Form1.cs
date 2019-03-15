using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace tkmfurkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sure = 20;
        int bsayi;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label3.Text = "Süre = " +sure.ToString();
            if (sure == 0)
            {
                MessageBox.Show("Süren Doldu, Kaybettin.");
                Application.Exit();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\song.wav";
            ses.SoundLocation = dizin;
            ses.Play();

            Random rastgele = new Random();
            int sayi = rastgele.Next(3);
        }
        
        int skor = 0;
        int hak = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            bsayi = 1;
            Random rastgele = new Random();
            int sayi = rastgele.Next(4);
            if (sayi == 3)
            {
                MessageBox.Show("Bilgisayar makas yaptı, sen taş yaptın ve kazandın.");
                skor += 100;
                label2.Text = "Skor = "+skor.ToString();
                sure = 20;
            }
            else if (sayi == 2)
            {
                MessageBox.Show("Bilgisayar kağıt yaptı, sen taş yaptın ve kaybettin.");
                skor -= 20;
                label2.Text = "Skor = " + skor.ToString();
                sure = 20;
                hak--;
                label1.Text = "Hak = " + hak.ToString();
            }
            else if (sayi == 1)
            {
                MessageBox.Show("Bilgisayar da sende taş yaptınız.");
                sure = 20;
            }
            if (hak == 0)
            {
                MessageBox.Show("Hakkın kalmadı ve kaybettin!");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsayi = 2;
            Random rastgele = new Random();
            int sayi = rastgele.Next(3);
            if (sayi == 3)
            {
                MessageBox.Show("Bilgisayar makas yaptı, sen kağıt yaptın ve kaybettin.");
                skor -= 20;
                label2.Text = "Skor = " + skor.ToString();
                sure = 20;
                hak--;
                label1.Text = "Hak = " + hak.ToString();
            }
            else if (sayi == 2)
            {
                MessageBox.Show("Bilgisayar da sende kağıt yaptınız.");
                sure = 20;
            }
            else if (sayi == 1)
            {
                MessageBox.Show("Bilgisayar taş yaptı, sen kağıt yaptın ve kazandın.");
                sure = 20;
                skor += 100;
                label2.Text = "Skor = " + skor.ToString();
            }
            if (hak == 0)
            {
                MessageBox.Show("Hakkın kalmadı ve kaybettin!");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsayi = 3;
            Random rastgele = new Random();
            int sayi = rastgele.Next(3);
            if (sayi == 3)
            {
                MessageBox.Show("Bilgisayar da sende makas yaptınız.");
                sure = 20;
            }
            else if (sayi == 2)
            {
                MessageBox.Show("Bilgisayar kağıt yaptı, sen makas yaptın ve kazandın.");
                sure = 20;
                skor += 100;
                label2.Text = "Skor = " + skor.ToString();
            }
            else if (sayi == 1)
            {
                MessageBox.Show("Bilgisayar taş yaptı, sen makas yaptın ve kaybettin.");
                skor -= 20;
                label2.Text = "Skor = " + skor.ToString();
                sure = 20;
                hak--;
                label1.Text = "Hak = " + hak.ToString();
            }
            if (hak == 0)
            {
                MessageBox.Show("Hakkın kalmadı ve kaybettin!");
                Application.Exit();
            }
        }
    }
}
