using EntityLayer;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class KullaniciDal
    {
        private readonly string baglanti = @"Server=LAPTOP-QD8VUNPD\SQLEXPRESS;Database=Atm;Trusted_Connection=True;";


        public List<Kullanici> KullanicilariGetir()
        {
            var kullanicilar = new List<Kullanici>();

            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();

                SqlCommand komut = new SqlCommand("select * from Kullanicilar", connection);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    kullanicilar.Add(new Kullanici
                    {
                        Id = (int)dr["Id"],
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Sifre = dr["Sifre"].ToString(),
                        Bakiye = (decimal)dr["Bakiye"]
                    });
                }

            }
            return kullanicilar;
        }
        public void BakiyeGuncelle(Kullanici kullanici)
        {
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Update Kullanicilar set Bakiye = @Bakiye where Id = @Id",connection);
                command.Parameters.AddWithValue("@Bakiye",kullanici.Bakiye);
                command.Parameters.AddWithValue("@Id",kullanici.Id);
                command.ExecuteNonQuery();
            }
        }

        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            using (SqlConnection connection = new SqlConnection(baglanti))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", connection);

                command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", sifre);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Kullanici
                    {
                        Id = (int)reader["Id"],
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Sifre = reader["Sifre"].ToString(),
                        Bakiye = (decimal)reader["Bakiye"]
                    };
                }

                return null;
            }
        }
    }
}