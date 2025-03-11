using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{
    public interface IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        public void OduncKitapAl(Kitap Kitap);
        public void KitapIadeEt(Kitap kitap);
    }
}
