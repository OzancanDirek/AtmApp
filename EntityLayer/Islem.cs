using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Islem
    {

        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
