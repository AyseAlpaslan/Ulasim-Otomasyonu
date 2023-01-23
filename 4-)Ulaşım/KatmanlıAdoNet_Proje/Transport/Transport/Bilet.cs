using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;

namespace Transport
{
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            dataGridView1.DataSource = FBiletler.Listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EBiletler ekleme = new EBiletler();
            ekleme.YolcuAdSoyad = textBox1.Text;
            ekleme.YolcuKoltukNo = Convert.ToInt32(textBox2.Text);
            ekleme.OtobusTipi = textBox3.Text;
            ekleme.OtobusFirma = textBox4.Text;
            ekleme.OtobusKalkisYeri = textBox5.Text;
            ekleme.OtobusVarisYeri = textBox6.Text;
            ekleme.OtobusKalkisZamani = textBox7.Text;
            ekleme.OtobusVarisZamani = textBox8.Text;
            ekleme.OtobusKalkisTarihi = textBox9.Text;
            ekleme.OtobusVarisTarihi = textBox10.Text;
            ekleme.BiletFiyati =Convert.ToInt32(textBox11.Text);
            ekleme.YolcuNo =Convert.ToInt32(textBox12.Text);
            FBiletler.Ekleme(ekleme);
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EBiletler ekleme = new EBiletler();
            ekleme.BiletNo =Convert.ToInt32(textBox1.Tag);
            ekleme.YolcuAdSoyad = textBox1.Text;
            ekleme.YolcuKoltukNo = Convert.ToInt32(textBox2.Text);
            ekleme.OtobusTipi = textBox3.Text;
            ekleme.OtobusFirma = textBox4.Text;
            ekleme.OtobusKalkisYeri = textBox5.Text;
            ekleme.OtobusVarisYeri = textBox6.Text;
            ekleme.OtobusKalkisZamani = textBox7.Text;
            ekleme.OtobusVarisZamani = textBox8.Text;
            ekleme.OtobusKalkisTarihi = textBox9.Text;
            ekleme.OtobusVarisTarihi = textBox10.Text;
            ekleme.BiletFiyati = Convert.ToInt32(textBox11.Text);
            ekleme.YolcuNo = Convert.ToInt32(textBox12.Text);
            FBiletler.Guncelle(ekleme);
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EBiletler sil = new EBiletler();
            sil.BiletNo = Convert.ToInt32(textBox1.Tag);
            FBiletler.Sil(sil);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["BiletNo"].Value.ToString();
            textBox1.Text = satir.Cells["YolcuAdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["YolcuKoltukNo"].Value.ToString();
            textBox3.Text = satir.Cells["OtobusTipi"].Value.ToString();
            textBox4.Text = satir.Cells["OtobusFirma"].Value.ToString();
            textBox5.Text = satir.Cells["OtobusKalkisYeri"].Value.ToString();
            textBox6.Text = satir.Cells["OtobusVarisYeri"].Value.ToString();
            textBox1.Tag = satir.Cells["OtobusKalkisZamani"].Value.ToString();
            textBox1.Tag = satir.Cells["OtobusVarisZamani"].Value.ToString();
            textBox1.Tag = satir.Cells["OtobusKalkisTarihi"].Value.ToString();
            textBox1.Tag = satir.Cells["OtobusVarisTarihi"].Value.ToString();
            textBox1.Tag = satir.Cells["BiletFiyati"].Value.ToString();
            textBox1.Tag = satir.Cells["YolcuNo"].Value.ToString();
        }

        private void hatlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otobus go = new Otobus();
            go.Show();
            this.Hide();
        }

        private void yolcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yolcu go = new Yolcu();
            go.Show();
            this.Hide();
        }

        private void biletlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilet go = new Bilet();
            go.Show();
            this.Hide();
        }
    }
}
