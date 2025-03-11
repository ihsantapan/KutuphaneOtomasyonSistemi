using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{
    public class KitapRoman : Kitap
    {
        public KitapRoman(string isbn, string baslik, string yayinYili, string yazar, string yayınevi, int stokAdedi) : base(isbn, baslik, yayinYili, yazar, yayınevi, stokAdedi)
        {
        }
    }
}
