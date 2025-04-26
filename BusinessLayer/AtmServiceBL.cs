using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AtmServiceBL
    {
        private readonly KullaniciDal _kullaniciDal = new KullaniciDal();

        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            try
            {
                return _kullaniciDal.GirisYap(kullaniciAdi, sifre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
                return null;
            }
        }

        public bool BakiyeGuncelle(Kullanici kullanici)
        {
            try
            {
                _kullaniciDal.BakiyeGuncelle(kullanici);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bakiye güncellenemedi: " + ex.Message);
                return false;
            }
        }

        public List<Kullanici> KullanicilariGetir()
        {
            try
            {
                return _kullaniciDal.KullanicilariGetir();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kullanıcılar getirilemedi: " + ex.Message);
                return new List<Kullanici>();
            }
        }
        public bool ParaCek(Kullanici kullanici, decimal miktar)
        {
            if (kullanici.Bakiye >= miktar)
            {
                kullanici.Bakiye -= miktar;
                BakiyeGuncelle(kullanici);
                return true;
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
                return false;
            }
        }
        public void ParaYatir(Kullanici kullanici, decimal miktar)
        {
            kullanici.Bakiye += miktar;
            BakiyeGuncelle(kullanici);
        }
    }
}