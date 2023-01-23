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
    public partial class Yolcu : Form
    {
        public Yolcu()
        {
            InitializeComponent();
        }

        private void Liste()
        {
            dataGridView1.DataSource = FYolcular.Listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EYolcular ekleme = new EYolcular();
            ekleme.YolcuAdSoyad = textBox1.Text;
            ekleme.YolcuMail = textBox2.Text;
            ekleme.YolcuTelefon = maskedTextBox1.Text;
            ekleme.OtobusNo = Convert.ToInt32(textBox3.Text);      
            FYolcular.Ekleme(ekleme);
            Liste();       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EYolcular ekleme = new EYolcular();
            ekleme.YolcuNo = Convert.ToInt32(textBox1.Tag);
            ekleme.YolcuAdSoyad = textBox1.Text;
            ekleme.YolcuMail = textBox2.Text;
            ekleme.YolcuTelefon = maskedTextBox1.Text;
            ekleme.OtobusNo = Convert.ToInt32(textBox3.Text);
            FYolcular.Guncelle(ekleme);
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EYolcular sil = new EYolcular();
            sil.YolcuNo = Convert.ToInt32(textBox1.Tag);
            FYolcular.Sil(sil);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["YolcuNo"].Value.ToString();
            textBox1.Text = satir.Cells["YolcuAdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["YolcuMail"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["YolcuTelefon"].Value.ToString();
            textBox3.Text = satir.Cells["OtobusNo"].Value.ToString();        
        }

        private void Yolcu_Load(object sender, EventArgs e)
        {

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
