using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace veresiye_takip_1
{
    public class DL
    {
        static MySqlConnection baglanti = new MySqlConnection(
            new MySqlConnectionStringBuilder() { 
                Server="127.0.0.1",
                Database="veresiye_takip",
                UserID="tester",
                Password="Tester_74"
            }.ConnectionString
            );


        public static int KisiEkle(string kid, string ad, string soyad, string tel, string mail) {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "insert into kisiler values(@kid,@adi,@soyadi,@telefon,@mail)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);

                komut.Parameters.AddWithValue("@kid", kid);
                komut.Parameters.AddWithValue("@adi", ad);
                komut.Parameters.AddWithValue("@soyadi", soyad);
                komut.Parameters.AddWithValue("@telefon", tel);
                komut.Parameters.AddWithValue("@mail", mail);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }        
        }

        public static int KisiSil(string kid)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string delete = "delete from kisiler where kid=@kid";
                MySqlCommand komut = new MySqlCommand(delete, baglanti);

                komut.Parameters.AddWithValue("@kid", kid);                

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KisiDuzenle(string kid, string ad, string soyad, string tel, string mail)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "update kisiler  " +
                    "set adi=@adi, soyadi=@soyadi,telefon=@telefon,mail=@mail " +
                    "where kid=@kid";
                MySqlCommand komut = new MySqlCommand(update, baglanti);
                                
                komut.Parameters.AddWithValue("@adi", ad);
                komut.Parameters.AddWithValue("@soyadi", soyad);
                komut.Parameters.AddWithValue("@telefon", tel);
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@kid", kid);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }


        public static int GirdiEkle(string kid,string gid,float miktar,DateTime tarih,string aciklama)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "insert into borclar values(@gid,@kid,@miktar,@tarih,@aciklama)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);

                komut.Parameters.AddWithValue("@gid", gid);
                komut.Parameters.AddWithValue("@kid", kid);
                komut.Parameters.AddWithValue("@miktar", miktar);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@aciklama", aciklama);
                
                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int GirdiDuzenle(string gid, float miktar, DateTime tarih, string aciklama)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "update borclar set miktar=@miktar, tarih=@tarih, aciklama=@aciklama where gid=@gid";
                MySqlCommand komut = new MySqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@miktar", miktar);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@aciklama", aciklama);
                komut.Parameters.AddWithValue("@gid", gid);            
                

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int GirdiSil(string gid)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sil = "delete from borclar where gid=@gid";
                MySqlCommand komut = new MySqlCommand(sil, baglanti);

                komut.Parameters.AddWithValue("@gid", gid);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<Kisi> KisileriListele()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "select * from kisiler";
                MySqlCommand komut = new MySqlCommand(select, baglanti);

                MySqlDataReader dr = komut.ExecuteReader();
                List<Kisi> kisiler = new List<Kisi>();
                while (dr.Read())
                {
                    kisiler.Add(new Kisi()
                    {
                        kID = Guid.Parse(dr[0].ToString()),
                        Ad = dr[1].ToString(),
                        SoyAd = dr[2].ToString(),
                        Telefon = dr[3].ToString(),
                        Mail = dr[4].ToString()
                    });
                }
                return kisiler;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<Girdi> GirdileriListele(string kid)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "select * from borclar where kid=@kid";
                MySqlCommand komut = new MySqlCommand(select, baglanti);
                komut.Parameters.AddWithValue("@kid", kid);

                MySqlDataReader dr = komut.ExecuteReader();
                List<Girdi> girdiler = new List<Girdi>();
                while (dr.Read())
                {
                    girdiler.Add(new Girdi()
                    {
                        gID = Guid.Parse(dr[0].ToString()),
                        kID = Guid.Parse(kid),
                        Miktar= float.Parse(dr[2].ToString()),
                        Tarih = (DateTime)dr[3],
                        Aciklama = dr[4].ToString()
                    });
                }
                return girdiler;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }


    }
}
