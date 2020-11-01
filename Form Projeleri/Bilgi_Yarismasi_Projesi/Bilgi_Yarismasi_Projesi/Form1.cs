using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnb.Text;
            if (label4.Text==label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;

            label5.Text = btna.Text;
            if (label4.Text==label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
            soruno++;
            lblsoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhurriyet kaç yılında kurulmuştur?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege Bölgemizde bulunmaz?";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar kitabı hangi şairimize aittir?";
                btna.Text = "Sait Faik";
                btnb.Text = "Cemal Süreya";
                btnc.Text = "Atila İlhan";
                btnd.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Fatih Sultan Mehmet'in babası Kimdir?";
                btna.Text = "I. Mehmet";
                btnb.Text = "Yıldırım Bayezid";
                btnc.Text = "II. Murat";
                btnd.Text = "I. Murat";
                label4.Text = "II. Murat";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Kıbrıs Barış Harekatı hangi tarihte gerçekleşmiştir?";
                btna.Text = "1971";
                btnb.Text = "1974";
                btnc.Text = "1972";
                btnd.Text = "1973";
                label4.Text = "1974";              
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Fransız İhtilali kaç yılları arasında gerçekleşmiştir?";
                btna.Text = "1768-1786";
                btnb.Text = "1789-1799";
                btnc.Text = "1876-1889";
                btnd.Text = "1889-1899";
                label4.Text = "1789-1799";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Hangi hayvan memeli değildir?";
                btna.Text = "Yarasa";
                btnb.Text = "Kanguru";
                btnc.Text = "Penguen";
                btnd.Text = "Yunus";
                label4.Text = "Penguen";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Kuyucaklı Yusuf adlı eser hangi şairimize aittir?";
                btna.Text = "Yusuf Atılgan";
                btnb.Text = "Yaşar Kemal";
                btnc.Text = "Recaizade Mahmut";
                btnd.Text = "Sabahattin Ali";
                label4.Text = "Sabahattin Ali";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Osmanlı'da Lale Devri hangi padişah döneminde gerçekleşmiştir?";
                btna.Text = "III. Ahmet";
                btnb.Text = "IV. Murat";
                btnc.Text = "III. Selim";
                btnd.Text = "Muhteşem Süleyman";
                label4.Text = "III. Ahmet";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "İstiklal Marşı hangi yıl yazılmıştır?";
                btna.Text = "1920";
                btnb.Text = "1922";
                btnc.Text = "1921";
                btnd.Text = "1923";
                label4.Text = "1921";
                btnsonraki.Text = "Sonuçlar";
            }
            if (soruno == 11)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("Doğru Sayısı: " + dogru + "\n" + "Yanlış Sayısı: " + yanlis);
            }
        }
        }
    }