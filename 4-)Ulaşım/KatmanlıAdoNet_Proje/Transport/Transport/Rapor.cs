using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;

namespace Transport
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=215-03\\SQLEXPRESS;Database=Ulasim;uid=sa;pwd=Ibb2022#!");
        public void method(string scode)
        {
            SqlDataAdapter dp = new SqlDataAdapter(scode, baglanti); //parametre alınmış
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //method("select YolcuAdSoyad,OtobusTipi,OtobusFirma,YolcuKoltukNo,OtobusKalkisYeri,OtobusVarisYeri,OtobusKalkisZamani,OtobusVarisZamani,OtobusKalkisTarihi,OtobusVarisTarihi,BiletFiyati,YolcuNo,OtobusKapasite * from Otobusler o inner join Hatlar h on o.HatNo=h.HatNo inner join Yolcular y on y.OtobusNo=o.OtobusNo inner join Biletler b on y.YolcuNo=b.YolcuNo");
        }
    }
}
