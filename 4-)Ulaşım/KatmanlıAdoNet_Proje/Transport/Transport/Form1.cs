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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Liste()
        {
            dataGridView1.DataSource = FHatlar.Listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EHatlar ekleme = new EHatlar();
            ekleme.HatAdi = textBox1.Text;
            ekleme.HatGuzergahBaslangici = textBox2.Text;
            ekleme.HatGuzergahBitisi = textBox3.Text;
            FHatlar.Ekleme(ekleme);
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EHatlar ekleme = new EHatlar();
            ekleme.HatNo = Convert.ToInt32(textBox1.Tag);
            ekleme.HatAdi = textBox1.Text;
            ekleme.HatGuzergahBaslangici = textBox2.Text;
            ekleme.HatGuzergahBitisi = textBox3.Text;
            FHatlar.Guncelle(ekleme);
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EHatlar sil = new EHatlar();
            sil.HatNo = Convert.ToInt32(textBox1.Tag);
            FHatlar.Sil(sil);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["HatNo"].Value.ToString();
            textBox1.Text = satir.Cells["HatAdi"].Value.ToString();
            textBox2.Text = satir.Cells["HatGuzergahBaslangici"].Value.ToString();
            textBox3.Text = satir.Cells["HatGuzergahBitisi"].Value.ToString();          
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
