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
    public class FBiletler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("BListele", Baglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }



        public static int Ekleme(EBiletler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("BEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("YolcuAdSoyad ", veri.YolcuAdSoyad);
                komut.Parameters.AddWithValue("YolcuKoltukNo", veri.YolcuKoltukNo);
                komut.Parameters.AddWithValue("OtobusTipi", veri.OtobusTipi);
                komut.Parameters.AddWithValue("OtobusFirma", veri.OtobusFirma);
                komut.Parameters.AddWithValue("OtobusKalkisYeri", veri.OtobusKalkisYeri);
                komut.Parameters.AddWithValue("OtobusVarisYeri", veri.OtobusVarisYeri);
                komut.Parameters.AddWithValue("OtobusKalkisZamani", veri.OtobusKalkisZamani);
                komut.Parameters.AddWithValue("OtobusVarisZamani", veri.OtobusVarisZamani);
                komut.Parameters.AddWithValue("OtobusKalkisTarihi", veri.OtobusKalkisTarihi);
                komut.Parameters.AddWithValue("OtobusVarisTarihi", veri.OtobusVarisTarihi);
                komut.Parameters.AddWithValue("BiletFiyati", veri.BiletFiyati);
                komut.Parameters.AddWithValue("YolcuNo", veri.YolcuNo);
                islem = komut.ExecuteNonQuery();
            }
            catch
            {
                islem = -1;
            }
            return islem;
    }

        public static bool Guncelle(EBiletler islem)
        {
            SqlCommand komut = new SqlCommand("BYenile", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("BiletNo ", islem.BiletNo);
            komut.Parameters.AddWithValue("YolcuAdSoyad ", islem.YolcuAdSoyad);
            komut.Parameters.AddWithValue("YolcuKoltukNo", islem.YolcuKoltukNo);
            komut.Parameters.AddWithValue("OtobusTipi", islem.OtobusTipi);
            komut.Parameters.AddWithValue("OtobusFirma", islem.OtobusFirma);
            komut.Parameters.AddWithValue("OtobusKalkisYeri", islem.OtobusKalkisYeri);
            komut.Parameters.AddWithValue("OtobusVarisYeri", islem.OtobusVarisYeri);
            komut.Parameters.AddWithValue("OtobusKalkisZamani", islem.OtobusKalkisZamani);
            komut.Parameters.AddWithValue("OtobusVarisZamani", islem.OtobusVarisZamani);
            komut.Parameters.AddWithValue("OtobusKalkisTarihi", islem.OtobusKalkisTarihi);
            komut.Parameters.AddWithValue("OtobusVarisTarihi", islem.OtobusVarisTarihi);
            komut.Parameters.AddWithValue("BiletFiyati", islem.BiletFiyati);
            komut.Parameters.AddWithValue("YolcuNo", islem.YolcuNo);
            return Baglanti.ExecuteNonQuery(komut);
        }


        public static bool Sil(EBiletler islem)
        {
            SqlCommand komut = new SqlCommand("BSil", Baglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("BiletNo", islem.BiletNo);
            return Baglanti.ExecuteNonQuery(komut);
        }

    }
}
