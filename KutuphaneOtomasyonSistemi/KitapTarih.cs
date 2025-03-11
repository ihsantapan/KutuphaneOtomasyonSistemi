using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{
    public class KitapTarih : Kitap
    {
        public KitapTarih(string isbn, string baslik, string yayinYili, string yazar, string yayınevi, int stokAdedi) : base(isbn, baslik, yayinYili, yazar, yayınevi, stokAdedi)
        {
        }
    }
}
