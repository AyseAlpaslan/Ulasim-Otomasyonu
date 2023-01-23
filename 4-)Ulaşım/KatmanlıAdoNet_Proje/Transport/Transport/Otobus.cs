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
    public partial class Otobus : Form
    {
        public Otobus()
        {
            InitializeComponent();
        }

        private void Liste()
        {
            dataGridView1.DataSource = FOtobusler.Listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EOtobusler ekleme = new EOtobusler();
            ekleme.OtobusFirma = textBox1.Text;
            ekleme.OtobusPlaka = textBox2.Text;
            ekleme.OtobusTipi = textBox3.Text;
            ekleme.OtobusKapasite =Convert.ToInt32(textBox4.Text);
            ekleme.OtobusSoforAdSoyad = textBox5.Text;
            ekleme.HatNo =Convert.ToInt32(textBox6.Text);
            FOtobusler.Ekleme(ekleme);
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EOtobusler yenile = new EOtobusler();
            yenile.OtobusNo = Convert.ToInt32(textBox1.Tag);
            yenile.OtobusFirma = textBox1.Text;
            yenile.OtobusPlaka = textBox2.Text;
            yenile.OtobusTipi = textBox3.Text;
            yenile.OtobusKapasite = Convert.ToInt32(textBox4.Text);
            yenile.OtobusSoforAdSoyad = textBox5.Text;
            yenile.HatNo = Convert.ToInt32(textBox6.Text);
            FOtobusler.Guncelle(yenile);
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EOtobusler sil = new EOtobusler();
            sil.HatNo = Convert.ToInt32(textBox1.Tag);
            FOtobusler.Sil(sil);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["OtobusNo"].Value.ToString();
            textBox1.Text = satir.Cells["OtobusFirma"].Value.ToString();
            textBox2.Text = satir.Cells["OtobusPlaka"].Value.ToString();
            textBox3.Text = satir.Cells["OtobusTipi"].Value.ToString();
            textBox4.Text = satir.Cells["OtobusKapasite"].Value.ToString();
            textBox5.Text = satir.Cells["OtobusSoforAdSoyad"].Value.ToString();
            textBox6.Text = satir.Cells["HatNo"].Value.ToString();
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
