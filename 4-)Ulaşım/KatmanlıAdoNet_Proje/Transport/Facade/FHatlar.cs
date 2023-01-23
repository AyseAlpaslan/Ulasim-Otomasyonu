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
    public class FHatlar
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("HListele", Baglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public static int Ekleme(EHatlar veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("HEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
            
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("HatAdi", veri.HatAdi);
                komut.Parameters.AddWithValue("HatGuzergahBaslangici", veri.HatGuzergahBaslangici);
                komut.Parameters.AddWithValue("HatGuzergahBitisi", veri.HatGuzergahBitisi);             
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
        }

        public static bool Guncelle(EHatlar islem)
        {
            SqlCommand komut = new SqlCommand("HYenile", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("HatNo", islem.HatNo);
            komut.Parameters.AddWithValue("HatAdi", islem.HatAdi);
            komut.Parameters.AddWithValue("HatGuzergahBaslangici", islem.HatGuzergahBaslangici);
            komut.Parameters.AddWithValue("HatGuzergahBitisi", islem.HatGuzergahBitisi);
            return Baglanti.ExecuteNonQuery(komut);
        }


        public static bool Sil(EHatlar islem)
        {
            SqlCommand komut = new SqlCommand("HSil", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("HatNo", islem.HatNo);
            return Baglanti.ExecuteNonQuery(komut);
        }






    }
}
