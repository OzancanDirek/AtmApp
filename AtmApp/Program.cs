using BusinessLayer;

namespace AtmUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmServiceBL atmService = new AtmServiceBL();

            Console.WriteLine("ATM'ye hoş geldiniz!");
            Console.Write("Kullanıcı Adınızı Girin: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifrenizi Girin: ");
            string sifre = Console.ReadLine();

            var kullanici = atmService.GirisYap(kullaniciAdi, sifre);

            if (kullanici != null)
            {
                Console.WriteLine($"Hoş geldiniz, {kullanici.KullaniciAdi}!");
                bool devam = true;

                while (devam)
                {
                    Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
                    Console.WriteLine("1 - Bakiye Sorgula");
                    Console.WriteLine("2 - Para Çek");
                    Console.WriteLine("3 - Para Yatır");
                    Console.WriteLine("4 - Çıkış");

                    int secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine($"Bakiye: {kullanici.Bakiye} TL");
                            break;

                        case 2:
                            Console.Write("Çekmek istediğiniz miktarı girin: ");
                            decimal cekilecekMiktar = Convert.ToDecimal(Console.ReadLine());
                            bool cekimBasarili = atmService.ParaCek(kullanici, cekilecekMiktar);
                            if (cekimBasarili)
                            {
                                Console.WriteLine($"Başarıyla {cekilecekMiktar} TL çektiniz. Kalan bakiye: {kullanici.Bakiye} TL");
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye.");
                            }
                            break;

                        case 3:
                            Console.Write("Yatırmak istediğiniz miktarı girin: ");
                            decimal yatirilanMiktar = Convert.ToDecimal(Console.ReadLine());
                            atmService.ParaYatir(kullanici, yatirilanMiktar);
                            Console.WriteLine($"Başarıyla {yatirilanMiktar} TL yatırdınız. Güncel bakiye: {kullanici.Bakiye} TL");
                            break;

                        case 4:
                            devam = false;
                            Console.WriteLine("Çıkış yapılıyor...");
                            break;

                        default:
                            Console.WriteLine("Geçersiz işlem.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
            }

            Console.WriteLine("Program sonlandırıldı.");
        }
    }
}
