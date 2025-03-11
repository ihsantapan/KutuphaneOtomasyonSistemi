using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        public Uye(string ad, string soyad, int uyeNumarasi)
        {
            Ad= ad;
            Soyad= soyad;
            UyeNumarasi= uyeNumarasi;
            OduncAlinanKitaplar = new List<Kitap>();
        }
        public void KitapIadeEt(Kitap kitap)
        {
            if(OduncAlinanKitaplar.Contains(kitap))
            {
                kitap.Stok++;

                kitap.Durum = Durum.OduncAlinabilir;
                OduncAlinanKitaplar.Remove(kitap);
                Console.WriteLine($"{Ad} {Soyad} \"{kitap.Baslik}\" adlı kitabı iade etti.");
            }
            else
            {
                Console.WriteLine($"\"{kitap.Baslik}\" kitabı bu üyeye ait değil.");
            }
        }

        public void OduncKitapAl(Kitap kitap)
        {
            if(kitap.Durum==Durum.OduncAlinabilir && kitap.Stok>0)
            {
                kitap.Stok--;

                if(kitap.Stok==0)
                {
                    kitap.Durum = Durum.MevcutDegil;
                }

                kitap.Durum = Durum.OduncVerildi;
                OduncAlinanKitaplar.Add(kitap);
                Console.WriteLine($"{Ad} {Soyad}, \"{kitap.Baslik}\" kitabını ödünç aldı.");

            }
            else
            {
                Console.WriteLine($"\"{kitap.Baslik}\" kitabı şu an ödünç alınamaz.");
            }
        }
    }
}
