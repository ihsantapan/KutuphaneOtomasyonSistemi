using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{
    public abstract class Kitap
    {
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string YayinYili { get; set; }
        public string Yazar { get; set; }
        public string Yayınevi { get; set; }
        public int Stok { get; set; }
        public Durum Durum { get; set; }

        public Kitap(string isbn, string baslik, string yayinYili, string yazar, string yayınevi, int stokAdedi)
        {
            ISBN = isbn;
            Baslik = baslik;
            YayinYili = yayinYili;
            Yazar = yazar;
            Yayınevi = yayınevi;
            Stok = stokAdedi;
            Durum = stokAdedi > 0 ? Durum.OduncAlinabilir : Durum.MevcutDegil;
        }
    }
}
