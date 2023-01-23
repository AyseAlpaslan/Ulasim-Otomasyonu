using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
    public class FOtobusler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("OListele", Baglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public static int Ekleme(EOtobusler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("OEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("OtobusFirma", veri.OtobusFirma);
                komut.Parameters.AddWithValue("OtobusPlaka", veri.OtobusPlaka);
                komut.Parameters.AddWithValue("OtobusTipi", veri.OtobusTipi);
                komut.Parameters.AddWithValue("OtobusKapasite", veri.OtobusKapasite);
                komut.Parameters.AddWithValue("OtobusSoforAdSoyad", veri.OtobusSoforAdSoyad);
                komut.Parameters.AddWithValue("HatNo", veri.HatNo);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }

        public static bool Guncelle(EOtobusler islem)
        {
            SqlCommand komut = new SqlCommand("OYenile", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OtobusNo", islem.OtobusNo);
            komut.Parameters.AddWithValue("OtobusFirma", islem.OtobusFirma);
            komut.Parameters.AddWithValue("OtobusPlaka", islem.OtobusPlaka);
            komut.Parameters.AddWithValue("OtobusTipi", islem.OtobusTipi);
            komut.Parameters.AddWithValue("OtobusKapasite", islem.OtobusKapasite);
            komut.Parameters.AddWithValue("OtobusSoforAdSoyad", islem.OtobusSoforAdSoyad);
            komut.Parameters.AddWithValue("HatNo", islem.HatNo);
            return Baglanti.ExecuteNonQuery(komut);
        }


        public static bool Sil(EOtobusler islem)
        {
            SqlCommand komut = new SqlCommand("OSil", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OtobusNo", islem.HatNo);
            return Baglanti.ExecuteNonQuery(komut);
        }






    }
}
