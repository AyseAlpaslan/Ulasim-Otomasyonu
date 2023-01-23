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
    public class FYolcular
    {

        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("YListele", Baglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static int Ekleme(EYolcular veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("YEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("YolcuAdSoyad", veri.YolcuAdSoyad);
                komut.Parameters.AddWithValue("YolcuMail", veri.YolcuMail);
                komut.Parameters.AddWithValue("YolcuTelefon", veri.YolcuTelefon);
                komut.Parameters.AddWithValue("OtobusNo", veri.OtobusNo);            
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }

        public static bool Guncelle(EYolcular islem)
        {
            SqlCommand komut = new SqlCommand("YYenile", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("YolcuNo", islem.YolcuNo);
            komut.Parameters.AddWithValue("YolcuAdSoyad", islem.YolcuAdSoyad);
            komut.Parameters.AddWithValue("YolcuMail", islem.YolcuMail);
            komut.Parameters.AddWithValue("YolcuTelefon", islem.YolcuTelefon);
            komut.Parameters.AddWithValue("OtobusNo", islem.OtobusNo);
            return Baglanti.ExecuteNonQuery(komut);
        }


        public static bool Sil(EYolcular islem)
        {
            SqlCommand komut = new SqlCommand("YSil", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("YolcuNo", islem.YolcuNo);
            return Baglanti.ExecuteNonQuery(komut);
        }



    }
}
